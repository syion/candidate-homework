using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api;

public class Owner
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    public Guid ApiKey { get; set; } = Guid.NewGuid();
    // Navigation property for related Pets
    public ICollection<Pet> Pets { get; set; } = new List<Pet>();
}

public class Pet
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [Required]
    public int OwnerId { get; set; }

    [MaxLength(50)]
    public string? Species { get; set; }

    [MaxLength(200)]
    public string? Description { get; set; }

    [MaxLength(20)]
    public string? Color { get; set; }

    public int? Age { get; set; }
    // Navigation property for related Owner
    [ForeignKey("OwnerId")]
    public Owner? Owner { get; set; }
}