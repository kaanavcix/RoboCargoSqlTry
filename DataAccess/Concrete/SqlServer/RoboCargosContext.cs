using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.SqlServer
{
    public class RoboCargosContext:DbContext
    {



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { optionsBuilder.UseSqlServer(@"Server=KAAN-LAPTOP\ROBOCARGOSQL;Database=robocargosql;User Id=sa;Password=test@123"); }
        

        public DbSet<Cargo> Cargos { get; set; }
       
    }
}
