using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.BusinessLayer.Concrete
{
    public class GenericManager<T>(IGenericDal<T> _repository) : IGenericService<T> where T : class
    {
        public void TCreate(T entity)
        {
            _repository.Create(entity);
        }

        public void TDelete(int id)
        {
           _repository.Delete(id);
        }

        public T TGetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<T> TGetList()
        {
            return _repository.GetList();
        }

        public void TUpdate(T entity)
        {
            _repository.Update(entity);
        }
    }
}
