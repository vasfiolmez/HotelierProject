using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController(IGenericService<Testimonial> _genericService) : ControllerBase
    {

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _genericService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _genericService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _genericService.TCreate(testimonial);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            _genericService.TDelete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _genericService.TUpdate(testimonial);
            return Ok();
        }
    }
}
