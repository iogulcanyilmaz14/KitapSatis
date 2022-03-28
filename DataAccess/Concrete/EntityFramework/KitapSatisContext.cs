
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class KitapSatisContext : DbContext
    {
 

        public DbSet<Book> Books { get; set; }
        public DbSet<BookOrder> BookOrders { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<UserAuthority> UserAuthorities { get; set; }
        public DbSet<Authority> Authorities { get; set; }


    }
}
