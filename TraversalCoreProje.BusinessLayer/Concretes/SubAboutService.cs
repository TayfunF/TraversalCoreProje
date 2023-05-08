using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Abstracts;
using TraversalCoreProje.DataAccessLayer.Repositories;
using TraversalCoreProje.EntityLayer.Concrete;

namespace TraversalCoreProje.BusinessLayer.Concretes
{
    public class SubAboutService : ISubAboutService
    {
        SubAboutRepository _subAboutRepository;

        public SubAboutService(SubAboutRepository subAboutRepository)
        {
            _subAboutRepository = subAboutRepository;
        }

        public void TAdd(SubAbout t)
        {
            _subAboutRepository.Insert(t);
        }

        public void TDelete(SubAbout t)
        {
            _subAboutRepository.Delete(t);
        }

        public SubAbout TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetList()
        {
            return _subAboutRepository.GetList();
        }

        public void TUpdate(SubAbout t)
        {
            _subAboutRepository.Update(t);
        }
    }
}
