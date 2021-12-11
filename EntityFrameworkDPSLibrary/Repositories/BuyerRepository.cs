using EntityFrameworkDPSLibrary.DatabaseContext;
using EntityFrameworkDPSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkDPSLibrary.Repositories
{
    /// <summary>
    /// Logic of interaction with Database for Buyer model 
    /// </summary>
    public class BuyerRepository : IRepository<Buyer, string>
    {
        private MFSDbContext _context;

        public BuyerRepository(MFSDbContext context)
        {
            _context = context;
        }

        public Buyer Add(Buyer newModel)
        {
            _context.Buyer.Add(newModel);
            _context.SaveChanges();
            return newModel;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Delete(Buyer modelToDelete)
        {
            throw new NotImplementedException();
        }

        public Buyer Find(string key)
        {
            throw new NotImplementedException();
        }

        public ICollection<Buyer> FindAll(string key)
        {
            throw new NotImplementedException();
        }

        public Buyer Get(string key)
        {
            return _context.Buyer.Find(key);
        }

        public ICollection<Buyer> GetAll()
        {
            return _context.Buyer.ToList();
        }

        public ICollection<Buyer> GetAll(string key)
        {
            return _context.Buyer.Where(x => x.NIP == key).ToList();
        }

        public Buyer Update(Buyer updatedModel, string key)
        {
            throw new NotImplementedException();
        }
    }
}
