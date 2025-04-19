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
    internal class RoomManager(IRoomDal _roomDal) : IRoomService
    {
        public void TCreate(Room entity)
        {
            _roomDal.Create(entity);
        }

        public void TDelete(int id)
        {
            _roomDal.Delete(id);
        }

        public Room TGetById(int id)
        {
            return _roomDal.GetById(id);
        }

        public List<Room> TGetList()
        {
            return _roomDal.GetList();
        }

        public void TUpdate(Room entity)
        {
            _roomDal.Update(entity);
        }
    }
}
