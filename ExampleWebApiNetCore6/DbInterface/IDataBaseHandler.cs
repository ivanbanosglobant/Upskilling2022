using ExampleWebApiNetCore6.Models;

namespace ExampleWebApiNetCore6.DbInterface
{
    public interface IDataBaseHandler
    {
        Task<Car> GetCarBayPlate(string plate);
    }
}
