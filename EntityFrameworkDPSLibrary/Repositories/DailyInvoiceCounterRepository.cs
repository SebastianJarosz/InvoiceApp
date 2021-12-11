using EntityFrameworkDPSLibrary.DatabaseContext;
using EntityFrameworkDPSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkDPSLibrary.Repositories
{
    /// <summary>
    /// Logika interakcji dla klasy  DailyInvoiceCounter 
    /// </summary
    public class DailyInvoiceCounterRepository : IRepository<DailyInvoiceCounter, int>
    {
        private MFSDbContext _context;

        public DailyInvoiceCounterRepository(MFSDbContext context)
        {
            _context = context;
        }

        public DailyInvoiceCounter Add(DailyInvoiceCounter newModel)
        {
            _context.DailyInvoiceCounter.Add(newModel);
            _context.SaveChanges();
            return newModel;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Delete(DailyInvoiceCounter modelToDelete)
        {
            throw new NotImplementedException();
        }

        public DailyInvoiceCounter Find(int key)
        {
            throw new NotImplementedException();
        }

        public ICollection<DailyInvoiceCounter> FindAll(int key)
        {
            throw new NotImplementedException();
        }

        public DailyInvoiceCounter Get(int key)
        {
            throw new NotImplementedException();
        }

        public ICollection<DailyInvoiceCounter> GetAll()
        {
            return _context.DailyInvoiceCounter.ToList();
        }

        public ICollection<DailyInvoiceCounter> GetAll(int key)
        {
            return _context.DailyInvoiceCounter.Where(x => x.Id == key).ToList();
        }

        public DailyInvoiceCounter Update(DailyInvoiceCounter updatedModel, int key)
        {
            throw new NotImplementedException();
        }
    }
}
