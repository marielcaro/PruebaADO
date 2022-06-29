
using Microsoft.AspNetCore.Mvc;
using Layer.Entity;
using Layer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Layer.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PruebaController: ControllerBase
    {
        [HttpGet("Listar")]
        public List<PruebaEntity> Index()
        {
            PruebaDomain oPruebaDomain = new PruebaDomain();
            return oPruebaDomain.Listar(); ;
        }
    }
}
