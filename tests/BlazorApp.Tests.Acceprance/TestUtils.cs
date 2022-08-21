
using Microsoft.Extensions.Configuration;

namespace BlazorApp.Tests.Acceprance
{
    internal static class TestUtils
    {
        public const string AppBaseUrlKey = "BlazorApp:BaseUrl";
        public const string ComposeFileNamelKey = "DockerComposeFileName";
        public static IConfiguration LoadConfiguration()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}
