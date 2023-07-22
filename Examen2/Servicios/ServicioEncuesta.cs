using Examen2.Models;

namespace Examen2.Servicios
{
    public class ServicioEncuesta: IServicioEncuesta
    {
        
        string puntuacion;

        
        public string Puntuacion(EncuestaViewModel modelo)
        {
            int totalPuntos = modelo.Pregunta1 + modelo.Pregunta2 + modelo.Pregunta3 + modelo.Pregunta4
                + modelo.Pregunta5 + modelo.Pregunta6 + modelo.Pregunta7 + modelo.Pregunta8 + modelo.Pregunta9
                + modelo.Pregunta10 + modelo.Pregunta11 + modelo.Pregunta12 + modelo.Pregunta13 + modelo.Pregunta14
                + modelo.Pregunta15 + modelo.Pregunta16 + modelo.Pregunta17 + modelo.Pregunta18 + modelo.Pregunta19
                + modelo.Pregunta20 + modelo.Pregunta21 + modelo.Pregunta22 + modelo.Pregunta23 + modelo.Pregunta24
                + modelo.Pregunta25 + modelo.Pregunta26 + modelo.Pregunta27 + modelo.Pregunta28 + modelo.Pregunta29 + modelo.Pregunta30;

            if (totalPuntos >= 120 && totalPuntos <= 150)
            {
                puntuacion = "Área de Ciencias y Tecnología";
                return puntuacion;
            }
            else if (totalPuntos >= 90 && totalPuntos <= 119)
            {
                puntuacion = "Área de Humanidades y Artes";
                return puntuacion;
            }
            else if (totalPuntos >= 60 && totalPuntos <= 89)
            {
                puntuacion = "Área de Ciencias Sociales y Comunicación";
                return puntuacion;
            }
            else if (totalPuntos >= 30 && totalPuntos <= 59)
            {
                puntuacion = "Área de Salud y Bienestar";
                return puntuacion;
            }
            else if (totalPuntos >= 0 && totalPuntos <= 29)
            {
                puntuacion = "Área de Negocios y Economía";
                return puntuacion;
            }
            else
            {
                puntuacion = "Puntuación inválida";
                return puntuacion;
            }
            
        }

    }
}
