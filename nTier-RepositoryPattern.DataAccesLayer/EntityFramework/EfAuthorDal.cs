using nTier_RepositoryPattern.DataAccesLayer.Abstract;
using nTier_RepositoryPattern.DataAccesLayer.Repositories;
using nTier_RepositoryPattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nTier_RepositoryPattern.DataAccesLayer.EntityFramework
{
    public class EfAuthorDal:GenericRepositories<Author>,IAuthorDal
    {
    }
}
