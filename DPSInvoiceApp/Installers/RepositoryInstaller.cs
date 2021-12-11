using EntityFrameworkDPSLibrary.Models;
using EntityFrameworkDPSLibrary.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DPSInvoiceApp.Installers
{
    public class RepositoryInstaller : IInstaller
    {
        /// <summary>
        /// Dependency injection for Repositories classes
        /// </summary>
        public void InstallServices(IServiceCollection services, IConfiguration Configuration)
        {
            services.AddScoped<IRepository<Product, string>, ProductRepository>();
            services.AddScoped<IRepository<Invoice, string>, InvoiceRepository>();
            services.AddScoped<IRepository<Buyer, string>, BuyerRepository>();
            services.AddScoped<IRepository<Seller, string>, SellerRepository>();
            services.AddScoped<IRepository<ProductsOnInvoice, string>, ProductsOnInvoiceRepository>();
        }
    }
}
