using System;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using System.IO;
using System.Text;
using Nito.AsyncEx;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types.InputFiles;

namespace Telegram
{
    /// <summary>
    /// Un "handler" del patrón Chain of Responsibility que implementa el comando "hola".
    /// </summary>
    public class PhotoRouteHandler : BaseHandler
    {
        private TelegramBotClient bot;
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="StartHandler"/>. Esta clase procesa el mensaje "hola".
        /// </summary>
        /// <param name="next">El próximo "handler".</param>
        public PhotoRouteHandler(BaseHandler next) : base(next)
        {
            this.Keywords = new string[] { "/TrazarRutaHaciaOferta" };
        }

        /// <summary>
        /// Procesa el mensaje "hola" y retorna true; retorna false en caso contrario.
        /// </summary>
        /// <param name="message">El mensaje a procesar.</param>
        /// <param name="response">La respuesta al mensaje procesado.</param>
        /// <returns>true si el mensaje fue procesado; false en caso contrario.</returns>
        protected override bool InternalHandle(IMessege message, out string response)
        {
            if (this.CanHandle(message))
            {
                if (Listas.Instance.HistorialUser[message.IdUser].Contains("/VerUbicacion") && Listas.Instance.HistorialUser[message.IdUser].Contains("/todaslasofertas") && Listas.Instance.HistorialUser[message.IdUser].Contains("/buscaroferta") && Listas.Instance.HistorialUser[message.IdUser].Count == 4)
                {

                    Listas.Instance.HistorialUser[message.IdUser].Add(message.Mensaje);

                    string oferta = Listas.Instance.HistorialUser[message.IdUser][2].Replace("/", string.Empty);
                    int offer = Int32.Parse(oferta) - 1;

                    foreach (Emprendedores item in Listas.Instance.Listemprendedores)
                    {
                        if (message.IdUser == item.ID)
                        {

                            APILocation.Instance.Route(Catalogo.Instance.AllOffers[offer], item);
                        }
                    }

                    AsyncContext.Run(() => message.SendPhoto("Usted se encuentra en el punto A y la oferta selecionada en el punto B", @"Ruta.png"));


                    StringBuilder MensajeCompleto = new StringBuilder("\n");

                    MensajeCompleto.Append("/cancelar");

                    response = MensajeCompleto.ToString();
                    return true;
                }
                if (Listas.Instance.HistorialUser[message.IdUser].Contains("/VerUbicacion") && Listas.Instance.HistorialUser[message.IdUser].Contains("/ofertasxcategoria") && Listas.Instance.HistorialUser[message.IdUser].Contains("/buscaroferta") && Listas.Instance.HistorialUser[message.IdUser].Count == 5)
                {

                    Listas.Instance.HistorialUser[message.IdUser].Add(message.Mensaje);
                    string oferta=Listas.Instance.HistorialUser[message.IdUser][3].Replace("/",string.Empty);
                    int offer = Int32.Parse(oferta)-1;
                
                    Offer offer1=Listas.Instance.Resultados[message.IdUser][offer];

                    foreach (Emprendedores item in Listas.Instance.Listemprendedores)
                    {
                        if (message.IdUser == item.ID)
                        {

                            APILocation.Instance.Route(Catalogo.Instance.AllOffers[offer], item);
                        }
                    }

                    AsyncContext.Run(() => message.SendPhoto("Usted se encuentra en el punto A y la oferta selecionada en el punto B", @"Ruta.png"));


                    StringBuilder MensajeCompleto = new StringBuilder("\n");

                    MensajeCompleto.Append("/cancelar");

                    response = MensajeCompleto.ToString();
                    return true;
                }
            }

            Console.WriteLine("Ver oferta");
            response = string.Empty;
            return false;
        }

    }
}


