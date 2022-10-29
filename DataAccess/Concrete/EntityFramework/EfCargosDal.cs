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
    public class EfCargosDal : EfRepositoryBase<Cargo, RoboCargosContext>, ICargosDal
    {
        public List<Cargo> GetAllByLogisticUnits(Expression<Func<Cargo, bool>> expression)
        {
            using(var context = new RoboCargosContext()){

                 return expression==null? context.Set<Cargo>().ToList():context.Set<Cargo>().Where(expression).ToList();

            }
        }
    }
}
