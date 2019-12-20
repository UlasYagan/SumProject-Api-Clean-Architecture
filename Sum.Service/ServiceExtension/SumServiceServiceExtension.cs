﻿using Microsoft.Extensions.DependencyInjection;
using Sum.Domain.Entity;
using Sum.Service.Base;
using Sum.Service.Features;
using Sum.Service.Interface;
using Sum.Service.Service;

namespace Sum.Service.ServiceExtension
{
   public static class SumServiceServiceExtension
    {
        public static void AddInjectionForSumServices(this IServiceCollection services)
        {
            services.AddTransient<IFileService, FileService>();
            services.AddTransient<IAuthService, AuthService>();

            services.AddTransient<IBaseCrudService<Products, int>, ProductService>();
            services.AddTransient<IProductService, ProductService>();



        }
    }
}
