using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Telegram
{
    /// <summary>
    /// Clase encargada de manejar los emprendedores, hereda de User.
    /// Esta clase cumple con OCP, es facil de extender mediante la clase abstracta User.
    /// Esta clase cumple con Expert, tiene todos los datos que requiere para cumplir sus funcionalidades.
    /// Esta clase cumple con SRP, su unica responsabilidad es conocerse a si mismo.
    /// </summary>
    public class Emprendedores : User
    {
        /// <summary>
        /// Lista de habilitaciones que tiene el emprendedor.
        /// </summary>
        /// <returns></returns>
        public List<Ratings> Listratings = new List<Ratings>();
        
        /// <summary>
        /// Lista de compras realizadas por el emprendedor.
        /// </summary>
        /// <returns></returns>
        public List<Offer> Purchased = new List<Offer>();
       
        /// <summary>
        /// Constructor de objetos de tipo Emprendedor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="location"></param>
        /// <param name="rubro"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public Emprendedores(string name, string location, Rubro rubro, string id ) : base (name, location, rubro, id)
        {
            Listas.Instance.Listemprendedores.Add(this);
            Listas.Instance.EmprendedoresKey.Add(id,this);
            
        }

        /// <summary>
        /// Metodo para añadir habilitaciones a un emprendedor.
        /// </summary>
        /// <param name="rating"></param>
        public void AddRatings(Ratings rating){
         
            Listratings.Add(rating);
        }
        /// <summary>
        /// Metodo encargado de efectuar la compra de parte del emprendedor.
        /// </summary>
        /// <param name="Offer"></param>
    }
}