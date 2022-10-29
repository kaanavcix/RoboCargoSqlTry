using Core.DataAccess;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstarct
{
    public interface ICargosDal:IEntityRepositoryDal<Cargo>
    {
        List<Cargo> GetAllByLogisticUnits(Expression<Func<Cargo,bool>> expression);
       
    }
}
