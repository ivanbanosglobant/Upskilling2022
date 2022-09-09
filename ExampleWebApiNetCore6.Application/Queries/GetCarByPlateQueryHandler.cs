using ExampleWebApiNetCore6.DataBase.DbInterface;
using ExampleWebApiNetCore6.Models;
using MediatR;

namespace ExampleWebApiNetCore6.Application.Queries
{
    public class GetCarByPlateQueryHandler : IRequestHandler<GetCarByPlateQuery, Car>
    {
        private readonly IDataBaseHandler _dataBaseHandler;

        public GetCarByPlateQueryHandler(IDataBaseHandler dataBaseHandler)
        {
            _dataBaseHandler = dataBaseHandler;
        }

        public async Task<Car> Handle(GetCarByPlateQuery request, CancellationToken cancellationToken)
        {
            return await _dataBaseHandler.GetCarByPlate(request.Plate);
        }
    }
}
