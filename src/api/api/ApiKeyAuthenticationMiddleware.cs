using Microsoft.Extensions.Primitives;

namespace Api;

public class ApiKeyAuthenticationMiddleware
{
    private readonly RequestDelegate _next;
    private readonly string[] _excludedPaths = ["/", "/owners"];
    private const string ApiKeyHeaderName = "X-Api-Key";

    // Traditional constructor instead of primary constructor
    public ApiKeyAuthenticationMiddleware(RequestDelegate next)
    {
        _next = next;
        _excludedPaths = [.. _excludedPaths.Select(p => new PathString(p))];
    }

    public async Task InvokeAsync(HttpContext context, AppDbContext dbContext)
    {
        // Skip validation for excluded paths
        var isExcludedPath = _excludedPaths.Any(path => context.Request.Path.StartsWithSegments(path, StringComparison.OrdinalIgnoreCase));

        if (isExcludedPath)
        {
            await _next(context);
            return;
        }

        // Perform API key validation directly in middleware
        var isValidAPiKey = await IsValidApiKeyAsync(context, dbContext);
        if (!isValidAPiKey)
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            await context.Response.WriteAsync("Invalid or missing API key");
            return;
        }

        await _next(context);
    }

    private static async Task<bool> IsValidApiKeyAsync(HttpContext context, AppDbContext dbContext)
    {
        // Check if API key exists in header
        if (!context.Request.Headers.TryGetValue(ApiKeyHeaderName, out StringValues extractedApiKey))
        {
            return false;
        }

        var apiKey = extractedApiKey.ToString();

        // Validate API key format (must be a valid GUID)
        if (string.IsNullOrEmpty(apiKey) || !Guid.TryParse(apiKey, out var parsedApiKey))
        {
            return false;
        }

        // Check if the API key exists in the database
        bool isApiKeyValid = true; // TODO: check database or whatever...

        return isApiKeyValid;
    }
}
