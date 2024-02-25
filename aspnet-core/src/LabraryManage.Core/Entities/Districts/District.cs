using Abp.Domain.Entities;
using LabraryManage.Entities.Libraries;
using LabraryManage.Entities.Provinces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LabraryManage.Entities.Districts
{
    [Table("Abp.Districts")]
    public class District : Entity<Guid>
    {
        public string Name { get; set; }
        public Guid ProvinceId { get; set; }
        public Province Province { get; set; }
        public virtual ICollection<Library> Library { get; set; }
    }
}
