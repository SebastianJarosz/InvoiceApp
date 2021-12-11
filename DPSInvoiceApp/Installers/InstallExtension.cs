using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace DPSInvoiceApp.Installers
{
    /// <summary>
    /// Class enable to registry all dependency injection in aplication
    /// </summary>
    public static class InstallExtension
    {
        public static void IntallServicesInAssembly(this IServiceCollection services, IConfiguration configuration)
        {
            var installers = typeof(App).Assembly.ExportedTypes.Where(x =>
               typeof(IInstaller).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).Select(Activator.CreateInstance).Cast<IInstaller>().ToList();
            installers.ForEach(installer => installer.InstallServices(services, configuration));
        }
    }
}
