using Generichki_i_Ekstenzivni_Metodi.Entities.Interfaces;
using Generichki_i_Ekstenzivni_Metodi.Entities.Models;

namespace Generichki_i_Ekstenzivni_Metodi.Entities.Data
{
    public class GenericDb<T> : IGenericDb<T> where T : BaseEntity
    {
        private List<T> _db;
        public GenericDb()
        {
            _db = new List<T>();
        }

        public List<T> GetAll()
        {
            return _db;
        }

        public T GetById(int id)
        {
            return _db.SingleOrDefault(e => e.Id == id);
        }

        public void PrintAll()
        {
            foreach (T item in _db)
            {
                Console.WriteLine(item.GetInfo());
            }
        }

        public void Insert(T item)
        {
            _db.Add(item);
            Console.WriteLine($"New item from type {typeof(T).Name} was added in the database");
        }

        public void RemoveById(int id)
        {
            T itemToRemove = GetById(id);
            if (itemToRemove is null)
            {
                throw new ArgumentNullException("No item found with id" + id);
            }
            _db.Remove(itemToRemove);
        }
    }
}
