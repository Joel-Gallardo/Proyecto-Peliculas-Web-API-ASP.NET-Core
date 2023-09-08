using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace PeliculasAPI.Filtros
{
    //creando un filtro personalizado este es un filtro de accion que se ejecuta antes y despues de una accion
    //al utilizarlo en el endpoint primero entra el metodo OnActionExecuting, despues al metodo del endpoint y al final al metodo OnActionExecuted
    public class MiFiltroDeAccion : IActionFilter
    {
        private readonly ILogger<MiFiltroDeAccion> logger;

        public MiFiltroDeAccion(ILogger<MiFiltroDeAccion> logger)
        {
            this.logger = logger;
        }


        public void OnActionExecuting(ActionExecutingContext context)
        {
            logger.LogInformation("Antes de ejecutar la acción");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            logger.LogInformation("Despues de ejecutar la acción");
        }


    }
}
