using MauiWithRenderer.Platforms.Android;
using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace MauiWithRenderer;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCompatibility()
            .ConfigureMauiHandlers(handlers =>
            {
                handlers.AddCompatibilityRenderer(typeof(CardsView), typeof(CardsViewRenderer));
            })
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
