using Microsoft.AspNetCore.Mvc;
using PeliculasAPI.Entidades;
using PeliculasAPI.Repositorios;
using System.Collections.Generic;

namespace PeliculasAPI.Controllers
{
    [Route("api/generos")]
    public class GenerosController: ControllerBase
    {
        private readonly IRepositorio repositorio;

        public GenerosController(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        [HttpGet()] // api/generos
        [HttpGet("listado")] // api/generos/listado
        [HttpGet("/listadogeneros")] // /listadogeneros
        public ActionResult<List<Genero>> GetGeneros()
        {
            return repositorio.obtenerTodosLosGeneros();
        }

        [HttpGet("{id:int}/{nombre=Joel}")] //  api/generos/2/Joel
        public ActionResult<Genero> GetById(int Id, string nombre)
        {
            var genero = repositorio.ObtenerPorId(Id);

            if (genero == null)
            {
                return NotFound();
            }
            
            return genero;
        }

        [HttpPost]
        public ActionResult Post() 
        {
            return NoContent();
        }

        [HttpPut]
        public ActionResult Put() 
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
