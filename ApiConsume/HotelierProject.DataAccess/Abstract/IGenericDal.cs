using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GetList();

    }
}
