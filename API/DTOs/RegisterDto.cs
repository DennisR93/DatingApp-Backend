using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class RegisterDto
{
 [Required]
 [MinLength(3)]
 [MaxLength(8)]
 public  string Username { get; set; }
 
 [Required]
 [MinLength(4)]
 [MaxLength(10)]
 public string Password { get; set; }
}