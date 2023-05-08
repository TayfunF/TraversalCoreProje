using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProje.DataAccessLayer;
using TraversalCoreProje.EntityLayer;

namespace TraversalCoreProje.DataAccessLayer
{
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
    }
}
