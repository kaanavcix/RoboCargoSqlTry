using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstarct
{
    public interface IUserDal:IEntityRepositoryDal<User>
    {
       User GetUserInfo(Expression<Func<User,bool>> expression,int userId);
    }
}
