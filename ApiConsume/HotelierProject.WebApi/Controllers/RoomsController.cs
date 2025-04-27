using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController(IGenericService<Room> _genericService) : ControllerBase
    {
        [HttpGet]
        public IActionResult RoomList()
        {
            var values=_genericService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var value=_genericService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            _genericService.TCreate(room);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            _genericService.TDelete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            _genericService.TUpdate(room);
            return Ok();
        }
    }
}
