using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls;
using SkiaSharp.Views.Maui.Handlers;

namespace SkiaSharp_TrimWarnings_3._116._0;

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
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .ConfigureMauiHandlers(handlers =>
            {
                handlers.AddHandler(typeof(SKCanvasView), typeof(SKCanvasViewHandler));
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}