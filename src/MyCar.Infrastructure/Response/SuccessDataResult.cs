using MyCar.Infrastructure.Constans;
using System.Collections.Generic;

namespace MyCar.Infrastructure.Response
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string messageCode, IEnumerable<string> message) : base(data, true, messageCode, message)
        {

        }

        public SuccessDataResult(T data, IEnumerable<string> message) : base(data, true, MessageCodes.Success.SuccessCode, message)
        {

        }

        public SuccessDataResult(T data) : base(data, true, MessageCodes.Success.SuccessCode)
        {

        }

        public SuccessDataResult(T data, string messageCode) : base(data, true, messageCode)
        {

        }

        public SuccessDataResult(IEnumerable<string> message) : base(default, true, MessageCodes.Success.SuccessCode, message)
        {

        }

        public SuccessDataResult(string messageCode, IEnumerable<string> message) : base(default, true, messageCode, message)
        {

        }

        public SuccessDataResult() : base(default, true, MessageCodes.Success.SuccessCode)
        {

        }

    }
}
