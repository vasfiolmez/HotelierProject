using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController(IGenericService<Staff> _genericService) : ControllerBase
    {

        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _genericService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var value = _genericService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _genericService.TCreate(staff);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            _genericService.TDelete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _genericService.TUpdate(staff);
            return Ok();
        }
    }
}
