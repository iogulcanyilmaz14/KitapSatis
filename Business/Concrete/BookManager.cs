using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;

        public BookManager()
        {
            _bookDal = new EfBookDal();
        }

        public IResult Add(Book book)
        {
            _bookDal.Add(book);
            return new SuccessResult(Messages.BookAdded);
        }

        public IResult Delete(Book book)
        {
            _bookDal.Delete(book);
            return new SuccessResult(Messages.BookDeleted);
        }

        public IDataResult<List<Book>> GetAll()
        {
            var result = _bookDal.GetAll();
            if (result == null)
            {
                return new ErrorDataResult<List<Book>>();
            }
            return new SuccessDataResult<List<Book>>(result, Messages.BookListed);
        }

        public IDataResult<List<Book>> GetBooksByCategoryId(int bookCategoryId)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(b => b.BookCategoryId == bookCategoryId), Messages.BooksByCategoriesListed);
        }

        public IDataResult<Book> GetById(int id)
        {
            var result = _bookDal.Get(b => b.Id == id);
            if (result == null)
            {
                return new ErrorDataResult<Book>();
            }
            return new SuccessDataResult<Book>(result, Messages.BookGeted);
        }

        public IResult Update(Book book)
        {
            _bookDal.Update(book);
            return new SuccessResult(Messages.BookUpdated);
        }
    }
}