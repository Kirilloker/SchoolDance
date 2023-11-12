using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

class DB_Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        string connect = "server=192.168.0.35;database=SchoolDance;user=kirillok;password=loki5566";


        optionsBuilder.UseMySQL(connect);
    }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Coach>()
            .Property(e => e.danceStylesId)
            .HasConversion(new IntListToStringConverter());

        modelBuilder
            .Entity<Group>()
            .Property(e => e.studentId)
            .HasConversion(new IntListToStringConverter());
    }


    public DB_Context()
    {
        Database.EnsureCreated();
    }

    public DbSet<Administrator> administrators { get; set; }
    public DbSet<Coach> coaches { get; set; }
    public DbSet<Class> classes { get; set; }
    public DbSet<DanceHall> danceHalls { get; set; }
    public DbSet<DanceStyle> danceStyles { get; set; }
    public DbSet<Group> groups { get; set; }
    public DbSet<Payment> payments { get; set; }
    public DbSet<Student> students { get; set; }
    public DbSet<SupportMessage> supportMessages { get; set; }
}




public class IntListToStringConverter : ValueConverter<List<int>, string>
{
    public IntListToStringConverter(ConverterMappingHints mappingHints = null)
        : base(
              list => ConvertListToString(list),
              str => ConvertStringToList(str),
              mappingHints)
    {
    }

    private static string ConvertListToString(List<int> list)
    {
        return string.Join(",", list);
    }

    private static List<int> ConvertStringToList(string str)
    {
        return str.Split(',').Select(int.Parse).ToList();
    }
}

