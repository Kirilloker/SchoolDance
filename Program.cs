using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using MySql.EntityFrameworkCore.Extensions;

public class MysqlEntityFrameworkDesignTimeServices : IDesignTimeServices
{
    public void ConfigureDesignTimeServices(IServiceCollection serviceCollection)
    {
        serviceCollection.AddEntityFrameworkMySQL();
        new EntityFrameworkRelationalDesignServicesBuilder(serviceCollection)
            .TryAddCoreServices();
    }
}


namespace SchoolDance
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            using (var context = new DBContext())
            {
                // Создание базы данных (если она еще не существует)
                context.Database.EnsureCreated();

                // Добавление нового стиля танца
                var danceStyle = new DanceStyle { name = "Ballet", description = "Des" };
                context.danceStyles.Add(danceStyle);
                context.SaveChanges();

                // Получение всех стилей танцев
                var danceStyles = context.danceStyles.ToList();
                foreach (var style in danceStyles)
                {
                    Console.WriteLine(style.name);
                }
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

   

    }


    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
            => services.AddDbContext<DBContext>();

    }


}