using EntityFrameworkDPSLibrary.DatabaseContext;
using EntityFrameworkDPSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkDPSLibrary.Repositories
{
    /// <summary>
    /// Logic of interaction with Database for Invoice model 
    /// </summary>
    public class InvoiceRepository : IRepository<Invoice, string>
    {
        private MFSDbContext _context;

        public InvoiceRepository(MFSDbContext context)
        {
            _context = context;
        }

        public Invoice Add(Invoice newModel)
        {
            _context.Invoice.Add(newModel);
            _context.SaveChanges();
            return newModel;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Delete(Invoice modelToDelete)
        {
            throw new NotImplementedException();
        }

        public Invoice Find(string key)
        {
            throw new NotImplementedException();
        }

        public ICollection<Invoice> FindAll(string key)
        {
            throw new NotImplementedException();
        }

        public Invoice Get(string key)
        {
            return _context.Invoice.Find(key);
        }

        public ICollection<Invoice> GetAll()
        {
            return _context.Invoice.ToList();
        }

        public ICollection<Invoice> GetAll(string key)
        {
            return _context.Invoice.Where(x => x.InvoiceNumber == key).ToList();
        }

        public Invoice Update(Invoice updatedModel, string key)
        {
            throw new NotImplementedException();
        }
    }
}
