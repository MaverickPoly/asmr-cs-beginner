using System.Text.Json;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
}

internal class Program
{
    private static string filename = "users.json";
    public static async Task Main(string[] args)
    {
        List<User> users = new List<User>
        {
            new User {Id=1, Username = "Alex", Email = "alex@gmail.com", Age = 21},
            new User {Id=2, Username = "John", Email = "john@gmail.com", Age = 32},
            new User {Id=3, Username = "Mamun", Email = "mamumac@gmail.com", Age = 40},
        };
        
        // Writing data
        await WriteJson(users);
        
        // Read data
        var newUsers = await ReadJson();

        foreach (var user in newUsers)
        {
            Console.WriteLine($"Id: {user.Id}, username: {user.Username}, email: {user.Email}, Age: {user.Age}");
        }
    }

    // Write Data to JSON
    private static async Task WriteJson(List<User> users)
    {
        string json = JsonSerializer.Serialize(users, new JsonSerializerOptions {WriteIndented = true});
        await File.WriteAllTextAsync(filename, json);
    }
    
    // Read data from JSON
    private static async Task<List<User>> ReadJson()
    {
        string json = await File.ReadAllTextAsync(filename);
        Console.WriteLine("JSON Content: " + json);
        return JsonSerializer.Deserialize<List<User>>(json);
    }
}