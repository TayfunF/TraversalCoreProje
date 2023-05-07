using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Abstracts;
using TraversalCoreProje.DataAccessLayer.Abstract;
using TraversalCoreProje.EntityLayer.Concrete;

namespace TraversalCoreProje.BusinessLayer.Concretes
{
    public class AboutService : IAboutService
    {
        IAboutRepository _aboutRepository;

        public AboutService(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public void TAdd(About t)
        {
            _aboutRepository.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutRepository.Delete(t);
        }

        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
            return _aboutRepository.GetList();
        }

        public void TUpdate(About t)
        {
            _aboutRepository.Update(t);
        }
    }
}
