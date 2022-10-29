using Core.DataAccess.EntityFramework;
using DataAccess.Abstarct;
using DataAccess.Concrete.SqlServer;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUsersDal : EfRepositoryBase<User, RoboCargosContext>, IUserDal
    {
      

        public User GetUserInfo(Expression<Func<User, bool>> expression, int userId)
        {
            using (var context = new RoboCargosContext())
            {


                return context.Set<User>().Where(p => p.UserCredential == userId).SingleOrDefault();



            }
        }
    }
}
