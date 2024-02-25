using Abp.AutoMapper;
using LabraryManage.Entities.Authors;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabraryManage.AppService.Authors.Dto
{
    [AutoMapFrom(typeof(Author))]
    public class DeleteAuthorDto
    {
        public Guid Id { get; set; } 
    }
}
