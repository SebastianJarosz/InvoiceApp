using DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment.InvoiceDTOS;
using DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment.InvoiceMappers;
using EntityFrameworkDPSLibrary.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace DPSInvoiceApp.Installers
{
    /// <summary>
    /// Dependency injection for Mappers classes
    /// </summary>
    public class MapperInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration Configuration)
        {
            services.AddScoped<IMapper<InvoiceDTO, Tuple<Invoice, Buyer, Seller, List<ProductsOnInvoice>>>, InvoiceMap>();
        }
    }
}
