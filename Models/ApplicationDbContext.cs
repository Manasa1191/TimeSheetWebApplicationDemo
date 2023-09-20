using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using WebApplication6.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // DbSet properties for your database tables
    public DbSet<Timezone> Timezones { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<L1task> L1tasks { get; set; }
    public DbSet<L2task> L2tasks { get; set; }
    public DbSet<Timesheet> Timesheets { get; set; }
}
