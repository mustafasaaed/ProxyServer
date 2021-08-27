using Microsoft.Extensions.DependencyInjection;
using ProxyLib.Models;
using System.Collections.Generic;


namespace ProxyLib.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddProxy(this IServiceCollection collection, List<ProxyConfiguration> config)
        {
            collection.AddSingleton(config);
            return collection;
        }
    }
}
