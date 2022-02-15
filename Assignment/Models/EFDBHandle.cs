using Microsoft.EntityFrameworkCore;

namespace Assignment.Models
{
    public class EFDBHandle : DbContext
    {
        public string conn = "Server=DESKTOP-NJ4I9LP;Database=assignmentdb;Trusted_Connection=True; ";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsB)
        {
            optionsB.UseSqlServer(conn);
        }
        public DbSet<Customer> Customers { get; set; }
       // public DbSet<AddressList> AddressLists { get; set; }
    }
}
