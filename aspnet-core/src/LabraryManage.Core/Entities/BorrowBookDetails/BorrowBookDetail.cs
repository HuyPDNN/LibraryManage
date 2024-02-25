using Abp.Domain.Entities;
using LabraryManage.Entities.Books;
using LabraryManage.Entities.BorrowBooks;
using LabraryManage.Entities.Libraries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LabraryManage.Entities.BorrowBookDetails
{
    [Table("Abp.BorrowBookDetails")]
    public class BorrowBookDetail: Entity<Guid>
    {
        public Guid BorrowBookId { get; set; }
        public BorrowBook BorrowBook { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }

        [ForeignKey("Library")]
        public Guid LibraryId { get; set; }
        public Library Library { get; set; }
        public int Qty { get; set; }
        public int PriceBorrow { get; set; }
        public int Total { get; set; }
    }
}
