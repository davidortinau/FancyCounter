using Microsoft.Maui.Hosting;

namespace FancyCounter;
public class App : CometApp
{
	[Body]
	View view() => new MainPage();

	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseCometApp<App>()
			.ConfigureFonts(fonts => {
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("fa-solid-900.ttf", "FontAwesome");
			});

#if DEBUG
			builder.EnableHotReload();
#endif
		return builder.Build();
	}
}
