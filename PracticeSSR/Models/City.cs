namespace PracticeSSR.Models;

public class City(string name = "Nulltown", string country = "Republic of Null", string? image = null)
{

    public required string Name { get; set; } = name;
    public required string Country { get; set; } = country;
    public string? Image { get; set; } = image;
}
