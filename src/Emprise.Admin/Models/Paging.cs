﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emprise.Admin.Models
{
    public class Paging<T> : List<T>
    {
        public int PageIndex { get; set; }

        public new int Count { get; set; }

        public int PageCount { get; set; }

        public IEnumerable<T> Data { get; set; }


        //是否有上一页
        public bool HasPreviousPage
        {
            get { return PageIndex > 1; }
        }

        //是否有下一页
        public bool HasNextPage
        {
            get { return PageIndex < this.PageCount; }
        }

    }
}
