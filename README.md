[![NuGet](https://img.shields.io/nuget/v/IconFont.Maui.MaterialDesignIcons.svg?label=NuGet)](https://www.nuget.org/packages/IconFont.Maui.MaterialDesignIcons)

# IconFont.Maui.MaterialDesignIcons

`IconFont.Maui.MaterialDesignIcons` ships four [Google Material Design Icons](https://github.com/google/material-design-icons) OTF icon fonts for .NET MAUI:

| Style | File | Class |
|-------|------|-------|
| Outlined | `MaterialIconsOutlined-Regular.otf` | `MaterialDesignIconsOutlined` |
| Round | `MaterialIconsRound-Regular.otf` | `MaterialDesignIconsRound` |
| Sharp | `MaterialIconsSharp-Regular.otf` | `MaterialDesignIconsSharp` |
| Two-Tone | `MaterialIconsTwoTone-Regular.otf` | `MaterialDesignIconsTwoTone` |

It registers the fonts across supported targets when you call `UseMaterialDesignIcons()` (or individual helpers) and exposes strongly-typed glyph constants to simplify XAML and C# usage.

## ✨ Features
- ⚙️ **One-line setup**: call `builder.UseMaterialDesignIcons()` to register all fonts, or per-font helpers like `UseMaterialDesignIconsOutlined()`, `UseMaterialDesignIconsRound()`, etc.
- 🔤 **Strongly-typed glyphs** via flat classes: `MaterialDesignIconsOutlined.Home`, `MaterialDesignIconsRound.Search`, etc.
- 📱 **Supported targets**: Android, iOS, Mac Catalyst, Windows

## 📦 Install
```bash
dotnet add package IconFont.Maui.MaterialDesignIcons
```

## 🚀 Getting Started

### Register
```csharp
var builder = MauiApp.CreateBuilder()
    .UseMauiApp<App>()
    .UseMaterialDesignIcons(); // registers all four font styles
```

Or register individual fonts:
```csharp
builder.UseMaterialDesignIconsOutlined();  // Outlined only
builder.UseMaterialDesignIconsRound();     // Round only
builder.UseMaterialDesignIconsSharp();     // Sharp only
builder.UseMaterialDesignIconsTwoTone();   // Two-Tone only
```

### XAML usage
```xml
xmlns:icons="clr-namespace:IconFont.Maui.MaterialDesignIcons;assembly=IconFont.Maui.MaterialDesignIcons"

<Label Glyph="{x:Static icons:MaterialDesignIconsOutlined.Home}"
       FontFamily="{x:Static icons:MaterialDesignIconsOutlined.FontFamily}"
       FontSize="32" />
```

### C# usage
```csharp
using IconFont.Maui.MaterialDesignIcons;

var label = new Label
{
    FontFamily = MaterialDesignIconsOutlined.FontFamily,
    Text = MaterialDesignIconsOutlined.Home,
    FontSize = 32
};
```

> **Tip:** Glyph names follow the upstream font. If the font adds/changes glyphs, updating the OTF and rebuilding regenerates this API.

## 📋 Styles & Glyphs
The source generator emits flat top-level classes for XAML `{x:Static}` compatibility:

| Class | Example |
|-------|---------|
| `MaterialDesignIconsOutlined` | `MaterialDesignIconsOutlined.Home` |
| `MaterialDesignIconsRound` | `MaterialDesignIconsRound.Home` |
| `MaterialDesignIconsSharp` | `MaterialDesignIconsSharp.Home` |
| `MaterialDesignIconsTwoTone` | `MaterialDesignIconsTwoTone.Home` |

## ❓ Why not Filled?

The classic Material Icons "Filled" style is only distributed as a TTF with `post` table version 3.0 (no glyph names). The source generator extracts glyph names from font metadata, so only the four OTF styles are supported. All four OTF styles contain the same icon set with the same codepoints.

## 🧩 Platforms
| Platform | Minimum |
|----------|---------|
| Android  | 21+     |
| iOS      | 15+     |
| macOS    | 12+     |
| Windows  | 10 1809 |

## 📄 License
- **Library:** MIT
- **Font:** Apache 2.0 © Google (see [NOTICE.md](NOTICE.md) and [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0))

## 🙏 Attribution
- Upstream font: Apache 2.0 © Google LLC
- This project is not affiliated with or endorsed by Google.
