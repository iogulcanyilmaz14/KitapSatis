using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBookCategoryService
    {
        IDataResult<List<BookCategory>> GetAll();
        IResult Add(BookCategory bookcategory);
        IResult Delete(BookCategory bookcategory);
        IResult Update(BookCategory bookcategory);
        IDataResult<BookCategory> GetById(int id);
    }
}
