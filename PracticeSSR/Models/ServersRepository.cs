namespace PracticeSSR.Models;

public static class ServersRepository
{
    private static List<Server> servers =
    [
        new() { ServerId = 1, Name = "Server1", City = "Amsterdam" },
        new() { ServerId = 2, Name = "Server2", City = "Amsterdam" },
        new() { ServerId = 3, Name = "Server3", City = "Amsterdam" },
        new() { ServerId = 4, Name = "Server4", City = "Amsterdam" },
        new() { ServerId = 5, Name = "Server5", City = "Eindhoven" },
        new() { ServerId = 6, Name = "Server6", City = "Eindhoven" },
        new() { ServerId = 7, Name = "Server7", City = "Eindhoven" },
        new() { ServerId = 8, Name = "Server8", City = "Paris" },
        new() { ServerId = 9, Name = "Server9", City = "Paris" },
        new() { ServerId = 10, Name = "Server10", City = "Rome" },
        new() { ServerId = 11, Name = "Server11", City = "Rome" },
        new() { ServerId = 12, Name = "Server12", City = "San Francisco" },
        new() { ServerId = 13, Name = "Server13", City = "San Francisco" }
    ];

    public static void AddServer(Server server)
    {
        int maxId = servers.Max(s => s.ServerId);
        server.ServerId = maxId + 1;
        servers.Add(server);
    }

    public static List<Server> GetServers() => servers;

    public static List<Server> GetServersByCity(string cityName)
    {
        return servers.Where(s => s.City!.Equals(cityName, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public static Server? GetServerById(int id)
    {
        Server? server = servers.Find(s => s.ServerId == id);
        if (server is not null)
        {
            return new()
            {
                ServerId = server.ServerId,
                Name = server.Name,
                City = server.City,
                IsOnline = server.IsOnline
            };
        }

        return null;
    }

    public static void UpdateServer(int serverId, Server server)
    {
        if (serverId != server.ServerId)
            return;

        Server? serverToUpdate = servers.Find(s => s.ServerId == serverId);
        if (serverToUpdate is not null)
        {
            if (server.Name != serverToUpdate.Name && servers.Exists(s => s.Name == serverToUpdate.Name))
            {
                Console.WriteLine($"A server with name {server.Name} already exists. Aborting update.");
                return;
            }

            serverToUpdate.Name = server.Name;
            serverToUpdate.City = server.City;
            serverToUpdate.IsOnline = server.IsOnline;
        }
    }

    public static void DeleteServer(int serverId)
    {
        Server? server = servers.Find(s => s.ServerId == serverId);
        if (server is not null)
        {
            servers.Remove(server);
        }
    }

    public static List<Server> SearchServers(string serverFilter) =>
        servers.Where(s => s.Name!.Contains(serverFilter, StringComparison.OrdinalIgnoreCase)).ToList();

}