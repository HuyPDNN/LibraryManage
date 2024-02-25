using Abp.AutoMapper;
using LabraryManage.Entities.Publishers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabraryManage.AppService.Publishers.Dto
{
    [AutoMapFrom(typeof(Publisher))]
    public class AddPublisherDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
