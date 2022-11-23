
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWebApiNetCore6.Application.Extensions
{
    public static class HashExtension
    {
        public static string Hash(this string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
