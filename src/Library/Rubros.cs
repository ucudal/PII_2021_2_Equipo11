using System;
using System.Collections.Generic;

namespace Telegram
{
    /// <summary>
    /// Clase encargada de crear y obtener los distintos rubros disponibles.
    /// </summary>
    public class Rubro
    {
        
        /// <summary>
        /// String que obtiene o establece la descripción de un rubro.
        /// </summary>
        /// <value></value>
        public string Description{get;set;}
        /// <summary>
        /// String que obtiene o establece el nombre de un rubro.
        /// </summary>
        /// <value></value>
        public string Name{get;set;}
        /// <summary>
        /// Constructor de rubros.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="name"></param>
        public Rubro(string description, string name)
        {
            this.Description = description;
            this.Name = name;
            Listas.Instance.listrubro.Add(this);
        }
        /// <summary>
        /// Añade rubros nuevos a la lista de rubros.
        /// </summary>
         public static void Deleterubro(Rubro rubro)
        {
            Listas.Instance.listrubro.Remove(rubro);
        }
    }
}

