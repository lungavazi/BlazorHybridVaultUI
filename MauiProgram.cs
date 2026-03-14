using Microsoft.Extensions.Logging;
using MudBlazor;
using MudBlazor.Services;
using VaultUI.Helpers;
using VaultUI.Http;
using VaultUI.Repository;
using VaultUI.Services;

namespace VaultUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMudServices( configuration =>
            {
                configuration.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomCenter;
                configuration.SnackbarConfiguration.PreventDuplicates = false;
                configuration.SnackbarConfiguration.ShowCloseIcon = true;
                configuration.SnackbarConfiguration.VisibleStateDuration = 1000;
                configuration.SnackbarConfiguration.HideTransitionDuration = 500;
                configuration.SnackbarConfiguration.ShowTransitionDuration = 500;
                configuration.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
            }
                
                );
            builder.Services.AddMauiBlazorWebView();
            //builder.Services.AddHttpClient();
            builder.Services.AddSingleton<LoadingService>();
            builder.Services.AddHttpClient<ApiClient>(client =>
            {
                client.BaseAddress = new Uri(Constants.API_URL);
            });
            builder.Services.AddScoped<IVaultRepository, VaultRepository>();
            builder.Services.AddScoped<VaultService>();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
