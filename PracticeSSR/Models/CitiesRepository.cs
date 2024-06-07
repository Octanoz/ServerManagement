namespace PracticeSSR.Models;

public static class CitiesRepository
{
    private static readonly List<City> cities =
    [
        new("Amsterdam", "Netherlands", @"\images\a-dam-canal-houses.svg"),
        new("Eindhoven", "Netherlands", @"\images\Evoluon.svg"),
        new("Paris", "France", @"\images\eiffel-tower.svg"),
        new("Rome", "Italy", @"\images\colosseum.svg"),
        new("San Francisco", "USA", @"\images\golden-gate.svg"),
    ];

    public static List<City> GetCities() => cities;
}
