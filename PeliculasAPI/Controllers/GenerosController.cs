using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using PeliculasAPI.Entidades;
using PeliculasAPI.Repositorios;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace PeliculasAPI.Controllers
{
    [Route("api/generos")]
    [ApiController]
    public class GenerosController : ControllerBase
    {
        private readonly IRepositorio repositorio;
        private readonly ILogger<GenerosController> logger;

        public GenerosController(IRepositorio repositorio, ILogger<GenerosController> logger)
        {
            this.repositorio = repositorio;
            this.logger = logger;
        }

        [HttpGet()] // api/generos
        [HttpGet("listado")] // api/generos/listado
        [HttpGet("/listadogeneros")] // /listadogeneros
        public ActionResult<List<Genero>> GetGeneros()
        {
            logger.LogInformation("vamos a mostrar los generos");
            return repositorio.obtenerTodosLosGeneros();
        }

        [HttpGet("{id:int}")] //  api/generos/2
        public async Task<ActionResult<Genero>> Get(int Id, [FromHeader] string nombre)
        {
            logger.LogDebug($"Obteniendo un genero por el id {Id}");
            var genero = await repositorio.ObtenerPorId(Id);

            if (genero == null)
            {
                logger.LogWarning($"No pudimos encontrar el genero de id {Id}");
                return NotFound();
            }

            return genero;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Genero genero) 
        {
            return NoContent();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Genero genero) 
        {
            return NoContent();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return NoContent();
        }

    }
}
