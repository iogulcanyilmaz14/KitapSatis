﻿using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager()
        {
            _userDal = new EfUserDal();
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            var result = _userDal.GetAll();
            if (result == null)
            {
                return new ErrorDataResult<List<User>>();
            }
            return new SuccessDataResult<List<User>>(result, Messages.UsersListed);
        }

        public IDataResult<User> GetById(int userId)
        {
            var result = _userDal.Get(u => u.Id == userId);
            if (result == null)
            {
                return new ErrorDataResult<User>(result);
            }
            return new SuccessDataResult<User>(result, Messages.UserGeted);
        }

        public IDataResult<User> GetByMail(string email)
        {
            var result = _userDal.Get(u => u.Email == email);
            if (result == null)
            {
                return new ErrorDataResult<User>();
            }
            return new SuccessDataResult<User>(result, Messages.UserGeted);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
