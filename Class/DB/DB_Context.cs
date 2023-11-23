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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder
        //    .Entity<Group>()
        //    .Property(e => e.studentId)
        //    .HasConversion(new IntListToStringConverter());
    }

    //public DataTable ExecuteQuery(string sqlQuery)
    //{
    //    var result = this.Database.GetDbConnection().Query(sqlQuery);
    //    return ConvertToDataTable(result);
    //}

    //private DataTable ConvertToDataTable(dynamic result)
    //{
    //    DataTable dataTable = new DataTable();

    //    // Добавим колонки на основе первой строки результатов
    //    var firstRow = result.FirstOrDefault() as IDictionary<string, object>;
    //    if (firstRow != null)
    //    {
    //        foreach (var key in firstRow.Keys)
    //        {
    //            dataTable.Columns.Add(key, typeof(object)); // Используем typeof(object) для всех колонок
    //        }

    //        // Заполним таблицу
    //        foreach (var row in result)
    //        {
    //            var dataRow = dataTable.NewRow();
    //            var rowData = row as IDictionary<string, object>;
    //            if (rowData != null)
    //            {
    //                foreach (var key in rowData.Keys)
    //                {
    //                    if (dataTable.Columns.Contains(key))
    //                    {
    //                        dataRow[key] = rowData[key];
    //                    }
    //                }
    //                dataTable.Rows.Add(dataRow);
    //            }
    //        }
    //    }

    //    return dataTable;
    //}


    public DB_Context()
    {
        Database.EnsureCreated();
    }

    public DbSet<Administrator> administrators { get; set; }
    public DbSet<Coach> coaches { get; set; }
    public DbSet<Lesson> lessons { get; set; }
    public DbSet<DanceHall> danceHalls { get; set; }
    public DbSet<DanceStyle> danceStyles { get; set; }
    public DbSet<Group> groups { get; set; }
    public DbSet<TopUp> topUp { get; set; }
    public DbSet<Payment> payment { get; set; }
    public DbSet<Student> students { get; set; }
    public DbSet<SupportMessage> supportMessages { get; set; }
    public DbSet<EventDance> eventDances { get; set; }

    
}


public class IntListToStringConverter : ValueConverter<List<int>, string>
{
    public IntListToStringConverter(ConverterMappingHints mappingHints)
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

public class StrListToStringConverter : ValueConverter<List<string>, string>
{
    public StrListToStringConverter(ConverterMappingHints mappingHints)
        : base(
              list => ConvertListToString(list),
              str => ConvertStringToList(str),
              mappingHints)
    {
    }

    private static string ConvertListToString(List<string> list)
    {
        return string.Join(",", list);
    }

    private static List<string> ConvertStringToList(string str)
    {
        return str.Split(',').ToList();
    }
}