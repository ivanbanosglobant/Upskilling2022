using ExampleWebApiNetCore6.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWebApiNetCore6.Application.Command
{
    public  class SaveUserCommand : IRequest
    {
        public User User { get; }

        public SaveUserCommand(User user)
        {
            User = user;
        }
    }
}
