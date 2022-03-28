using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBookOrderService
    {
        IDataResult<List<BookOrder>> GetAll();
        IResult Add(BookOrder bookorder);
        IResult Delete(BookOrder bookorder);
        IResult Update(BookOrder bookorder);
        IDataResult<BookOrder> GetById(int id);
    }
}
