using domain;
using domain.SpeakerAggregate;
using domain.SessionAggregate;
using domain.AttendeeAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace repository
{
    //Used from https://github.com/ahuimanu/CIDM4390/blob/5057d50a6fedc26fb249a1f87c2da9c3ff7edf97/Testing/repository/DependencyInjection.cs
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<ISpeakerRepository, SpeakerRepository>();
            services.AddTransient<ISessionRepository, SessionRepository>();
            services.AddTransient<IAttendeeRepository, AttendeeRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            //services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase(databaseName: "Weather"));            
            

            return services;
        }
    }
}