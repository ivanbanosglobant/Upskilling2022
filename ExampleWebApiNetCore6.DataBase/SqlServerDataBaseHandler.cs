using ExampleWebApiNetCore6.DataBase.DbInterface;
using ExampleWebApiNetCore6.Domain.Exceptions;
using ExampleWebApiNetCore6.Domain.Models;
using ExampleWebApiNetCore6.Models;
using Microsoft.Extensions.Options;
using System.Data;
using System.Data.SqlClient;

namespace ExampleWebApiNetCore6.DataBase
{
    public class SqlServerDataBaseHandler : IDataBaseHandler
    {
        private readonly IOptions<Database> _databaseOptions;

        public SqlServerDataBaseHandler(IOptions<Database> databaseOptions)
        {
            _databaseOptions = databaseOptions;
        }

        public async Task<Car> GetCarByPlate(string plate)
        {
            var car = new Car();
            using(var connection = new SqlConnection(_databaseOptions.Value.Constring))
            using (var command = new SqlCommand("GetCarByPlate", connection) { CommandType = System.Data.CommandType.StoredProcedure })
            {
                command.Parameters.Add("@Plate", SqlDbType.VarChar).Value = plate;
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    car.Plate = reader["Plate"].ToString();
                    car.Driver = reader["Driver"].ToString();
                }
                if(car.Plate == null)
                {
                    throw new ParkingException($"Car with plate {plate} not found", System.Net.HttpStatusCode.NotFound);
                } 
                
            }
            return car;
        }

        public async Task SaveUser(User user)
        {
            using (var connection = new SqlConnection(_databaseOptions.Value.Constring))
            using (var command = new SqlCommand("SaveUser", connection) { CommandType = System.Data.CommandType.StoredProcedure })
            {
                command.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = user.UserId;
                command.Parameters.Add("@Username", SqlDbType.VarChar).Value = user.Username;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = user.Password;
                command.Parameters.Add("@Name", SqlDbType.VarChar).Value = user.Name;
                command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = user.LastName;
                connection.Open();
                await command.ExecuteNonQueryAsync();

            }
        }
    }
}
