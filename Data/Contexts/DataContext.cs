using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<BookingEntity> Bookings { get; set; }
    public DbSet<BookerEntity> Bookers { get; set; }
    public DbSet<BookerAdressEntity> BookerAdresses { get; set; }
}
