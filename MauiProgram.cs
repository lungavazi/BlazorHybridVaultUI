using Microsoft.Extensions.Logging;
using MudBlazor;
using MudBlazor.Services;

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
            builder.Services.AddHttpClient();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
