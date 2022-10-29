using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ICargosService
    {

        IDataResult<List<Cargo>> GetAllCargosInfo();
        IDataResult<Cargo> GetCargosInfoByOrder(int OrderId);
        IResult AddCargos(Cargo cargos);
        IResult UpdateCargos(Cargo cargos);
        IResult DeleteCargos(Cargo cargos);


        
    }
}
