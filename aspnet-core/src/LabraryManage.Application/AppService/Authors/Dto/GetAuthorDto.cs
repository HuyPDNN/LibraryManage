using Abp.AutoMapper;
using LabraryManage.Entities.Authors;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabraryManage.AppService.Authors.Dto
{
    [AutoMapFrom(typeof(Author))]
    public class GetAuthorDto
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int YearOfBirth { get; set; }
        public string Address { get; set; }
    }
}
