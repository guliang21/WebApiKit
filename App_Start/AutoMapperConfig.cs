using AutoMapper;
using System.Reflection;

namespace WebApiKit
{
    public class AutoMapperConfig
    {
        public static void Initialize(params Assembly[] assemblies)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(assemblies);
            });
        }
    }
}