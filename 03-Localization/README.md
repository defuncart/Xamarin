# 03 - Localization

An application which explores localization in Xamarin.Forms.

## Overview

Localization is achieved by using [Multilingual Plugin](http://github.com/CrossGeeks/MultilingualPlugin) where localizations are stored in *.resx* files and can be loaded by suppling a culture:

```csharp
CrossMultilingual.Current.CurrentCultureInfo = new CultureInfo("en");
AppResources.Culture = CrossMultilingual.Current.CurrentCultureInfo;
```

The chosen localization is saved as a user setting, serialized to disk using [Settings Plugin](https://github.com/jamesmontemagno/SettingsPlugin). The benefit of this plugin over, say the *Properties Dictionary*, is that this plugin uses the native settings of the target platform (i.e. UserDefaults on iOS, SharedPreferences on Android etc.) instead of serializing items to disk.

## Gotchas

- When importing the Plugin.Multilingual NuGet on Visual Studio for Mac, the file *TranslateExtension.txt* in **/Helpers** isn't generated as noted in the base tutorial. Instead I manually created this file by using a template for their sample's repo.

## Resources

[Multilingual Plugin](http://github.com/CrossGeeks/MultilingualPlugin)

[Settings Plugin](https://github.com/jamesmontemagno/SettingsPlugin)
