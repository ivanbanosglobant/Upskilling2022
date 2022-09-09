using ExampleWebApiNetCore6.DataBase.DbInterface;
using ExampleWebApiNetCore6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWebApiNetCore6.DataBase
{
    public class SqlServerDataBaseHandler : IDataBaseHandler
    {
        public async Task<Car> GetCarByPlate(string plate)
        {
            return new Car() { Plate = "KJZ881", User = "Ivan Baños" };
        }
    }
}
