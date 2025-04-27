using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribersController(IGenericService<Subscribe> _genericService) : ControllerBase
    {
        [HttpGet]
        public IActionResult SubscriberList()
        {
            var values = _genericService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscriber(int id)
        {
            var value = _genericService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult AddSubscriber(Subscribe subscribe)
        {
            _genericService.TCreate(subscribe);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscriber(int id)
        {
            _genericService.TDelete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscriber(Subscribe subscribe)
        {
            _genericService.TUpdate(subscribe);
            return Ok();
        }
    }
}
