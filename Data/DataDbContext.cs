using Microsoft.EntityFrameworkCore;

namespace MB.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
        }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Type_of_apartment> Type_Of_Apartments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<General_partner> General_Partners { get; set; }
        public DbSet<Partner_type> Partner_Types { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Object> Objects { get; set; }
        public DbSet<Object_type> Object_Types { get; set; }
        public DbSet<Resident> Residents { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Paid_services> Paid_Services { get; set; }
    }
}
