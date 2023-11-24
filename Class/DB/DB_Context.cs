using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Data;

class DB_Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connect = "server=127.0.0.1;database=SchoolDance;user=kirillok;password=loki5566";
        optionsBuilder.UseMySQL(connect);
    }

    public DB_Context()
    {
        Database.EnsureCreated();
    }

    public DbSet<Administrator> administrators { get; set; }
    public DbSet<Coach> coaches { get; set; }
    public DbSet<Lesson> lessons { get; set; }
    public DbSet<DanceHall> danceHalls { get; set; }
    public DbSet<DanceStyle> danceStyles { get; set; }
    public DbSet<TopUp> topUp { get; set; }
    public DbSet<Payment> payment { get; set; }
    public DbSet<Student> students { get; set; }
    public DbSet<SupportMessage> supportMessages { get; set; }
    public DbSet<EventDance> eventDances { get; set; }
}