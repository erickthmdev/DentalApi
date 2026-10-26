using DentalApi.Repositories.Implementations;
using DentalApi.Repositories.Interfaces;

namespace DentalApi.Extensions;

public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IPatientRepository, PatientRepository>();
        services.AddScoped<IAppointmentRepository, AppointmentRepository>();
        services.AddScoped<IProcedureRepository, ProcedureRepository>();
        services.AddScoped<IFinancialRepository, FinancialRepository>();
        services.AddScoped<IToothSurfaceRepository, ToothSurfaceRepository>();

        return services;
    }
}