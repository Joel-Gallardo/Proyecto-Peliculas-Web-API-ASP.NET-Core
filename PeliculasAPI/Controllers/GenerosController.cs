using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using PeliculasAPI.Entidades;
using PeliculasAPI.Filtros;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace PeliculasAPI.Controllers
{
    [Route("api/generos")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class GenerosController : ControllerBase
    {
        private readonly ILogger<GenerosController> logger;

        public GenerosController(ILogger<GenerosController> logger)
        {
            this.logger = logger;
        }

        [HttpGet()] // api/generos
        public ActionResult<List<Genero>> GetLista()
        {
            return new List<Genero>() { new Genero() { Id = 1, Nombre = "Comedia" } };
        }

        [HttpGet("{id:int}")] 
        public async Task<ActionResult<Genero>> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Post([FromBody] Genero genero) 
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Genero genero) 
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            throw new NotImplementedException();
        }

    }
}
