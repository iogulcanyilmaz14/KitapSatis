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
    public class BookCategoryManager : IBookCategoryService
    {
        private IBookCategoryDal _bookcategoryDal;

        public BookCategoryManager()
        {
            _bookcategoryDal = new EfBookCategoryDal();
        }

        public IResult Add(BookCategory bookCategory)
        {
            _bookcategoryDal.Add(bookCategory);
            return new SuccessResult(Messages.BookCategoryAdded);
        }

        public IResult Delete(BookCategory bookCategory)
        {
            _bookcategoryDal.Delete(bookCategory);
            return new SuccessResult(Messages.BookCategoryDeleted);
        }

        public IDataResult<List<BookCategory>> GetAll()
        {
            var result = _bookcategoryDal.GetAll();
            if (result == null)
            {
                return new ErrorDataResult<List<BookCategory>>();
            }
            return new SuccessDataResult<List<BookCategory>>(result, Messages.BookCategoryListed);
        }

        public IDataResult<BookCategory> GetById(int id)
        {
            var result = _bookcategoryDal.Get(b => b.Id == id);
            if (result == null)
            {
                return new ErrorDataResult<BookCategory>();
            }
            return new SuccessDataResult<BookCategory>(result, Messages.BookCategoryGeted);
        }

        public IResult Update(BookCategory bookCategory)
        {
            _bookcategoryDal.Update(bookCategory);
            return new SuccessResult(Messages.BookCategoryUpdated);
        }
    }
}
