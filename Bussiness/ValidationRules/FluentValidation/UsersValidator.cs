using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.ValidationRules.FluentValidation
{
    public class UsersValidator:AbstractValidator<User>
    {
        public UsersValidator()
        {

            RuleFor(p => p.UserCredential).NotNull();
            RuleFor(p => p.Email.Length).LessThan(5);
            RuleFor(p => p.Password).NotNull();

        }
    }
}
