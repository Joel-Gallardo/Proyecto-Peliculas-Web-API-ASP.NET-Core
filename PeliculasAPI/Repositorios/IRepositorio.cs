using PeliculasAPI.Entidades;
using System.Collections.Generic;

namespace PeliculasAPI.Repositorios
{
    public interface IRepositorio
    {
        Genero ObtenerPorId(int id);
        public List<Genero> obtenerTodosLosGeneros();
    }
}
