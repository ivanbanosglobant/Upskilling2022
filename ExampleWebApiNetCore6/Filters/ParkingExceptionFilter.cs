using ExampleWebApiNetCore6.Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace ExampleWebApiNetCore6.Filters
{
    public class ParkingExceptionFilter : IActionFilter, IOrderedFilter
    {
        public int Order { get; set; } = int.MaxValue - 10;

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if(context.Exception is ParkingException ex)
            {
                context.Result = new ObjectResult(ex.Message)
                {
                    StatusCode = (int)ex.StatusCode,
                };
                context.ExceptionHandled = true;
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
        }
    }
}
