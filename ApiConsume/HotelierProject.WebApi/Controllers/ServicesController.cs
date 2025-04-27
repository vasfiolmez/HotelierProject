using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController (IGenericService<Service> _genericService): ControllerBase
    {
        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _genericService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var value = _genericService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _genericService.TCreate(service);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            _genericService.TDelete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _genericService.TUpdate(service);
            return Ok();
        }
    }
}
