using DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DPSInvoiceApp.Installers
{
    public class ManagerInstaller : IInstaller
    {
        /// <summary>
        /// Dependency injection for Managers classes
        /// </summary>
        public void InstallServices(IServiceCollection services, IConfiguration Configuration)
        {
            services.AddScoped<InvoiceMenager>();
        }
    }
}
