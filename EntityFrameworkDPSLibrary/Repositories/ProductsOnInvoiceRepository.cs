using EntityFrameworkDPSLibrary.DatabaseContext;
using EntityFrameworkDPSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkDPSLibrary.Repositories
{
    /// <summary>
    /// Logic of interaction with Database for ProductsOnInvoic model 
    /// </summary>
    public class ProductsOnInvoiceRepository : IRepository<ProductsOnInvoice, string>
    {
        private MFSDbContext _context;

        public ProductsOnInvoiceRepository(MFSDbContext context)
        {
            _context = context;
        }

        public ProductsOnInvoice Add(ProductsOnInvoice newModel)
        {
            _context.ProductsOnInvoice.Add(newModel);
            _context.SaveChanges();
            return newModel;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Delete(ProductsOnInvoice modelToDelete)
        {
            throw new NotImplementedException();
        }

        public ProductsOnInvoice Find(string key)
        {
            throw new NotImplementedException();
        }

        public ICollection<ProductsOnInvoice> FindAll(string key)
        {
            throw new NotImplementedException();
        }

        public ProductsOnInvoice Get(string key)
        {
            throw new NotImplementedException();
        }

        public ICollection<ProductsOnInvoice> GetAll()
        {
            return _context.ProductsOnInvoice.ToList();
        }

        public ICollection<ProductsOnInvoice> GetAll(string key)
        {
            return _context.ProductsOnInvoice.Where(x => x.InvoiceNumber == key).ToList();
        }

        public ProductsOnInvoice Update(ProductsOnInvoice updatedModel, string key)
        {
            throw new NotImplementedException();
        }
    }
}
