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
    public class DestinationService : IDestinationService
    {
        IDestinationRepository _destinationRepository;
        public DestinationService(IDestinationRepository destinationRepository)
        {
            _destinationRepository = destinationRepository;
        }

        public void TAdd(Destination t)
        {
            _destinationRepository.Insert(t);
        }

        public void TDelete(Destination t)
        {
            _destinationRepository.Delete(t);
        }

        public Destination TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Destination> TGetList()
        {
            return _destinationRepository.GetList();
        }

        public void TUpdate(Destination t)
        {
            _destinationRepository.Update(t);
        }
    }
}
