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
    public class BookOrderManager : IBookOrderService
    {
        private IBookOrderDal _bookorderDal;

        public BookOrderManager()
        {
            _bookorderDal = new EfBookOrderDal();
        }

        public IResult Add(BookOrder bookorder)
        {
            _bookorderDal.Add(bookorder);
            return new SuccessResult(Messages.BookOrderAdded);
        }

        public IResult Delete(BookOrder bookorder)
        {
            _bookorderDal.Delete(bookorder);
            return new SuccessResult(Messages.BookOrderDeleted);
        }

        public IDataResult<List<BookOrder>> GetAll()
        {
            var result = _bookorderDal.GetAll();
            if (result == null)
            {
                return new ErrorDataResult<List<BookOrder>>();
            }
            return new SuccessDataResult<List<BookOrder>>(result, Messages.BookOrderListed);
        }

        public IDataResult<BookOrder> GetById(int id)
        {
            var result = _bookorderDal.Get(b => b.Id == id);
            if (result == null)
            {
                return new ErrorDataResult<BookOrder>();
            }
            return new SuccessDataResult<BookOrder>(result, Messages.BookOrderGeted);
        }

        public IResult Update(BookOrder bookorder)
        {
            _bookorderDal.Update(bookorder);
            return new SuccessResult(Messages.BookOrderUpdated);
        }
    }
}
