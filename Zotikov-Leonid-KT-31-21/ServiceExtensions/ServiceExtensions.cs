﻿using Zotikov_Leonid_KT_31_21.Interfaces.StudentsInterfaces;

namespace Zotikov_Leonid_KT_31_21.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();

            return services;
        }
    }
}
