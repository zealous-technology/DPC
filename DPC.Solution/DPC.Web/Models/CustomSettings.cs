namespace DPC.Web.Models
{
    public interface ICustomSettings
    {
        string? Name { get; set; }

        string? PolicyProvider { get; set; }
    }

    public class CustomSettings : ICustomSettings
    {
        public string? Name { get; set; }

        public string? PolicyProvider { get; set; }

        public override string ToString() => $"Name: {Name}, PolicyProvider: {PolicyProvider}";
    }
}
