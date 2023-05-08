using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProje.DataAccessLayer.Abstract;
using TraversalCoreProje.DataAccessLayer.Concrete;

namespace TraversalCoreProje.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Delete(T t)
        {
            using AppDbContext _context = new AppDbContext();
            _context.Remove(t);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            using AppDbContext _context = new AppDbContext();
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using AppDbContext _context = new AppDbContext();
            return _context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using AppDbContext _context = new AppDbContext();
            _context.Add(t);
        }

        public void Update(T t)
        {
            using AppDbContext _context = new AppDbContext();
            _context.Update(t);
        }
    }
}
