using DPC.Web.Models;

namespace DPC.Web.Extensions
{
    public static class CustomExtensions
    {
        public static T GetFirstItem<T>(this IEnumerable<T> items, Func<IEnumerable<T>, IEnumerable<T>> sort) => sort(items).First();

        public static void AddCustomSettings(this IServiceCollection services, Action<CustomSettings> action)
        {
            var customSettings = new CustomSettings();

            action?.Invoke(customSettings);

            services.AddSingleton<ICustomSettings>(customSettings);
        }
    }
}
