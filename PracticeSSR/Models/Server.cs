using System.ComponentModel.DataAnnotations;

namespace PracticeSSR.Models;

public class Server
{
    public Server()
    {
        Random random = new();
        int randomNumber = random.Next(0, 2);
        IsOnline = randomNumber != 0;
    }

    public int ServerId { get; set; }
    public bool IsOnline { get; set; }
    [Required]
    [StringLength(20, MinimumLength = 4, ErrorMessage = "Name must be between 4 and 20 characters long")]
    [RegularExpression(@"\w+\d{1,2}", ErrorMessage = "Server names have to end with 1 or 2 digits.")]
    public string? Name { get; set; }
    [Required]
    [StringLength(30, MinimumLength = 3, ErrorMessage = "City name needs to be between 3 and 30 characters long.")]
    public string? City { get; set; }
}