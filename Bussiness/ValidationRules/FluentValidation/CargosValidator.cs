using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.ValidationRules.FluentValidation
{
    public class CargosValidator:AbstractValidator<Cargo>
    {

        public CargosValidator()
        {

            RuleFor(p => p.LojistikBirimKodu).NotNull();
            RuleFor(p => p.LojistikBirimAd).NotEmpty().MinimumLength(4);
            RuleFor(p => p.LojistikOpTipi).NotEmpty().MinimumLength(4);
            RuleFor(p => p.SipariNo).NotNull().GreaterThan(9);
            
        }



        private bool LengthControl (string arg) { 
        

            if (arg.Length >= 4)
            {
                return true;
            }
            return false;
        }
    }
}
