using EntityFrameworkDPSLibrary.DatabaseContext;
using EntityFrameworkDPSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkDPSLibrary.Repositories
{
    /// <summary>
    /// Logic of interaction with Database for Seller model 
    /// </summary>
    public class SellerRepository : IRepository<Seller, string>
    {
        private MFSDbContext _context;

        public SellerRepository(MFSDbContext context)
        {
            _context = context;
        }

        public Seller Add(Seller newModel)
        {
            _context.Seller.Add(newModel);
            _context.SaveChanges();
            return newModel;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Delete(Seller modelToDelete)
        {
            throw new NotImplementedException();
        }

        public Seller Find(string key)
        {
            throw new NotImplementedException();
        }

        public ICollection<Seller> FindAll(string key)
        {
            throw new NotImplementedException();
        }

        public Seller Get(string key)
        {
            return _context.Seller.Find(key);
        }

        public ICollection<Seller> GetAll()
        {
            return _context.Seller.ToList();
        }

        public ICollection<Seller> GetAll(string key)
        {
            return _context.Seller.Where(x => x.NIP == key).ToList();
        }

        public Seller Update(Seller updatedModel, string key)
        {
            throw new NotImplementedException();
        }
    }
}
