﻿using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace Localization.Helpers
{
    /// <summary>
    /// A <see langword="static"/> class which can be used to save user settings.
    /// Uses Xam.Plugins.Settings.
    /// </summary>
    public static class UserSettings
    {
        /// <summary>
        /// Gets the app settings.
        /// </summary>
        /// <value>The app settings.</value>
        private static ISettings AppSettings => CrossSettings.Current;

        /// <summary>
        /// A struct of lookup keys for settings.
        /// </summary>
        private struct Keys
        {
            /// <summary>The langauge key.</summary>
            public const string Language = "language";
            /// <summary>The alreadyLaunched key.</summary>
            public const string AlreadyLaunched = "alreadyLaunched";
        }

        /// <summary>
        /// The display language.
        /// </summary>
        public static string Language
        {
            get => AppSettings.GetValueOrDefault(Keys.Language, "en");
            set => AppSettings.AddOrUpdateValue(Keys.Language, value);
        }

        /// <summary>
        /// Whether it is the first launch (of the app).
        /// </summary>
        public static bool AlreadyLaunched
        {
            get => AppSettings.GetValueOrDefault(Keys.AlreadyLaunched, false);
            set => AppSettings.AddOrUpdateValue(Keys.AlreadyLaunched, value);
        }

        /// <summary>
        /// Clears all saved preferences.
        /// </summary>
        public static void Clear()
        {
            AppSettings.Clear();
        }
    }
}
