using HotelierProject.DataAccess.Abstract;
using HotelierProject.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.DataAccess.Repositories
{
    public class GenericRepository<T>(HotelContext _context): IGenericDal<T> where T : class
    {
        public DbSet<T> Table { get => _context.Set<T>(); }

        public void Create(T entity)
        {
           Table.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = Table.Find(id);
            Table.Remove(entity);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return Table.Find(id);
        }

        public List<T> GetList()
        {
            return Table.ToList();
        }

        public void Update(T entity)
        {
            Table.Update(entity);
            _context.SaveChanges();
        }
    }
}
