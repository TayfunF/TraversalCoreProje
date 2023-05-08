using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Abstracts;
using TraversalCoreProje.DataAccessLayer.Abstract;
using TraversalCoreProje.DataAccessLayer.Repositories;
using TraversalCoreProje.EntityLayer.Concrete;

namespace TraversalCoreProje.BusinessLayer.Concretes
{
    public class TestimonialService : ITestimonialService
    {
        ITestimonialRepository _testimonialRepository;

        public TestimonialService(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        public void TAdd(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public Testimonial TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialRepository.GetList();
        }

        public void TUpdate(Testimonial t)
        {
            throw new NotImplementedException();
        }
    }
}
