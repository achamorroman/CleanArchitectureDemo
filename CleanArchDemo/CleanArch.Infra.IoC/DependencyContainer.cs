
using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    // CrossCutting project
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infra.Data
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
