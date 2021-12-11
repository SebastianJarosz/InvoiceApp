using DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment.Validators;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DPSInvoiceApp.Installers
{
    /// <summary>
    /// Dependency injection for Validators classes
    /// </summary>
    public class ValidatorsInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration Configuration)
        {
            services.AddScoped<NIPValidator>();
            services.AddScoped<InvoiceNumberValidator>();
            services.AddScoped<ProductOnInvoiceValidator>();
        }
    }
}
