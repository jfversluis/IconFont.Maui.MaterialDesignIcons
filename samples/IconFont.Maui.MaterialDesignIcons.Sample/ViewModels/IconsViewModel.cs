using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using IconFont.Maui.MaterialDesignIcons;

namespace IconFont.Maui.MaterialDesignIcons.Sample.ViewModels;

public class IconGlyph
{
    public required string Glyph { get; init; }
    public required string Identifier { get; init; }
    public required string XamlIdentifier { get; init; }
    public required string FontFamily { get; init; }
}

public class IconsViewModel
{
    private static readonly HashSet<string> SkipFields = new() { "FontFamily" };

    public ObservableCollection<IconGlyph> Icons { get; } = new();

    public IconsViewModel(string? fontClass = null)
    {
        var asm = typeof(MaterialDesignIconsOutlined).Assembly;
        foreach (var cfg in IconFontConfigs.All)
        {
            if (fontClass is not null && !string.Equals(cfg.ClassName, fontClass, StringComparison.Ordinal))
                continue;

            // Each OTF may produce multiple generated sub-classes (e.g. Regular, Filled, Rtl).
            // Prefer the "Regular" sub-class which contains the main icon set.
            // Fall back to exact match or first StartsWith match.
            var matchingTypes = asm.GetTypes()
                .Where(t => t.IsAbstract && t.IsSealed
                    && t.Namespace == cfg.Namespace
                    && t.Name.StartsWith(cfg.ClassName, StringComparison.Ordinal))
                .OrderBy(t => t.Name, StringComparer.Ordinal)
                .ToList();

            var primary = matchingTypes.FirstOrDefault(t => t.Name == cfg.ClassName + "Regular")
                       ?? matchingTypes.FirstOrDefault(t => t.Name == cfg.ClassName)
                       ?? matchingTypes.FirstOrDefault();

            if (primary is not null)
            {
                AddIcons(primary, cfg.FontAlias, cfg.ClassName);
            }
        }
    }

    private void AddIcons(Type type, string fontFamily, string identifierPrefix)
    {
        var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static);
        foreach (var field in fields)
        {
            if (field.FieldType != typeof(string)) continue;
            if (SkipFields.Contains(field.Name)) continue;
            var glyph = field.GetValue(null) as string;
            if (string.IsNullOrEmpty(glyph)) continue;
            Icons.Add(new IconGlyph
            {
                Glyph = glyph!,
                FontFamily = fontFamily,
                Identifier = $"{identifierPrefix}.{field.Name}",
                XamlIdentifier = $"icons:{identifierPrefix}.{field.Name}"
            });
        }
    }
}
