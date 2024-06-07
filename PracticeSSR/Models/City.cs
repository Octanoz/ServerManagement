namespace PracticeSSR.Models;

public class City
{
    public string Name { get; set; }
    public string Country { get; set; }
    public string? Image { get; set; }

    public City(string name, string country, string? image)
    {
        Name = name;
        Country = country;
        Image = image;
    }
}
