using Abp.Domain.Entities;
using LabraryManage.Entities.Districts;
using LabraryManage.Entities.Libraries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LabraryManage.Entities.Provinces
{
    [Table("Abp.Provinces")]
    public class Province : Entity<Guid>
    {
        public string Name { get; set; }
        public virtual ICollection<District> District { get; set; }
        public virtual ICollection<Library> Library { get; set; }
    }
}
