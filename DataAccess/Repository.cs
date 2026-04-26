using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
    }

    public interface IRepisitory<T> where T : EntityBase
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }


    public abstract class RepositoryBase<T> where T : EntityBase
    {
        protected readonly List<T> _items = new List<T>();
        protected int _nextId = 1;

        public List<T> GetAll()
        {
            return _items;
        }
        public T GetById(int id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }
        public void Add(T entity)
        {
            _items.Add(entity);
        }
        public void Update(T entity)
        {
            var existing = GetById(entity.Id);
            if (existing != null)
            {
                int index = _items.IndexOf(existing);
                _items(index) = existing;
            }
        }
        public void Delete(int id)
        {
            var existing = GetById(id);
            if (existing != null)
                _items.Remove(existing);
        }

        public class ProductRepository : RepositoryBase<Product>
        {
        }


    }
}


