using Resistencias.Domain;
using Resistencias.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Resistencias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {

        [HttpGet]
        public IActionResult ObtenerResistenciaa(Resistenciass oResistenciass)
        {
            var srv = new Colores();
            var resultado = srv.CalcularResistencia(oResistenciass.bandita1,
                oResistenciass.bandita2,
                oResistenciass.bandita3,
                oResistenciass.bandita4);

            return Ok(resultado);
        }
    }
}
