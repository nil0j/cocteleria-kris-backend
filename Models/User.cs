using System.ComponentModel.DataAnnotations;

namespace cocteleria_kris_backend.Models;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    public string PasswordHash { get; set; } // We'll store the hashed password
}
