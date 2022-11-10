using ExampleWebApiNetCore6.Models;
using MediatR;

namespace ExampleWebApiNetCore6.Application.Queries
{
    public class GetCarByPlateQuery : IRequest<Car>
    {
        public GetCarByPlateQuery(string plate)
        {
            Plate = plate;
        }

        public string Plate { get; }
    }
}
