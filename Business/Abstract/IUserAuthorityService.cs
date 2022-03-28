using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserAuthorityService
    {
        IDataResult<List<UserAuthority>> GetAll();
        IResult Add(UserAuthority userAuthority);
        IResult Delete(UserAuthority userAuthority);
        IResult Update(UserAuthority userAuthority);
        IDataResult<UserAuthority> GetById(int id);
    }
}
