using Abp.Domain.Entities;
using LabraryManage.Entities.BookLibraries;
using LabraryManage.Entities.Categories;
using LabraryManage.Entities.Publishers;
using LabraryManage.Entities.Authors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LabraryManage.Entities.Books
{
    [Table("Abp.Books")]    
    public class Book : Entity<Guid>
    {
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public int PriceBorrow { get; set; }
        public Guid PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
        public int YearPublic { get; set; }
        public IList<BookLibrary> BookLibrary { get; set; }
    }
}
