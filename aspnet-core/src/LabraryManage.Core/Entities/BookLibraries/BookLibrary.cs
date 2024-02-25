using Abp.Domain.Entities;
using LabraryManage.Entities.Books;
using LabraryManage.Entities.Libraries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LabraryManage.Entities.BookLibraries
{
    [Table("Abp.BookLibraries")]
    public class BookLibrary: Entity<Guid>
    {
        public Guid BookId { get; set; }
        public Book Book { get; set; }
        public Guid LibraryId { get; set; }
        public Library Library { get; set; }
        public int Stock { get; set; }
    }
}
