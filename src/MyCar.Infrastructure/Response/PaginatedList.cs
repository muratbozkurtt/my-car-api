using System;
using System.Collections.Generic;

namespace MyCar.Infrastructure.Response
{
    public class PaginatedList<T> where T : class
    {
        public List<T> Items { get; }

        public int Page { get; }

        public int Total { get; }

        public PaginatedList(List<T> items, int count, int pageIndex)
        {
            Page = pageIndex;
            Total = count;
            Items = items;
        }
    }
}
