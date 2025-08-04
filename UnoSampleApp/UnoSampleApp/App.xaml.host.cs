using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Uno.Extensions;
using Uno.Extensions.Hosting;
using Uno.Extensions.Navigation;

namespace UnoSampleApp;

public partial class App : Application
{
    private static void ConfigureHost(IHostBuilder builder)
    {
        builder
            .ConfigureServices((context, services) =>
            {
                // Add navigation
                services.AddNavigation();
                
                // Register regions
                services.AddRegionNavigation();
                
                // Add services
                services.AddServices(context.Configuration);
            })
            .UseNavigation(NavigateAsync);
    }

    private static void NavigateAsync(INavigationBuilder builder)
    {
        // Register shell
        builder
            .View<Shell>()
            .View<Pages.Main.MainPage>()
            .NavigateByViewModel<Pages.Main.ViewModels.MainViewModel, Pages.Main.MainPage>();
        
        // Register regions
        builder
            .Region<Pages.Main.MainPage>("MainHeader", b => b
                .View<Pages.Main.Regions.Header.MainHeaderRegion>())
            .Region<Pages.Main.MainPage>("MainContent", b => b
                .View<Pages.Main.Regions.Content.MainContentRegion>());
    }
}

public static class ServiceExtensions
{
    public static IServiceCollection AddServices(
        this IServiceCollection services, 
        Microsoft.Extensions.Configuration.IConfiguration configuration)
    {
        // Add view models
        services.AddTransient<Pages.Main.ViewModels.MainViewModel>();
        services.AddTransient<Pages.Main.ViewModels.MainHeaderViewModel>();
        services.AddTransient<Pages.Main.ViewModels.MainContentViewModel>();
        
        // Add services here
        
        return services;
    }
}