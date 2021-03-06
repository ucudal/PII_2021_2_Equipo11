using System;
using System.Collections.Generic;

namespace Telegram
{
    /// <summary>
    /// Clase encargada de buscar Materiales a travez de sus clasificaciones, esta clase utiliza el patrón singleton, esta clase es la encargada de gestionar todos los procesos de busqueda, por lo tanto una sola instancia de ella es necesaria.
    /// Esta clase cumple con SRP, su unica responsabilidad es buscar ofertas entre las listas.
    /// </summary>
        public class Search
    {
        private static Search search;
        private Search(){}
        /// <summary>
        /// Inicializa la clase Search a travez de un singleton para que solo exista una instancia del catalogo ya que usaremos un catalogo para todas las ofertas.
        /// </summary>
        /// <returns></returns>
        public static Search Instance
        {
            get
            {
                if (search == null)
                {
                    search = new Search();
                }

                return search;
            }
        }
         /// <summary>
        /// Metodo para buscar en el catalogo por categoria.
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public  List<Offer> SearchxCategory(Category category)
        {
            List<Offer> results = new List<Offer>();
            foreach (Offer offer in Catalogo.Instance.AllOffers)
            {
                   if(category.Name == offer.Product.Categories.Name) {
                       results.Add(offer);
                   }
               
            }
            return results;
        }
        /// <summary>
        /// Metodo para buscar en el catalogo por habilitacion.
        /// </summary>
        /// <param name="ratings"></param>
        /// <returns></returns>
        public  List<Offer> SearchxRatings(Ratings ratings)
        {   
            List<Offer> results = new List<Offer>();
            foreach (Offer offer in Catalogo.Instance.AllOffers)
            {
               foreach(Ratings habilitaciones in offer.Ratings) {
                   if(ratings.Name == habilitaciones.Name) {
                       results.Add(offer);
                   }
               }
            }      
            return results;
        }
        /// <summary>
        /// Metodo para buscar en el catalogo con el nombre del material.
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public List<Offer> SearchxMaterial(string Name)
        {   
            List<Offer> results = new List<Offer>();
            foreach (Offer offer in Catalogo.Instance.AllOffers)
            {
                   if(Name == offer.Product.Name) 
                   {
                       results.Add(offer);
                   }
            }      
            return results;
        }
    }
}