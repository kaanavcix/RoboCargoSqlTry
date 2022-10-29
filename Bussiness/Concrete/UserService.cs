using Bussiness.Abstract;
using Bussiness.Constant;
using Bussiness.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstarct;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class UserService : IUserService
    {

       private IUserDal _userDal;
         
        public UserService(IUserDal userDal) {
        
        _userDal=userDal;
                }

        [ValidationAspect(typeof(UsersValidator), Priority = 1)]
        public IResult Add(User users)
        {
            _userDal.Add(users);

            return new SuccessResult(SuccessMessages.sucessMessageForAddUser);
        }

        public IResult Delete(User users)
        {
            _userDal.Delete(users);

            return  new SuccessResult(SuccessMessages.sucessMessageForDeleteUser);
        }

        public IDataResult<User> GetUser(User users)
        {
            var result = _userDal.Get(p => p.UserCredential == users.UserCredential);

            return new DataResult<User>(result, SuccessMessages.sucessMessageForGetUser, true);
        }

        public IResult Update(User users)
        {
           _userDal.Update(users);

            return new SuccessResult(SuccessMessages.sucessMessageForUpdateUser);
        }
    }
}
