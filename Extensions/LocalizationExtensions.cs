using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;

namespace localization.Extensions
{
    public static class LocalizationExtensions
    {
        public static void AddLocalizations(this IServiceCollection services)
        {
            services.AddLocalization(options =>
            {
                options.ResourcesPath = "Resources";
            });

            services.Configure<RequestLocalizationOptions>(opt =>
            {
                var supportedCultures = new List<CultureInfo>{
                    new CultureInfo("en-GB"),
                    new CultureInfo("en-US"),
                    new CultureInfo("en"),
                    new CultureInfo("fr-FR"),
                    new CultureInfo("fr"),
                    new CultureInfo("hi-IN"),
                    new CultureInfo("hi"),
                    new CultureInfo("ne")
                };

                opt.DefaultRequestCulture = new RequestCulture("en-GB");
                // Formatting numbers, dates, etc.
                opt.SupportedCultures = supportedCultures;
                // UI strings that we have localized.
                opt.SupportedUICultures = supportedCultures;
            });
        }
    }
}