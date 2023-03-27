using Azure;
using Azure.Data.Tables;

namespace WebApp.Data;

public class Player : ITableEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }        
    public string PhoneNumber { get; set; }
    public string PartitionKey { get; set; }
    public string RowKey { get; set; }
    public DateTimeOffset? Timestamp { get; set; }
    public ETag ETag { get; set; }
}

public static class PlayerHelper
{
    static List<Player> DummyPlayers = new List<Player>(){
         new Player() { FirstName = "John", LastName = "Doe", Email = "john.doe@contoso.com" },
        new Player() { FirstName = "Jane", LastName = "Doe", Email = "jane.doe@contoso.com" },
        new Player() { FirstName = "John", LastName = "Smith", Email = "john.smith@contoso.com" },
        new Player() { FirstName = "Jane", LastName = "Smith", Email = "jane.smith@contoso.com" },
        new Player() { FirstName = "John", LastName = "Johnson", Email = "john.johnson@contoso.com" },
        new Player() { FirstName = "Jane", LastName = "Johnson", Email = "jane.johnson@contoso.com" },
        new Player() { FirstName = "John", LastName = "Williams", Email = "john.williams@contoso.com" },
        new Player() { FirstName = "Jane", LastName = "Williams", Email = "jane.williams@contoso.com" },
        new Player() { FirstName = "John", LastName = "Brown", Email = "john.brown@contoso.com" },
        new Player() { FirstName = "Jane", LastName = "Brown", Email = "jane.brown@contoso.com" },
        new Player() { FirstName = "John", LastName = "Jones", Email = "john.jones@contoso.com" },
        new Player() { FirstName = "Jane", LastName = "Jones", Email = "jane.jones@contoso.com" },
        new Player() { FirstName = "John", LastName = "Garcia", Email = "john.garcia@contoso.com" },
        new Player() { FirstName = "Jane", LastName = "Garcia", Email = "jane.garcia@contoso.com" },
        new Player() { FirstName = "John", LastName = "Miller", Email = "john.miller@contoso.com" },
        new Player() { FirstName = "Jane", LastName = "Miller", Email = "jane.miller@contoso.com" },
        new Player() { FirstName = "John", LastName = "Davis", Email = "john.davis@contoso.com" },
        new Player() { FirstName = "Jane", LastName = "Davis", Email = "jane.davis@contoso.com" },
        new Player() { FirstName = "John", LastName = "Rodriguez", Email ="john.rodriguez@contoso.com"},
        new Player() { FirstName ="Jane",LastName ="Rodriguez ",Email ="jane.rodriguez @contoso.com"},
        new Player() { FirstName ="John ",LastName ="Martinez ",Email ="john.martinez @contoso.com"},
        new Player() { FirstName ="Jane ",LastName ="Martinez ",Email ="jane.martinez @contoso.com"},
        new Player() { FirstName ="John ",LastName ="Hernandez ",Email ="john.hernandez @contoso.com"},
        new Player() { FirstName ="Jane ",LastName ="Hernandez ",Email ="jane.hernandez @contoso.com"},
        new Player() { FirstName ="John ",LastName ="Lopez ",Email ="john.lopez @contoso.com"},
        new Player() { FirstName ="Jane ",LastName ="Lopez ",Email ="jane.lopez @contoso.com"},
        new Player() { FirstName ="John ",LastName ="Gonzalez ",Email ="john.gonzalez @contoso.com"},
        new Player() { FirstName ="Jane ",LastName ="Gonzalez ",Email ="jane.gonzalez @contoso.com"},
        new Player() { FirstName ="John ",LastName ="Wilson ",Email ="john.wilson @contoso.com"},
        new Player() { FirstName ="Jane ",LastName ="Wilson ",Email ="jane.wilson @contoso.com"},
        new Player() { FirstName ="John ",LastName ="Anderson ",Email ="john.anderson @contoso.com"},
        new Player() { FirstName ="Jane ",LastName ="Anderson ",Email ="jane.anderson @contoso.com"},
        new Player() { FirstName="John ",LastName="Thomas ",Email="john.thomas @contoso.com"}
    };
    }
