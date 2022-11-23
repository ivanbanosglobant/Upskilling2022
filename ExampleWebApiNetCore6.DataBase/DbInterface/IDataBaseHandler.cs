using ExampleWebApiNetCore6.Domain.Models;
using ExampleWebApiNetCore6.Models;

namespace ExampleWebApiNetCore6.DataBase.DbInterface
{
    public interface IDataBaseHandler
    {
        Task<Car> GetCarByPlate(string plate);
        Task SaveUser(User user);
    }
}
