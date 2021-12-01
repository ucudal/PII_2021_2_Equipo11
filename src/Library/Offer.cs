using System;
<<<<<<< HEAD
=======
using System.Collections.Generic; 
using System.Text.Json;
using System.Text.Json.Serialization;

>>>>>>> 040d356b4b673955a51b989a19df9f5d02b0514e
namespace Telegram 
{

    /// <summary>
    /// Clase que se encarga de controlar las ofertas.
    /// </summary>
    public class Offer : IJsonConvertibl
    {
<<<<<<< HEAD
        public Offer (Ratings ratings, Category category, string type, string prodname, int prodquantity, Units produnit, string proddirection, int prodprice )
=======
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
        /// Establece o obtiene el lugar donde se encuentra la oferta.
        /// </summary>
        /// <value></value>
        public string Location { get; set; }

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
        public bool Status { get; set; }
        
        /// <summary>
        /// Obtiene o establece el dueño de la ofterta.
        /// </summary>
        /// <value></value>
        public Emprendedores Owner { get; set; }
        [JsonConstructor]
        public Offer(){}
        /// <summary>
        /// Constructor de objetos de tipo oferta.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="categories"></param>
        /// <param name="type"></param>
        /// <param name="productname"></param>
        /// <param name="productquantity"></param>
        /// <param name="productunit"></param>
        /// <param name="productprice"></param>
        public Offer (string location, string type, string productname, Units productunit, int productquantity,string productprice, Category categories)
>>>>>>> 040d356b4b673955a51b989a19df9f5d02b0514e
        {
            Catalogo catalogo= Catalogo.Instance;
            this.Type = type;
<<<<<<< HEAD
            this.Status = true;
            Materials product = new Materials(prodname,prodquantity,produnit,proddirection,prodprice);
            this.Product = product;

        }
        public Ratings Ratings { get; set; }
        public bool Recurrent { get; set; } = false;
=======
            Materials product = new Materials(productname,productquantity,productunit,productprice,categories);
            this.Product = product;
            catalogo.AllOffers.Add(this);
            this.Location=location;
        }
        public string ConvertToJson()
        {
            JsonSerializerOptions options = new()
            {
                ReferenceHandler = MyReferenceHandler.Instance,
                WriteIndented = true
            };
            return JsonSerializer.Serialize(this, options);
        }

>>>>>>> 040d356b4b673955a51b989a19df9f5d02b0514e

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
        /// Metodo que añade habilitaciones a la empresa.
        /// </summary>
        /// <param name="ratings"></param>
        public void AddRatings(Ratings ratings)
        {
            Ratings.Add(ratings);
        }


<<<<<<< HEAD
        public string Type { get; set; }

        public bool Status { get; set; }

        public Emprendedores Owner{ get; set; }

        public Materials Product { get; set; }
        public string printOffer()
            {
                return $"El {this.Product.Name} y $ {this.Type}";
            }

        public string printOfferCompleta()
            {
                return $"El producto {this.Product.Name} del que se dispone la cantidad {this.Product.Quantity} en {this.Product.Unit} unidades y precio {this.Product.Price}, con el proveedor de dirección {this.Product.Direction}. Tiene el dato {this.Ratings} y es una oferta {this.Recurrent}. Pertenece a la categoría {this.Category.Name}, {this.Category.Description} y {this.Type}. Con {this.Status} statis. del proveedor {this.Emprendedores.Name} y {this.Emprendedores.Location} dirección, que se desempeña en el rubro {this.Emprendedores.Rubro}";
            }   
        }
=======
>>>>>>> 040d356b4b673955a51b989a19df9f5d02b0514e
    }
}