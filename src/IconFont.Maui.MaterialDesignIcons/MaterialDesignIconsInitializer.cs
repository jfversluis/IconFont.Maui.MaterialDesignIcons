using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace IconFont.Maui.MaterialDesignIcons;

public sealed class MaterialDesignIconsInitializer : IMauiInitializeService
{
    public void Initialize(IServiceProvider services)
    {
        var registrar = services.GetService<IFontRegistrar>();
        if (registrar is null) return;
        foreach (var cfg in IconFontConfigs.All)
        {
            registrar.Register(cfg.FontFile, cfg.FontAlias);
        }
    }
}
