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
    public class BookManager : IBookService
    {
        private readonly IBookDal _bookdal;

        public BookManager(IBookDal bookdal)
        {
            _bookdal = bookdal;
        }

        public void TDelete(Book t)
        {
            _bookdal.Delete(t);
        }

        public Book TGetById(int id)
        {
            return _bookdal.GetByID(id);
        }

        public List<Book> TGetList()
        {
            return _bookdal.GetList();
        }

        public void TInsert(Book t)
        {
             _bookdal.Insert(t);
        }

        public void TUpdate(Book t)
        {
            _bookdal.Update(t);   
        }
    }
}
