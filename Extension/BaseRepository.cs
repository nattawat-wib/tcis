using Npgsql;
using System.Data;

namespace tcirs_service.Extension
{
    public abstract class BaseRepository(IConfiguration configuration)
    {
        protected readonly string _connectionString = configuration.GetConnectionString("DefaultConnection");

        protected NpgsqlConnection CreateConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}
