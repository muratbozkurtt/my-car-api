using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinMarker.Infrastructure.Response
{
    public class Result : IResult
    {
        public bool IsSuccess { get; set; }

        public string MessageCode { get; set; }

        public string[] Messages { get; set; }

        public Result(bool isSuccess, string messageCode, IEnumerable<string> messages) : this(isSuccess, messageCode)
        {
            IsSuccess = isSuccess;
            MessageCode = messageCode;
            Messages = messages?.ToArray();
        }

        public Result(bool isSuccess, string messageCode)
        {
            IsSuccess = isSuccess;
            MessageCode = messageCode;
        }
    }
}
