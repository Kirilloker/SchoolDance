using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using MySql.EntityFrameworkCore.Extensions;
using SchoolDance.Class.DB;
using SchoolDance.Class.Logic;
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
            Administrator obj = new Administrator
            {
                login = "admin",
                password = SignInUpLogic.EncodeStringToBase64("admin"),
                fullName = "Ivan Ivanov",
                gender = "Male",
                date = new DateTime(),
                typePerson = TypePerson.Administrator,
                position = "cool admin",
                phoneNumber = "89101388342",
                workExperienceMonth = 12
            };
            DB_API.AddAdministrator(obj);

            ApplicationConfiguration.Initialize();
            Application.Run(new Autorization());
        }
    }

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
            => services.AddDbContext<DB_Context>();  
    }
}