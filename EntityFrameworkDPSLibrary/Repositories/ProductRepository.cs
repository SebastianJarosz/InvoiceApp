using EntityFrameworkDPSLibrary.DatabaseContext;
using EntityFrameworkDPSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkDPSLibrary.Repositories
{
    /// <summary>
    /// Logic of interaction with Database for Product model 
    /// </summary>
    public class ProductRepository : IRepository<Product, string>
    {
        private MFSDbContext _context;

        public ProductRepository(MFSDbContext context)
        {
            _context = context;
        }

        public Product Add(Product newModel)
        {
            _context.Product.Add(newModel);
            _context.SaveChanges();
            return newModel;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Delete(Product modelToDelete)
        {
            throw new NotImplementedException();
        }

        public Product Find(string key)
        {
            throw new NotImplementedException();
        }

        public ICollection<Product> FindAll(string key)
        {
            throw new NotImplementedException();
        }

        public Product Get(string key)
        {
            return _context.Product.Find(key);
        }

        public ICollection<Product> GetAll()
        {
            return _context.Product.ToList();
        }

        public ICollection<Product> GetAll(string key)
        {
            return _context.Product.Where(x => x.Code == key).ToList();
        }

        public Product Update(Product updatedModel, string key)
        {
            throw new NotImplementedException();
        }
    }
}
