namespace DPC.Web.Extensions
{
    public static class CustomExtensions
    {
        public static T GetFirstItem<T>(this IEnumerable<T> items, Func<IEnumerable<T>, IEnumerable<T>> sort) => sort(items).First();       
    }
}
