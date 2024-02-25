using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LabraryManage.Entities.Paging
{
    public class PagingRequestDto
    {
        [DefaultValue(1)]
        public int PageIndex { get; set; }
        [DefaultValue(9)]
        public int PageSize { get; set; }
    }
}
