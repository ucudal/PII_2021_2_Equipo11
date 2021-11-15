using System;
using System.Collections.Generic; 

namespace Telegram 
{

    /// <summary>
    /// Clase que se encarga de controlar las ofertas.
    /// </summary>
    public class Offer 
    {

        /// <summary>
        /// Lista que contiene las categorias de la oferta.
        /// </summary>
        /// <returns></returns>
        public List<Category> Categories = new List<Category>();

        /// <summary>
        /// Lista que contiene las habilitaciones de la oferta.
        /// </summary>
        /// <returns></returns>
        public List<Ratings> Ratings = new List<Ratings>();

        /// <summary>
        /// Atributo que determina si la oferta es recurrente o no, obtiene y establece el valor.
        /// </summary>
        /// <value></value>
        public bool Recurrent { get; set; } = false;

        /// <summary>
        /// Establece o obtiene el tipo de la oferta, que puede ser residuo o material.
        /// </summary>
        /// <value></value>
        public string Type { get; set; }

        /// <summary>
        /// Obtiene y establece el material ofrecido en la oferta.
        /// </summary>
        /// <value></value>
        public Materials Product { get; set; }

        /// <summary>
        /// Obtiene o establece el atributo que determina si la oferta esta disponible o no.
        /// </summary>
        /// <value></value>
        public bool status { get; set; }
        
        /// <summary>
        /// Obtiene o establece el dueño de la ofterta.
        /// </summary>
        /// <value></value>
        public Emprendedores Owner { get; set; }
        
        /// <summary>
        /// Constructor de objetos de tipo oferta.
        /// </summary>
        /// <param name="rating"></param>
        /// <param name="categories"></param>
        /// <param name="type"></param>
        /// <param name="productname"></param>
        /// <param name="productquantity"></param>
        /// <param name="productunit"></param>
        /// <param name="productdirection"></param>
        /// <param name="productprice"></param>
        public Offer (Ratings rating, Category categories, string type, string productname, int productquantity, Units productunit, string productdirection,int productprice )
        {
            this.Type = type;
            Materials product = new Materials(productname,productquantity,productunit,productdirection,productprice);
            this.Product = product;
            Catalogo.Instance.allOffers.Add(this);
            Ratings.Add(rating);
            Categories.Add(categories);
        }
        /// <summary>
        /// Metodo que imprime las categorias de la oferta.
        /// </summary>
        /// <returns></returns>
        public string PrintCategories()
        {   
            string categorias = string.Empty;
            foreach (Category cate in this.Categories)
            {
               categorias = categorias + $"{cate.Name} ,";
            }
            return categorias;

        }
        /// <summary>
        /// Metodo que imprime las habilitaciones de la empresa.
        /// </summary>
        /// <returns></returns>
         public string PrintRatings()
         {  
            string habilitaciones = string.Empty;
            foreach (Ratings rat in this.Ratings)
            {
               habilitaciones = habilitaciones + $"{rat.Name} ,";
            }
            return habilitaciones;
        }

        /// <summary>
        /// Metodo que añade categorias a la oferta.
        /// </summary>
        /// <param name="category"></param>
        public void AddCategories(Category category)
        {
            Categories.Add(category);
        }

        /// <summary>
        /// Metodo que añade habilitaciones a la empresa.
        /// </summary>
        /// <param name="ratings"></param>
        public void AddRatings(Ratings ratings)
        {
            Ratings.Add(ratings);
        }


    }
}