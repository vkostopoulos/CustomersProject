using BOL;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class CrmDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Data Source=DESKTOP-5MTTOS6\SQLEXPRESS;" +
                                                 "Initial Catalog=crm;" +
                                                 "persist security info = True;Integrated Security = SSPI;");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
