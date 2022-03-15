﻿using System;
using System.Collections.Generic;

namespace MyCar.Infrastructure.Response
{
    public class PaginatedList<T> where T : class
    {
        public List<T> Items { get; }

        public int PageIndex { get; }

        public int TotalPages { get; }

        public int TotalCount { get; }

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            TotalCount = count;
            Items = items;
        }
    }
}