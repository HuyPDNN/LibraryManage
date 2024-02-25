using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LabraryManage.Entities.PageResults
{
    public class PageResult<T>
    {
        public int Count { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public List<T> Items { get; set; }
    }
}
