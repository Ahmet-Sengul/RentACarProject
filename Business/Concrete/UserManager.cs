using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _UserDal;
        public UserManager(IUserDal userDal)
        {
            _UserDal = userDal;
        }

        public IResult Add(User user)
        {
            _UserDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _UserDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_UserDal.GetAll());
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_UserDal.Get(u => u.UserId == userId));
        }

        public IResult Update(User user)
        {
            _UserDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
