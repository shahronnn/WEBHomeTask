using System.Data;
using System.Reflection.Metadata.Ecma335;
using Npgsql;

namespace Infrastructure.Data;

public class DataContext
{
    string connectionString = "Server=localhost;Port=5432;Database=WEB;User Id=postgres;Password=1983;";
    public IDbConnection CreateConnection()=> new NpgsqlConnection(connectionString); 
}
