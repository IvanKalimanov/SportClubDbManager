using Microsoft.Extensions.DependencyInjection;
using SportClubDbManager.Core.DTO;
using SportClubDbManager.Core.Mappers;
using SportClubDbManager.Core.Services;
using SportClubDbManager.Core.Services.Interfaces;
using SportClubDbManager.Data;
using SportClubDbManager.Dependencies;
using SportClubDbManager.Infrastructure;
using SportClubDbManager.Infrastructure.Repositories;
using SportClubDbManager.SharedKernel.Interfaces;
using System.Windows;

namespace SportClubDbManager.Presenter
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }
        private void ConfigureServices(ServiceCollection services)
        {
            services
                .AddDbConnections()
                .RegisterMappers()
                .RegisterRepositories()
                .RegisterServices()
                .AddSingleton<MainWindow>();
        }
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
