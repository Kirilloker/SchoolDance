using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using MySql.EntityFrameworkCore.Extensions;
using SchoolDance.Forms;
using System;

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
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new AdminPanelPayment());
        }
    }

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
            => services.AddDbContext<DB_Context>();  
    }


}