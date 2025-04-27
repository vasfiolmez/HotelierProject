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
    public class StaffManager(IStaffDal _staffDal) : IStaffService
    {
        public void TCreate(Staff entity)
        {
           _staffDal.Create(entity);
        }

        public void TDelete(int id)
        {
            _staffDal.Delete(id);
        }

        public Staff TGetById(int id)
        {
         return  _staffDal.GetById(id);
        }

        public List<Staff> TGetList()
        {
            return _staffDal.GetList();
        }

        public void TUpdate(Staff entity)
        {
            _staffDal.Update(entity);
        }
    }
}
