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
    public class TestimonialManager(ITestimonialDal _testimonialDal) : ITestimonialService
    {
        public void TCreate(Testimonial entity)
        {
            _testimonialDal.Create(entity);
        }

        public void TDelete(int id)
        {
           _testimonialDal.Delete(id);
        }

        public Testimonial TGetById(int id)
        {
           return _testimonialDal.GetById(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialDal.Update(entity);
        }
    }
}
