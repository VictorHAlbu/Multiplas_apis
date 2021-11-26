using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UsuarioAPI.Controllers
{
    [ApiController]
    [Route("/")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public dynamic Get()
        {
            return new{
                Mensagem = "Bem vindo a api 21 Dias Multiplas"
            };
            
        }
    }
}
