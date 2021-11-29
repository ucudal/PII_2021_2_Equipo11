using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Telegram{
    /// <summary>
    /// Clase encargada de guardar todas las listas independientes de otras clases con las cuales no interactuan directamente con los usuarios.
    /// </summary>
    public class Listas
    {
        private static Listas listas;
        private Listas(){}
        /// <summary>
        /// Singleton para que solo exista una instancia de las listas.
        /// </summary>
        public static Listas Instance
        {
            get
            {
                if (listas == null)
                {
                    listas = new Listas();
                }

                return listas;
            }
        }
    public Dictionary<string,bool> TokenVerified = new Dictionary<string,bool>();
     public void VerifyToken(string ID, bool tokenstatus){
        
        this.TokenVerified.Add(ID, tokenstatus);

    }
    
    /// <summary>
    /// Lista que contiene todas las categorias disponibles.
    /// </summary>
    /// <returns></returns>
    public List<Category> Listcategory = new List<Category>();

    /// <summary>
    /// Lista que contiene todas las habilitaciones disponibles.
    /// </summary>
    /// <returns></returns>
    public List<Ratings> Listratings = new List<Ratings>();
    /// <summary>
    /// Lista que almacena todos los rubros disponibles.
    /// </summary>
    /// <returns></returns>
    public  List<Rubro> Listrubro= new List<Rubro>();

    /// <summary>
    /// Lista que contiene todas las unidades disponibles para usar.
    /// </summary>
    /// <returns></returns>
    public List<Units> Listunit = new List<Units>();
    /// <summary>
    /// Lista que contiene todas las unidades disponibles para usar.
    /// </summary>
    /// <returns></returns>
    public List<Business> Listbussiness = new List<Business>();
    /// <summary>
    /// Lista que contiene todas las unidades disponibles para usar.
    /// </summary>
    /// <returns></returns>
    public List<Emprendedores> Listemprendedores = new List<Emprendedores>();
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<IUser> Listuser = new List<IUser>();

    /// <summary>
    /// Lista que contiene todas las unidades disponibles para usar.
    /// </summary>
    /// <returns></returns>
    public List<string> Listtokens = new List<string>();

    public List<string> PossibleRatings = new List<string>();
    /// <summary>
    /// Diccionario encargado de guardar las interacciones de los usuarios con el bot.
    /// </summary>
    /// <returns></returns>
    public Dictionary<string, Collection<string>> HistorialUser = new Dictionary<string, Collection<string>>();
    /// <summary>
    /// Metodo para agregar el id de los usuarios.
    /// </summary>
    /// <param name="ID"></param>
    
    public Dictionary<string,Collection<int>> Utilities = new Dictionary<string,Collection<int>>();

    public Dictionary<string, Emprendedores> EmprendedoresKey = new Dictionary<string, Emprendedores>();

    public Dictionary<string, Business> BusinessKey = new Dictionary<string, Business>();
    //public Dictionary<string, Admin> AdminKey = new Dictionary<string, Admin>();
    public void Accion(string ID){
        
        this.HistorialUser.Add(ID,new Collection<string>());

    }
    public void CrearUtilities(string ID){
        
        this.Utilities.Add(ID,new Collection<int>());

    }
    public List<string> BusinessID = new List<string>();
    /// <summary>
    /// Metodo encargado de guardar toda la informacion almacenada en Listas. En los json correspondientes a cada sub-lista.
    /// </summary>
    public void Guardarlistas()
    {
        Serializarbussiness();
        Serializaremprendedores();
        Serializarrubros();
        Serializarratings();
        Serializartokens();
        Serializaruser();
        Serializarunit();
        Serializarcategory();
    }
    private void Serializarbussiness()
    {
        string json = JsonSerializer.Serialize<List<Business>>(listas.Listbussiness);
        /*Console.WriteLine(json);*/
        System.IO.File.WriteAllText(@"Empresas.json", json);
    }
    private void Serializaremprendedores()
    {
        string json = JsonSerializer.Serialize<List<Emprendedores>>(listas.Listemprendedores);
        /*Console.WriteLine(json);*/
        System.IO.File.WriteAllText(@"Emprendedores.json", json);
    }
    private void Serializarrubros()
    {
        string json = JsonSerializer.Serialize<List<Rubro>>(listas.Listrubro);
        /*Console.WriteLine(json);*/
        System.IO.File.WriteAllText(@"Rubros.json", json);
    }
    private void Serializarratings()
    {
        string json = JsonSerializer.Serialize<List<Ratings>>(listas.Listratings);
        /*Console.WriteLine(json);*/
        System.IO.File.WriteAllText(@"Habilitaciones.json", json);
    }
    private void Serializartokens()
    {
        string json = JsonSerializer.Serialize<List<string>>(listas.Listtokens);
        /*Console.WriteLine(json);*/
        System.IO.File.WriteAllText(@"Tokens.json", json);
    }
    private void Serializaruser()
    {
        string json = JsonSerializer.Serialize<List<IUser>>(listas.Listuser);
        /*Console.WriteLine(json);*/
        System.IO.File.WriteAllText(@"Usuarios.json", json);
    }
    /// <returns></returns>
    

    private void Serializarunit()
    {
        string json = JsonSerializer.Serialize<List<Units>>(listas.Listunit);
        /*Console.WriteLine(json);*/
        System.IO.File.WriteAllText(@"Unidades.json", json);
    }
    private void Serializarcategory()
    {
        string json = JsonSerializer.Serialize<List<Category>>(listas.Listcategory);
        /*Console.WriteLine(json);*/
        System.IO.File.WriteAllText(@"Categorias.json", json);
    }
    /// <summary>
    /// Metodo encargado de incorporar toda la informacion existente al finalizar la sesión anterior. En los json correspondientes a cada sub-lista.
    /// </summary>
    public void Cargarlistas()
    {
        
        Deserializarrubros();
        Deserializarratings();
        Deserializartokens();
        Deserializaruser();
        Deserializarunit();
        Deserializarcategory();
        Deserializarbussiness();
        Deserializaremprendedores();
    }
        private void Deserializarbussiness()
    {
        if (System.IO.File.Exists(@"Empresas.json"))
        {
            string json = System.IO.File.ReadAllText(@"Empresas.json");
            List<Business> listavieja= JsonSerializer.Deserialize<List<Business>>(json);
        
        }
    }
    private void Deserializaremprendedores()
    {
        if (System.IO.File.Exists(@"Emprendedores.json"))
        {
            string json = System.IO.File.ReadAllText(@"Emprendedores.json");
            List<Emprendedores> listavieja= JsonSerializer.Deserialize<List<Emprendedores>>(json);
         
        }
    }
    private void Deserializarrubros()
    {
        if (System.IO.File.Exists(@"Rubros.json"))
        {
            string json = System.IO.File.ReadAllText(@"Rubros.json");
            List<Rubro> listavieja= JsonSerializer.Deserialize<List<Rubro>>(json);
       
        }
    }
    private void Deserializarratings()
    {
        if (System.IO.File.Exists(@"Habilitaciones.json"))
        {
            string json = System.IO.File.ReadAllText(@"Habilitaciones.json");
            List<Ratings> listavieja= JsonSerializer.Deserialize<List<Ratings>>(json);
        
        }
    }
    private void Deserializartokens()
    {
        if (System.IO.File.Exists(@"Tokens.json"))
        {
            string json = System.IO.File.ReadAllText(@"Tokens.json");
            List<string> listavieja= JsonSerializer.Deserialize<List<string>>(json);
            foreach (string token in listavieja)
            {
            listas.Listtokens.Add(token);
            }
          
        }
    }
    private void Deserializaruser()
    {
        if (System.IO.File.Exists(@"User.json"))
        {
            string json = System.IO.File.ReadAllText(@"User.json");
            List<IUser> listavieja= JsonSerializer.Deserialize<List<IUser>>(json);
          
        }
    }
    private void Deserializarunit()
    {
        if (System.IO.File.Exists(@"Unidades.json"))
        {
            string json = System.IO.File.ReadAllText(@"Unidades.json");
            List<Units> listavieja= JsonSerializer.Deserialize<List<Units>>(json);
           
        }
    }
    private void Deserializarcategory()
    {
        if (System.IO.File.Exists(@"Categorias.json"))
        {
            string json = System.IO.File.ReadAllText(@"Categorias.json");
            List<Category> listavieja= JsonSerializer.Deserialize<List<Category>>(json);
           
        }
    }

}
}