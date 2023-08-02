using Microsoft.Extensions.DependencyInjection;
using MyBankApp.Core.ServiceManager.Abstractions;
using MyBankApp.Core.ServiceManager.Implementations;
using MyBankApp.Repository.UnitOfWork.Abstractions;
using MyBankApp.Repository.UnitOfWork.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankWinFormsApp.Extension
{
    public static class ServiceExtension
    {
        public static void ConfigureUnitOfWork(this IServiceCollection services) => 
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        public static void ConfigureServiceManger(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();
    }
}
