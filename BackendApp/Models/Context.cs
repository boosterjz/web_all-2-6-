using Microsoft.EntityFrameworkCore;

namespace BackendApp.Models;

public class Context : DbContext
{
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<User> Users { get; set; }

    public Context(DbContextOptions options) : base(options)
    {
        Database.EnsureCreated();
    }
}