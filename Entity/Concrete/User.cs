using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class User:IEntity
    {
        public int UserCredential { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
