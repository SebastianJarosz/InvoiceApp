using DPSInvoiceApp.Installers;
using EntityFrameworkDPSLibrary.Models;
using EntityFrameworkDPSLibrary.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Windows;

namespace DPSInvoiceApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    public partial class App : Application
    {
        IRepository<Product, string> _productRepository;
        private ServiceProvider serviceProvider;
        public IConfiguration Configuration { get; private set; }
        public App()
        {

            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }
        private void ConfigureServices(ServiceCollection services)
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
            services.IntallServicesInAssembly(Configuration);
            services.AddSingleton<InvoiceWindow>();
        }
        private async void OnStartup(object sender, StartupEventArgs e)
        {
            var invoiceWindow = serviceProvider.GetService<InvoiceWindow>();
            invoiceWindow.Show();
        }
    }
}
