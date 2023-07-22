using Examen2.Models;

namespace Examen2.Servicios
{
    public interface IServiciosEmail
    {
        Task Enviar(ResultadosViewModel model, string puntuacion);
    }
}
