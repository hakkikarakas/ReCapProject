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
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(Users user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Users user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_userDal.GetAll(),Messages.Listed);
        }

        public IDataResult<Users> GetByEmail(string email)
        {
            return new SuccessDataResult<Users>(_userDal.Get(u=>u.Email==email));
        }

        public IDataResult<Users> GetById(int userId)
        {
            return new SuccessDataResult<Users>(_userDal.Get(u=>u.UserId==userId),Messages.Listed);
        }

        public IResult Update(Users user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.Uptaded);
        }
    }
}
