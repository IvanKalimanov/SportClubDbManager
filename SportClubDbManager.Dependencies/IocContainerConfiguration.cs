using Microsoft.Extensions.DependencyInjection;
using SportClubDbManager.Core.DTO;
using SportClubDbManager.Core.Mappers;
using SportClubDbManager.Core.Services;
using SportClubDbManager.Core.Services.Interfaces;
using SportClubDbManager.Data;
using SportClubDbManager.Infrastructure;
using SportClubDbManager.Infrastructure.Repositories;
using SportClubDbManager.SharedKernel.Interfaces;

namespace SportClubDbManager.Dependencies
{
    public static class IocContainerConfiguration
    {

        public static IServiceCollection AddDbConnections(this IServiceCollection services)
        {
            return services.AddDbContext<SportClubDBContext>();
        }

        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped<ISportRepository, SportRepository>()
                .AddTransient<ISportsmanRepository, SportsmanRepository>()
                .AddTransient<ITrainerRepository, TrainerRepository>()
                .AddTransient<IPreviousTrainerRepository, PreviousTrainerRepository>()
                .AddTransient<IOpponentSportRepository, OpponentSportRepository>()
                .AddTransient<IViewsRepository, ViewsRepository>();
        }

        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            return services
                .AddScoped<ISportService, SportService>()
                .AddTransient<ISportsmanService, SportsmanService>()
                .AddTransient<ITrainerService, TrainerService>()
                .AddTransient<IOpponentSportService, OpponentSportService>()
                .AddTransient<IPreviousTrainerService, PreviousTrainerService>()
                .AddTransient<IReportService, ReportService>();
        }

        public static IServiceCollection RegisterMappers(this IServiceCollection services)
        {
            return services
                .AddTransient<IMapper, ContainerMapper>()
                .AddTransient<IMapper<Sport, SportDto>, SportMapper>()
                .AddTransient<IMapper<SportDto, Sport>, SportMapper>()
                .AddTransient<IMapper<OpponentSport, OpponentSportDto>, OpponentSportMapper>()
                .AddTransient<IMapper<OpponentSportDto, OpponentSport>, OpponentSportMapper>()
                .AddTransient<IMapper<Sportsman, SportsmanDto>, SportsmanMapper>()
                .AddTransient<IMapper<SportsmanDto, Sportsman>, SportsmanMapper>()
                .AddTransient<IMapper<Trainer, TrainerDto>, TrainerMapper>()
                .AddTransient<IMapper<TrainerDto, Trainer>, TrainerMapper>()
                .AddTransient<IMapper<PreviousTrainer, PreviousTrainerDto>, PreviousTrainerMapper>()
                .AddTransient<IMapper<PreviousTrainerDto, PreviousTrainer>, PreviousTrainerMapper>();
        }
    }
}
