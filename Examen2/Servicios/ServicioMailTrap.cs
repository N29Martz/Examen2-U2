using MailKit.Net.Smtp;
using MimeKit;
using Examen2.Models;

namespace Examen2.Servicios
{
    public class ServicioMailTrap: IServiciosEmail
    {
        public async Task Enviar(ResultadosViewModel model, string puntuacion)
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(model.Nombre, model.Email));
            email.To.Add(new MailboxAddress("", "")); 

            email.Subject = $"Contacto de: {model.Nombre}";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                
                Text = $"<p>Puntuación: {puntuacion}</p>"
            };

            using (var smtp = new SmtpClient())
            {
                smtp.Connect("sandbox.smtp.mailtrap.io", 587, false);
                smtp.Authenticate("", "");

                await smtp.SendAsync(email);
                await smtp.DisconnectAsync(true);
            }
        }
    }
}
