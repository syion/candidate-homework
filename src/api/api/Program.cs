using Api;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add DbContext
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("YourConnectionStringGoesHere")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Lock down the app except for the homepage and creating an owner.
app.UseMiddleware<ApiKeyAuthenticationMiddleware>();

app.MapGet("/", () => $"Welcome to the Syion's Owners + Pet API! - {DateTime.UtcNow}");


// Define API endpoints for Owners
var ownersGroup = app.MapGroup("/owners").WithOpenApi();

ownersGroup.MapGet("/", async (AppDbContext db, HttpContext context) =>
{
    // TODO: *** Implement this endpoint ***
    return Results.Ok(await db.Owners.ToListAsync());
});

ownersGroup.MapGet("/{id}", async (
    int id, 
    AppDbContext db, 
    HttpContext context) =>
{
    // TODO: *** Implement this endpoint ***
    return Results.Ok();
});

ownersGroup.MapPost("/", async (
    Owner owner, 
    AppDbContext db, 
    HttpContext context) =>
{
    // TODO: *** Implement this endpoint ***
    return Results.Created();
});


var petsGroup = app.MapGroup("/pets").WithOpenApi();

petsGroup.MapGet("/", async (AppDbContext db, HttpContext context) =>
{
    // TODO: *** Implement this endpoint ***
    return Results.Ok();
});



app.Run();
