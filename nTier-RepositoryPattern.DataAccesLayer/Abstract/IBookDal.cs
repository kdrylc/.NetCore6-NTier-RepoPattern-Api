using nTier_RepositoryPattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nTier_RepositoryPattern.DataAccesLayer.Abstract
{
    public interface IBookDal:IGenericDal<Book>
    {
    }
}
