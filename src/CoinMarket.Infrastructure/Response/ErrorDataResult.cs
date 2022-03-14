using CoinMarker.Infrastructure.Constans;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinMarker.Infrastructure.Response
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string messageCode, IEnumerable<string> message) : base(data, false, messageCode, message)
        {

        }

        public ErrorDataResult(T data, IEnumerable<string> message) : base(data, false, MessageCodes.Error.ErrorCode, message)
        {

        }

        public ErrorDataResult(T data) : base(data, false, MessageCodes.Error.ErrorCode)
        {

        }

        public ErrorDataResult(T data, string messageCode) : base(data, false, messageCode)
        {

        }

        public ErrorDataResult(IEnumerable<string> message) : base(default, false, MessageCodes.Error.ErrorCode, message)
        {

        }

        public ErrorDataResult(string messageCode, IEnumerable<string> message) : base(default, false, messageCode, message)
        {

        }

        public ErrorDataResult() : base(default, false, MessageCodes.Error.ErrorCode)
        {

        }
    }
}
