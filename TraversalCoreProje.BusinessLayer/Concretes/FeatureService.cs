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
    public class FeatureService : IFeatureService
    {
        IFeatureRepository _featureRepository;

        public FeatureService(IFeatureRepository featureRepository)
        {
            _featureRepository = featureRepository;
        }

        public void TAdd(Feature t)
        {
            _featureRepository.Insert(t);
        }

        public void TDelete(Feature t)
        {
            _featureRepository.Delete(t);
        }

        public Feature TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetList()
        {
            return _featureRepository.GetList();
        }

        public void TUpdate(Feature t)
        {
            _featureRepository.Update(t);
        }
    }
}
