using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProje.DataAccessLayer;

namespace TraversalCoreProje.DataAccessLayer
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
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

        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            using AppDbContext _context = new AppDbContext();
            return _context.Set<T>().Where(filter).ToList();
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
