using System.Collections.Generic;

namespace EntityFrameworkDPSLibrary.Repositories
{
    public interface IRepository<T, K> where T : class
    {
        public ICollection<T> GetAll();
        public ICollection<T> GetAll(K key);
        public T Get(K key);
        public T Find(K key);
        public ICollection<T> FindAll(K key);
        public T Add(T newModel);
        public T Update(T updatedModel, K key);
        public int Delete(T modelToDelete);
        public int Count();
    }
}
