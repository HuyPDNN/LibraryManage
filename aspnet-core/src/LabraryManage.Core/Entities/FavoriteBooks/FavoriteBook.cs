using Abp.Domain.Entities;
using LabraryManage.Authorization.Users;
using LabraryManage.Entities.BookLibraries;
using LabraryManage.Entities.Books;
using LabraryManage.Entities.Libraries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LabraryManage.Entities.FavoriteBooks
{
    [Table("Abp.FavoriteBooks")]
    public class FavoriteBook : Entity<Guid>
    {
        [ForeignKey("User")]
        public long UserId { get; set; }
        public virtual User User { get; set; }
        public Guid BookLibraryId { get; set; }
        public BookLibrary BookLibrary { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }
        public Guid LibraryId { get; set; }
        public Library Library { get; set; }
    }
}
