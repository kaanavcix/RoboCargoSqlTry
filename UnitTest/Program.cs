// See https://aka.ms/new-console-template for more information
using Bussiness.Abstract;
using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;

Console.WriteLine("Hello, World!");


ICargosService cargosService = new CargosService(new EfCargosDal());

var result = cargosService.GetAllCargosInfo();

foreach (var cargos in result.GetValue)
{
    Console.WriteLine(cargos.LojistikBirimAd);

}

