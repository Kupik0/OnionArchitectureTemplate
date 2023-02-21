using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Application.Interfaces.Repositories;
using ProductApp.Persistence.Context;
using ProductApp.Persistence.Repositories;
using ProductApp.Application.Interfaces.Repositories;
using ProductApp.Persistence.Context;
using ProductApp.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceRegistration(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("memoryDb"));

            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}