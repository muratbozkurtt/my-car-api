using CoinMarker.Infrastructure.Constans;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinMarker.Infrastructure.Response
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; }

        public DataResult(T data, bool isSuccess, string messageCode, IEnumerable<string> messages) : base(isSuccess, messageCode, messages)
        {
            Data = data;
        }

        public DataResult(T data, bool isSuccess, IEnumerable<string> messages) : base(isSuccess, MessageCodes.General.GeneralCode, messages)
        {
            Data = data;
        }

        public DataResult(T data, bool isSuccess, string messageCode) : base(isSuccess, messageCode)
        {
            Data = data;
        }

        public DataResult(T data, bool isSuccess) : base(isSuccess, MessageCodes.General.GeneralCode)
        {
            Data = data;
        }
    }
}
