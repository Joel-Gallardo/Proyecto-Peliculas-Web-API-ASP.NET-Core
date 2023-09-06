using PeliculasAPI.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace PeliculasAPI.Repositorios
{
    public class RepositorioEnMemoria: IRepositorio
    {

        private List<Genero> _generos;

        public RepositorioEnMemoria()
        {

            _generos = new List<Genero>()
            {
                new Genero() {Id = 1, Nombre="Comedia"},
                new Genero() {Id = 2, Nombre="Accion"}
            };
        }

        public List<Genero> obtenerTodosLosGeneros()
        {
            return _generos;
        }

        public Genero ObtenerPorId(int id)
        {
            return _generos.FirstOrDefault(x => x.Id == id);
        }

    }
}
