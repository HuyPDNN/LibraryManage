using Abp.Domain.Entities;
using LabraryManage.Entities.Books;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LabraryManage.Entities.Categories
{
    [Table("Abp.Categories")]
    public class Category : Entity<Guid>        
    {
        public string Name { get; set; }
        public virtual ICollection<Book> Book { get; set; }
    }
}
