using Microsoft.Maui.Hosting;

namespace IconFont.Maui.MaterialDesignWebIcons;

public static partial class IconFontBuilderExtensions
{
    /// <summary>
    /// Registers all Material Design Icons font styles (Outlined, Round, Sharp, TwoTone).
    /// </summary>
    public static MauiAppBuilder UseMaterialDesignWebIcons(this MauiAppBuilder builder)
    {
        builder.ConfigureFonts(fonts =>
        {
            foreach (var cfg in IconFontConfigs.All)
            {
                fonts.AddFont(cfg.FontFile, cfg.FontAlias);
            }
        });
        return builder;
    }

    // Called by generated per-font helpers (UseMaterialDesignIconsFilled, etc.)
    internal static MauiAppBuilder UseIconFont(this MauiAppBuilder builder, string fontClass)
    {
        IconFontConfig? cfg = Array.Find(IconFontConfigs.All, x => x.ClassName == fontClass);
        if (cfg is not null)
        {
            builder.ConfigureFonts(fonts => fonts.AddFont(cfg.FontFile, cfg.FontAlias));
        }
        return builder;
    }
}
