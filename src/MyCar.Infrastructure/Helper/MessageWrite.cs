using System.Collections.Generic;
using System.Linq;

namespace MyCar.Infrastructure.Helper
{
    public static class MessageWrite
    {
        public static IEnumerable<string> Write(params string[] messages)
        {
            return messages.ToArray();
        }
    }
}
