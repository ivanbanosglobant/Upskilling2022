using System.Diagnostics;
using System.Net;
using System.Runtime.Serialization;

namespace ExampleWebApiNetCore6.Domain.Exceptions
{
    [Serializable]
    public class ParkingException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }

        public ParkingException()
        {
        }

        public ParkingException(string? message, HttpStatusCode statusCode) : base(message)
        {
            StatusCode = statusCode;
        }

        public ParkingException(string? message) : base(message)
        {
        }

        public ParkingException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ParkingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}