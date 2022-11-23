using ExampleWebApiNetCore6.Application.Extensions;
using ExampleWebApiNetCore6.DataBase.DbInterface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWebApiNetCore6.Application.Command
{
    public class SaveUserCommandHandler : IRequestHandler<SaveUserCommand>
    {
        private readonly IDataBaseHandler _dataBaseHandler;

        public SaveUserCommandHandler(IDataBaseHandler dataBaseHandler)
        {
            _dataBaseHandler = dataBaseHandler;
        }

        public async Task<Unit> Handle(SaveUserCommand request, CancellationToken cancellationToken)
        {
            request.User.Password = request.User.Password.Hash();
            await _dataBaseHandler.SaveUser(request.User);
            return Unit.Value;
        }


    }
}
