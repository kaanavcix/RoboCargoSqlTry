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
    public class CargosService : ICargosService


    {


        private ICargosDal _cargosDal;

        public CargosService(ICargosDal cargosDal)
        {
            _cargosDal = cargosDal;
        }

        [ValidationAspect(typeof(CargosValidator))]
        public IResult AddCargos(Cargo cargos)
        {

            _cargosDal.Add(cargos);
            return new SuccessResult(SuccessMessages.sucessMessageForAdd);
            
        }

        public IResult DeleteCargos(Cargo cargos)
        {

            _cargosDal.Delete(cargos);

            return new SuccessResult(SuccessMessages.sucessMessageForDelete);
        }

        public IDataResult<List<Cargo>> GetAllCargosInfo()
        {

            
           var result =  _cargosDal.GetAll(null) ;

           
                return new DataResult<List<Cargo>>(result, SuccessMessages.sucessMessageForGet, true);

            

        }

        public IDataResult<Cargo> GetCargosInfoByOrder(int OrderId)
        {


          var data =   _cargosDal.GetAllByLogisticUnits(p => p.SipariNo == OrderId).FirstOrDefault();

            return new DataResult<Cargo>(data,SuccessMessages.sucessMessageForGet,true);
        }

        public IResult UpdateCargos(Cargo cargos)
        {
            _cargosDal.Update(cargos);

            return new SuccessResult(SuccessMessages.sucessMessageForUpdate);
        }

       
    }
}
