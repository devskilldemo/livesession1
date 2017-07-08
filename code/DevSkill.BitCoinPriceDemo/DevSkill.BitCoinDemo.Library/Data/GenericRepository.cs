using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill.BitCoinDemo.Library.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Entity
    {
        private DbContext _context;
        public GenericRepository(DbContext context)
        {
            _context = context;
        }

        public void Add(T item)
        {
            _context.Set<T>().Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}
