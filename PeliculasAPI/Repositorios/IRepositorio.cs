using PeliculasAPI.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeliculasAPI.Repositorios
{
    public interface IRepositorio
    {
        Task<Genero> ObtenerPorId(int id);
        List<Genero> obtenerTodosLosGeneros();
    }
}
