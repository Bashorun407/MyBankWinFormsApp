using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyBankApp.Repository.Data;
using MyBankWinFormsApp.Extension;

namespace MyBankWinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static IConfiguration Configuration;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            ServiceCollection services = new ServiceCollection();

            //Add Servcies here
            services.AddTransient<Form1>();
            services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("Default")));
            services.ConfigureUnitOfWork();
            services.ConfigureServiceManger();

            using ServiceProvider servicesProvider = services.BuildServiceProvider();

            var form1 = servicesProvider.GetRequiredService<Form1>();
            Application.Run(form1);
        }
    }
}