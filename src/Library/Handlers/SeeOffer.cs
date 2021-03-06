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
    public class SeeOfferHandler : BaseHandler
    {
         private TelegramBotClient bot;
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="StartHandler"/>. Esta clase procesa el mensaje "hola".
        /// </summary>
        /// <param name="next">El próximo "handler".</param>
        public SeeOfferHandler(BaseHandler next) : base(next)
        {
            this.Keywords = new string[] {"/veroferta"};
        }

        /// <summary>
        /// Procesa el mensaje "hola" y retorna true; retorna false en caso contrario.
        /// </summary>
        /// <param name="message">El mensaje a procesar.</param>
        /// <param name="response">La respuesta al mensaje procesado.</param>
        /// <returns>true si el mensaje fue procesado; false en caso contrario.</returns>
        protected override bool InternalHandle(IMessege message, out string response)
        {
            
            if (Listas.Instance.HistorialUser[message.IdUser].Contains("/todaslasofertas") && Listas.Instance.HistorialUser[message.IdUser].Count==2)
            {   
                Listas.Instance.HistorialUser[message.IdUser].Add(message.Mensaje);
                string oferta=message.Mensaje.Replace("/",string.Empty);
                int offer = Int32.Parse(oferta)-1;
                
                Offer offer1=Catalogo.Instance.AllOffers[offer];
        
                StringBuilder MensajeCompleto = new StringBuilder($"{Armadordemensajes.Instance.Veroferta(offer1)}\n");
                MensajeCompleto.Append("/VerUbicacion\n");
                MensajeCompleto.Append("/Compraroferta");

                
               
                response = MensajeCompleto.ToString();
                return true;

            }
            if (Listas.Instance.HistorialUser[message.IdUser].Contains("/ofertasxcategoria") && Listas.Instance.HistorialUser[message.IdUser].Count==3)
            {   
                Listas.Instance.HistorialUser[message.IdUser].Add(message.Mensaje);
                string oferta=message.Mensaje.Replace("/",string.Empty);
                int offer = Int32.Parse(oferta)-1;
                
                Offer offer1=Listas.Instance.Resultados[message.IdUser][offer];
        
                StringBuilder MensajeCompleto = new StringBuilder($"{Armadordemensajes.Instance.Veroferta(offer1)}\n");
                MensajeCompleto.Append("/VerUbicacion\n");
                MensajeCompleto.Append("/Compraroferta");

                
               
                response = MensajeCompleto.ToString();
                return true;

            }
            
            Console.WriteLine("Ver oferta");
            response = string.Empty;
            return false;
        }
      
        }
    }
