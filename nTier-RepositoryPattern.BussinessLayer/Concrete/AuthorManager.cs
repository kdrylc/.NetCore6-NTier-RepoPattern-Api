using nTier_RepositoryPattern.BussinessLayer.Abstract;
using nTier_RepositoryPattern.DataAccesLayer.Abstract;
using nTier_RepositoryPattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nTier_RepositoryPattern.BussinessLayer.Concrete
{
    public class AuthorManager : IAuthorService
    {
        private readonly IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public void TDelete(Author t)
        {
            _authorDal.Delete(t);
        }

        public Author TGetById(int id)
        {
            return _authorDal.GetByID(id);
        }

        public List<Author> TGetList()
        {
            return _authorDal.GetList();
        }

        public void TInsert(Author t)
        {
            _authorDal.Insert(t);
        }

        public void TUpdate(Author t)
        {
          _authorDal.Update(t);
        }
    }
}
