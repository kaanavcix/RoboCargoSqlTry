using Bussiness.Abstract;
using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargosController : ControllerBase
    {

        private ICargosService _cargosService = new CargosService(new EfCargosDal());


        [HttpGet("getall")]

        public IActionResult GetAll()
        {
            var result = _cargosService.GetAllCargosInfo();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyorderno")]

        public IActionResult GetByOrderNo(int OrderNo)
        {
            var result = _cargosService.GetCargosInfoByOrder(OrderNo);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("add")]

        public IActionResult Add(Cargo cargo)
        {
            var result = _cargosService.AddCargos(cargo);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();

        }

    }
}
