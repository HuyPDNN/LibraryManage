using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LabraryManage.Authorization.Roles;
using LabraryManage.Authorization.Users;
using LabraryManage.MultiTenancy;
using LabraryManage.Entities.Authors;
using LabraryManage.Entities.Categories;
using LabraryManage.Entities.Provinces;
using LabraryManage.Entities.Districts;
using LabraryManage.Entities.Books;
using LabraryManage.Entities.Libraries;
using LabraryManage.Entities.BookLibraries;
using LabraryManage.Entities.BorrowBooks;
using LabraryManage.Entities.BorrowBookDetails;
using LabraryManage.Entities.FavoriteBooks;
using LabraryManage.Entities.Publishers;

namespace LabraryManage.EntityFrameworkCore
{
    public class LabraryManageDbContext : AbpZeroDbContext<Tenant, Role, User, LabraryManageDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<BookLibrary> BookLibraries { get; set; }
        public DbSet<BorrowBook> BorrowBooks { get; set; }
        public DbSet<BorrowBookDetail> BorrowBookDetails { get; set; }
        public DbSet<FavoriteBook> FavoriteBooks { get; set; }
        public LabraryManageDbContext(DbContextOptions<LabraryManageDbContext> options)
            : base(options)
        {
        }
    }
}
