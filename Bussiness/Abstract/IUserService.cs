using Core.Utilities.Results.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IUserService
    {
        IDataResult<User> GetUser(User users);
        IResult Add(User users);
        IResult Update(User users);
        IResult Delete(User users);
    }
}
