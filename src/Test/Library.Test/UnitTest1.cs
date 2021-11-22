using NUnit.Framework;
using Telegram;
using System.Collections.Generic;

namespace Test
{
    [TestFixture]
    public class Tests
    {
<<<<<<< HEAD
        [Test1]
        public void TestTelegramGonza()
        {
            
=======
        [SetUp]
        public void Teardown()
        {
<<<<<<< HEAD
            Rubro rubro1 = new Rubro("Testing de programas", "Testing");
            Emprendedores emprendedor1 = new Emprendedores("Emprendedor","Emprendedorland",rubro1);
            Category categoria1 = new Category("S", "Testing");
            
=======
            Catalogo.Instance.AllOffers = new List<Offer>();
>>>>>>> 7bc541ebe80767f940e215d950692b6e324cdb25
>>>>>>> 4a6fd8d52ed99d4584da84e7e7fc944fab6ab0e8
        }

        [Test]
        public void Test1()
        {   
            Category Categoria = new Category("Materiales para reciclar","Materiales para reciclar");
            Ratings Habilitacion = new Ratings("Habilitacion para metales", "Metales");
            Units Toneladas = new Units("Toneladas");
            Offer Metal = new Offer(Habilitacion,Categoria,"Tipo", "Metal", 200, Toneladas, "dirección",2000);
            Assert.AreEqual(Categoria,Metal.Categories[0]);
        }
        [Test]
        public void Test2()
        {   
            Category Categoria = new Category("Materiales para reciclar","Materiales para reciclar");
            Ratings Habilitacion = new Ratings("Habilitacion para metales", "Metales");
            Units Toneladas = new Units("Toneladas");
            Offer Metal = new Offer(Habilitacion,Categoria,"Tipo", "Metal", 200, Toneladas, "dirección",2000);
            Assert.AreEqual(Habilitacion,Metal.Ratings[0]);
        }
        [Test]
        public void Test3()
        {   
            Category Categoria = new Category("Materiales para reciclar","Reciclar");
            Category BuenEstado = new Category("Materiales en muy buen estado","Buen estado");
            Ratings Habilitacion = new Ratings("Habilitacion para metales", "Metales");
            Units Toneladas = new Units("Toneladas");
            Offer Metal = new Offer(Habilitacion,Categoria,"Tipo", "Metal", 200, Toneladas, "dirección",2000);
            Metal.addCategories(BuenEstado);
            Assert.AreEqual(BuenEstado,Metal.Categories[1]);
        }
        [Test]
        public void Test4()
        {   
            Category Categoria = new Category("Materiales para reciclar","Reciclar");
            Ratings Habilitacion = new Ratings("Habilitacion para metales", "Metales");
            Ratings Higiene = new Ratings("Cuidado con las medidas necesarias contra el covid", "Higiene");
            Units Toneladas = new Units("Toneladas");
            Offer Metal = new Offer(Habilitacion,Categoria,"Tipo", "Metal", 200, Toneladas, "dirección",2000);
            Metal.addRatings(Higiene);
            Assert.AreEqual(Higiene,Metal.Ratings[1]);
        }
        [Test]
        public void Test5()
        {
            Rubro Metalurgia = new Rubro ("IndustriaPesada", "Metalurgia");
            Emprendedores EstrellaSA = new Emprendedores("EstrellaSA", "Montevideo", Metalurgia);
            Assert.AreEqual(Metalurgia,EstrellaSA.Rubro);
        }

        [Test]
        public void Test6()
        {
            Units Kilos = new Units("Kilos");
            Materials Madera= new Materials("Madera", 20, Kilos, "direction",400);
            Assert.AreEqual("K", Madera.Unit);
        }
        [Test]
        public void Test7()
        {
            Category Categoria = new Category("Materiales para reciclar","Reciclar");
            Ratings Metales = new Ratings("Habilitacion para metales", "Metales");
            Ratings Higiene = new Ratings("Cuidado con las medidas necesarias contra el covid", "Higiene");
            Units Toneladas = new Units("Toneladas");
            Offer Cuchillos = new Offer(Metales,Categoria,"Tipo", "Metal", 200, Toneladas, "dirección",2000);
            Offer Metal = new Offer(Metales,Categoria,"Tipo", "Metal", 200, Toneladas, "dirección",2000);
            Metal.addRatings(Higiene);
            Assert.AreEqual(Cuchillos,Catalogo.Instance.SearchxRatings(Metales)[0]);
        }
        [Test]
        public void Test8()
        {
            Category Categoria = new Category("Materiales para reciclar","Reciclar");
            Ratings Metales = new Ratings("Metales para metales", "Metales");
            Ratings Higiene = new Ratings("Cuidado con las medidas necesarias contra el covid", "Higiene");
            Units Toneladas = new Units("Toneladas");
            Offer Cuchillos = new Offer(Metales,Categoria,"Tipo", "Metal", 200, Toneladas, "dirección",2000);
            Offer Metal = new Offer(Metales,Categoria,"Tipo", "Metal", 200, Toneladas, "dirección",2000);
            Assert.AreEqual(null,Catalogo.Instance.SearchxRatings(Higiene)[0]);
        }
        [Test]
        public void Test9()
        {
            Category Categoria = new Category("Materiales para reciclar","Reciclar");
            Ratings Metales = new Ratings("Habilitacion para metales", "Metales");
            Ratings Higiene = new Ratings("Cuidado con las medidas necesarias contra el covid", "Higiene");
            Units Toneladas = new Units("Toneladas");
            Offer Cuchillos = new Offer(Metales,Categoria,"Tipo", "Metal", 200, Toneladas, "dirección",2000);
            Offer Metal = new Offer(Metales,Categoria,"Tipo", "Metal", 200, Toneladas, "dirección",2000);
            Metal.addRatings(Higiene);
            Assert.AreEqual(Metal,Catalogo.Instance.SearchxRatings(Higiene)[0]);
        }
        [Test]
        public void Test10()
        {
            Category Categoria = new Category("Materiales para reciclar","Reciclar");
            Ratings Metales = new Ratings("Habilitacion para metales", "Metales");
            Units Toneladas = new Units("Toneladas");
            Offer Cuchillos = new Offer(Metales,Categoria,"Tipo", "Metal", 200, Toneladas, "dirección",2000);
            Offer Metal = new Offer(Metales,Categoria,"Tipo", "Metal", 200, Toneladas, "dirección",2000);
            Assert.AreEqual(Metal,Catalogo.Instance.SearchxCategory(Categoria)[0]);
        }
    }
}