[![NuGet](https://img.shields.io/nuget/v/IconFont.Maui.MaterialDesignWebIcons.svg?label=NuGet)](https://www.nuget.org/packages/IconFont.Maui.MaterialDesignWebIcons)

# IconFont.Maui.MaterialDesignWebIcons

`IconFont.Maui.MaterialDesignWebIcons` ships the [Google Material Design Icons](https://github.com/google/material-design-icons) OTF icon font, 
extended and provided by [Pictogrammers](https://pictogrammers.com/library/mdi/) for .NET MAUI:

| Style | File | Class |
|-------|------|-------|
| Web | `materialdesignicons-webfont.ttf` | `MaterialDesignWebIconsOutlined` |

It registers the fonts across supported targets when you call `UseMaterialDesignWebIcons()` (or individual helpers) and exposes strongly-typed glyph constants to simplify XAML and C# usage.

## ✨ Features
- ⚙️ **One-line setup**: call `builder.UseMaterialDesignWebIcons()` to register all fonts,.
- 🔤 **Strongly-typed glyphs** via flat classes: `MaterialDesignWebIconsOutlined.Home`, `MaterialDesignWebIconsRound.Search`, etc.
- 📱 **Supported targets**: Android, iOS, Mac Catalyst, Windows

## 📦 Install
```bash
dotnet add package IconFont.Maui.MaterialDesignWebIcons
```

## 🚀 Getting Started

### Register
```csharp
var builder = MauiApp.CreateBuilder()
    .UseMauiApp<App>()
    .UseMaterialDesignWebIcons(); // registers all four font styles
```

Or register individual fonts:
```csharp
builder.UseMaterialDesignWebIconsOutlined();  // Outlined only
```

### XAML usage
```xml
xmlns:icons="clr-namespace:IconFont.Maui.MaterialDesignWebIcons;assembly=IconFont.Maui.MaterialDesignWebIcons"

<Label Glyph="{x:Static icons:MaterialDesignWebIconsOutlined.Home}"
       FontFamily="{x:Static icons:MaterialDesignWebIconsOutlined.FontFamily}"
       FontSize="32" />
```

### C# usage
```csharp
using IconFont.Maui.MaterialDesignWebIcons;

var label = new Label
{
    FontFamily = MaterialDesignWebIconsOutlined.FontFamily,
    Text = MaterialDesignWebIconsOutlined.Home,
    FontSize = 32
};
```

> **Tip:** Glyph names follow the upstream font. If the font adds/changes glyphs, updating the OTF and rebuilding regenerates this API.

## 📋 Styles & Glyphs
The source generator emits flat top-level classes for XAML `{x:Static}` compatibility:

| Class | Example |
|-------|---------|
| `MaterialDesignWebIconsOutlined` | `MaterialDesignWebIconsOutlined.Home` |

## 🧩 Platforms
| Platform | Minimum |
|----------|---------|
| Android  | 21+     |
| iOS      | 15+     |
| macOS    | 12+     |
| Windows  | 10 1809 |

## 📄 License
- **Library:** MIT
- **Font & Icons:** Apache 2.0 © Google (see [NOTICE.md](NOTICE.md) and [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0))
- **Service:** MIT © Pictogrammers (see [NOTICE.md](NOTICE.md) and [MIT](https://pictogrammers.com/docs/general/license))

## 🙏 Attribution
- Upstream font: Apache 2.0 © Google LLC
- This project is not affiliated with or endorsed by Google or Pictogrammers.
