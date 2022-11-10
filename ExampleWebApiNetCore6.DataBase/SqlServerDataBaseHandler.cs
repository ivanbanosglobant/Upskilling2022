using ExampleWebApiNetCore6.DataBase.DbInterface;
using ExampleWebApiNetCore6.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    
                
            }
            return car;
        }
    }
}
