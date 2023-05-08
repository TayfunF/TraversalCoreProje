using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProje.EntityLayer;

namespace TraversalCoreProje.BusinessLayer
{
    public interface ICommentService : IGenericService<Comment>
    {
        public List<Comment> TGetDestinationById(int id);
    }
}
