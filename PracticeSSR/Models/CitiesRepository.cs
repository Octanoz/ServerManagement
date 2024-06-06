namespace PracticeSSR.Models;

public static class CitiesRepository
{
    private static readonly List<City> cities =
    [
        new() { Name = "Amsterdam", Country = "Netherlands", Image = @"\images\a-dam-canal-houses.svg" },
        new() { Name = "Eindhoven", Country = "Netherlands", Image = @"\images\evoluon.svg" },
        new() { Name = "Paris", Country = "France", Image = @"\images\eiffel-tower.svg" },
        new() { Name = "Rome", Country = "Italy", Image = @"\images\colosseum.svg" },
        new() { Name = "San Francisco", Country = "USA", Image = @"\images\golden-gate.svg" },
    ];

    public static List<City> GetCities() => cities;
}
