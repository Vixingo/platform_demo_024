namespace PlatformDemo.ClassLibrary;


using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{    optionsBuilder.UseSqlite(@"data source=Contact.db");
}
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<ServicePlan> ServicePlans { get; set; }
    public DbSet<Timesheet> Timesheets { get; set; }
}

