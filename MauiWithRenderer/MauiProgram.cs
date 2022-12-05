using MauiWithRenderer.Handlers;
using MauiWithRenderer.Platforms.Android;
using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace MauiWithRenderer;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();

        // demo of usage AddCompatibilityRenderer(..) --> non working on Android cause of MAUI bug https://github.com/dotnet/maui/issues/9936 

        // now use new compatibility renderer option: 

        builder
            .UseMauiApp<App>()
            .ConfigureMauiHandlers(handlers =>
            {
                handlers.AddHandler(typeof(CardsView), typeof(CardsViewHandler));
            })
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
