using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Library;
using Telegram.Bot.Types.Enums;
using System.IO;
using System.Text;
using System.Collections.ObjectModel;

namespace Telegram
{
    /// <summary>
    /// Un "handler" del patrón Chain of Responsibility que utiliza el comando /start, este handler es una variacion del StartHandler dedicada a Emprendedor.
    /// Esta clase aplica polimorfismo, responde al comando "/start" solamente si el usuario es de tipo emprendedor.
    /// </summary>
    public class StartEmprendedorHandler : BaseHandler
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="StartHandler"/>. Esta clase procesa el mensaje /start.
        /// </summary>
        /// <param name="next">El próximo "handler".</param>
        public StartEmprendedorHandler(BaseHandler next) : base(next)
        {
            this.Keywords = new string[] { "/start" };
        }

        /// <summary>
        /// Procesa el mensaje "/start" y retorna true; retorna false en caso contrario.
        /// </summary>
        /// <param name="message">El mensaje a procesar.</param>
        /// <param name="response">La respuesta al mensaje procesado.</param>
        /// <returns>true si el mensaje fue procesado; false en caso contrario.</returns>
        protected override bool InternalHandle(IMessege message, out string response)
        {

            if (message.Mensaje.ToLower().Equals("/start") && Listas.Instance.EmprendedoresKey.ContainsKey(message.IdUser))
            {
                if (!Listas.Instance.HistorialUser.ContainsKey(message.IdUser))
                {
                    Listas.Instance.Accion(message.IdUser);
                }
                StringBuilder MensajeCompleto = new StringBuilder("Bot realizado por el equipo numero 11 de Programacion II\n");


                        MensajeCompleto.Append($"Bienvenido {Listas.Instance.EmprendedoresKey[message.IdUser].Name}\n Ingrese la función que desee utilizar...  \n");
                        MensajeCompleto.Append($"Si desea buscar entre las ofertas disponibles ingrese: \n");
                        MensajeCompleto.Append($"/buscaroferta \n");
                        MensajeCompleto.Append($"Si desea agregar habilitaciones a su usuario ingrese: \n");
                        MensajeCompleto.Append($"/agregarhabilitacion \n");
                        MensajeCompleto.Append($"Si desea ver las compras realizadas ingrese \n");
                        MensajeCompleto.Append($"/historialcompra \n");
                        MensajeCompleto.Append($"Si en cualquier momento lo desea puede usar: \n");
                        MensajeCompleto.Append($"/cancelar \n");
                        MensajeCompleto.Append($"Para cancelar cualquier acción \n");

                        response = MensajeCompleto.ToString();
                        return true;
            }
            response = string.Empty;
            return false;
        }
    }
}