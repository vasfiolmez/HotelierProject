using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DataAccess.Abstract;
using HotelierProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.BusinessLayer.Concrete
{
    public class ServicesManager(IServicesDal _servicesDal) : IServicesService
    {
        public void TCreate(Service entity)
        {
            _servicesDal.Create(entity);

        }

        public void TDelete(int id)
        {
            _servicesDal.Delete(id);
        }

        public Service TGetById(int id)
        {
           return _servicesDal.GetById(id);
        }

        public List<Service> TGetList()
        {
            return _servicesDal.GetList();

        }

        public void TUpdate(Service entity)
        {
            _servicesDal.Update(entity);
        }
    }
}
