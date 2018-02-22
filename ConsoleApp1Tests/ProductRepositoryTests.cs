using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass]
    public class ProductRepositoryTests
    {
        [TestMethod]
        public void Test1part1()
        {
            // arrange  
            Product product1 = new Product("lettuce", 10.5, 50, "Leafy green");
            Product product2 = new Product("cabbage", 20, 100, "Cruciferous");
            Product product3 = new Product("pumpkin", 30, 30, " Marrow");
            Product product4 = new Product("cauliflower", 10, 25, "Cruciferous");
            Product product5 = new Product("zucchini", 20.5, 50, "Marrow");
            Product product6 = new Product(" yam", 30, 50, " Root");
            Product product7 = new Product("spinach", 10, 100, "Leafy green");
            Product product8 = new Product("broccoli", 20.2, 75, "Cruciferous");
            Product product9 = new Product("Garlic", 30, 20, "Leafy green");
            Product product10 = new Product("silverbeet", 10, 50, " Marrow");
            var products = new List<Product> { product1, product2, product3, product4, product5, product6, product7, product8, product9, product10 };
            var check1 = new ProductRepository(products);
            // act  
            int count = check1.Quantity();
            int expected = 10;
            // assert  
            Assert.AreEqual(expected, count);            
        }

        [TestMethod]
        public void Test1part2()
        {

            // arrange  
            Product product1 = new Product("lettuce", 10.5, 50, "Leafy green");
            Product product2 = new Product("cabbage", 20, 100, "Cruciferous");
            Product product3 = new Product("pumpkin", 30, 30, " Marrow");
            Product product4 = new Product("cauliflower", 10, 25, "Cruciferous");
            Product product5 = new Product("zucchini", 20.5, 50, "Marrow");
            Product product6 = new Product(" yam", 30, 50, " Root");
            Product product7 = new Product("spinach", 10, 100, "Leafy green");
            Product product8 = new Product("broccoli", 20.2, 75, "Cruciferous");
            Product product9 = new Product("Garlic", 30, 20, "Leafy green");
            Product product10 = new Product("silverbeet", 10, 50, " Marrow");
            var products = new List<Product> { product1, product2, product3, product4, product5, product6, product7, product8, product9, product10 };
            var check1 = new ProductRepository(products);
            int expected1 = 11;
            List<Product> pdkafteradd = check1.AddPdk(new Product("Potato", 10, 50, "Root"));
            int afteraddcount = pdkafteradd.Count();
            Assert.AreEqual(afteraddcount, expected1);

        }

        [TestMethod]
        public void Test1part3()
        {
            // arrange  
            Product product1 = new Product("lettuce", 10.5, 50, "Leafy green");
            Product product2 = new Product("cabbage", 20, 100, "Cruciferous");
            Product product3 = new Product("pumpkin", 30, 30, " Marrow");
            Product product4 = new Product("cauliflower", 10, 25, "Cruciferous");
            Product product5 = new Product("zucchini", 20.5, 50, "Marrow");
            Product product6 = new Product("yam", 30, 50, " Root");
            Product product7 = new Product("spinach", 10, 100, "Leafy green");
            Product product8 = new Product("broccoli", 20.2, 75, "Cruciferous");
            Product product9 = new Product("Garlic", 30, 20, "Leafy green");
            Product product10 = new Product("silverbeet", 10, 50, " Marrow");
            var products = new List<Product> { product1, product2, product3, product4, product5, product6, product7, product8, product9, product10 };
            var check1 = new ProductRepository(products);
            // act  
            List<Product> pdkafterremove = check1.Removepdk("zucchini");
            List<Product> pdkafterremove1 = check1.Removepdk("broccoli");
            int expected = 8;
            int count = pdkafterremove1.Count();
            // assert  
            Assert.AreEqual(expected , count);
        }

        [TestMethod]
        public void Test2()
        {
            // arrange  
            Product product1 = new Product("lettuce", 10.5, 50, "Leafy green");
            Product product2 = new Product("cabbage", 20, 100, "Cruciferous");
            Product product3 = new Product("pumpkin", 30, 30, " Marrow");
            Product product4 = new Product("cauliflower", 10, 25, "Cruciferous");
            Product product5 = new Product("zucchini", 20.5, 50, "Marrow");
            Product product6 = new Product(" yam", 30, 50, " Root");
            Product product7 = new Product("spinach", 10, 100, "Leafy green");
            Product product8 = new Product("broccoli", 20.2, 75, "Cruciferous");
            Product product9 = new Product("Garlic", 30, 20, "Leafy green");
            Product product10 = new Product("silverbeet", 10, 50, " Marrow");
            var products = new List<Product> { product1, product2, product3, product4, product5, product6, product7, product8, product9, product10 };


            var check1 = new ProductRepository(products);
            int expected1 = 11;
            Product product11 = new Product("Potato", 10, 50, "Root");
            List<Product> pdkafteradd = check1.AddPdk(product11);
            int afteraddcount = check1.Quantity();
            Assert.AreEqual(afteraddcount, expected1);



            int position = 0;
            for (int i = 0; i < afteraddcount; i++)
            {
                if (pdkafteradd[i] == product11 )
                {
                    position = i;
                }
            }
            Assert.AreEqual((afteraddcount - 1), position );            
        }

        [TestMethod]
        public void Test3part1()
        {
            // arrange  
            Product product1 = new Product("lettuce", 10.5, 50, "Leafy green");
            Product product2 = new Product("cabbage", 20, 100, "Cruciferous");
            Product product3 = new Product("pumpkin", 30, 30, "Marrow");
            Product product4 = new Product("cauliflower", 10, 25, "Cruciferous");
            Product product5 = new Product("zucchini", 20.5, 50, "Marrow");
            Product product6 = new Product("yam", 30, 50, "Root");
            Product product7 = new Product("spinach", 10, 100, "Leafy green");
            Product product8 = new Product("broccoli", 20.2, 75, "Cruciferous");
            Product product9 = new Product("Garlic", 30, 20, "Leafy green");
            Product product10 = new Product("silverbeet", 10, 50, "Marrow");
            var products = new List<Product> { product1, product2, product3, product4, product5, product6, product7, product8, product9, product10 };


            var check1 = new ProductRepository(products);
            int expected1 = 3;

            List<Product> pdkoftype = check1.Findpdk("Cruciferous");
            int pdkoftypecount = pdkoftype.Count();
            Assert.AreEqual(pdkoftypecount, expected1);

            List<Product> pdkoftype2 = check1.Findpdk("Marrow");
            int pdkoftypecount2 = pdkoftype2.Count();
            for (int i = 0; i < pdkoftypecount2; i++)
            {
                string type = pdkoftype2[i].type;
                Assert.AreEqual(type.ToString(), "Marrow" );
            }
        }


        [TestMethod]
        public void Test3part2()
        {
            // arrange  
            Product product1 = new Product("lettuce", 10.5, 50, "Leafy green");
            Product product2 = new Product("cabbage", 20, 100, "Cruciferous");
            Product product3 = new Product("pumpkin", 30, 30, "Marrow");
            Product product4 = new Product("cauliflower", 10, 25, "Cruciferous");
            Product product5 = new Product("zucchini", 20.5, 50, "Marrow");
            Product product6 = new Product("yam", 30, 50, "Root");
            Product product7 = new Product("spinach", 10, 100, "Leafy green");
            Product product8 = new Product("broccoli", 20.2, 75, "Cruciferous");
            Product product9 = new Product("Garlic", 30, 20, "Leafy green");
            Product product10 = new Product("silverbeet", 10, 50, "Marrow");
            var products = new List<Product> { product1, product2, product3, product4, product5, product6, product7, product8, product9, product10 };
            var check1 = new ProductRepository(products);
            List<Product> pdkoftype2 = check1.Findpdk("Marrow");
            int pdkoftypecount2 = pdkoftype2.Count();
            for (int i = 0; i < pdkoftypecount2; i++)
            {
                string type = pdkoftype2[i].type;
                Assert.AreEqual(type.ToString(), "Marrow");
            }
        }


        [TestMethod]
        public void Test4part1()
        {
            // arrange  
            Product product1 = new Product("lettuce", 10.5, 50, "Leafy green");
            Product product2 = new Product("cabbage", 20, 100, "Cruciferous");
            Product product3 = new Product("pumpkin", 30, 30, " Marrow");
            Product product4 = new Product("cauliflower", 10, 25, "Cruciferous");
            Product product5 = new Product("zucchini", 20.5, 50, "Marrow");
            Product product6 = new Product("yam", 30, 50, " Root");
            Product product7 = new Product("spinach", 10, 100, "Leafy green");
            Product product8 = new Product("broccoli", 20.2, 75, "Cruciferous");
            Product product9 = new Product("Garlic", 30, 20, "Leafy green");
            Product product10 = new Product("silverbeet", 10, 50, " Marrow");
            var products = new List<Product> { product1, product2, product3, product4, product5, product6, product7, product8, product9, product10 };


            var check1 = new ProductRepository(products);
            // act  
            List<Product> pdkafterremove1 = check1.Removepdk("pumpkin");
            int expected = 9;
            int count = pdkafterremove1.Count();
            // assert  
            Assert.AreEqual(expected, count);

            List<Product> pdkafterremove = check1.Removepdk("cabbage");
            int count2 = pdkafterremove.Count();
            for (int i = 0; i < count2; i++)
            {
                string pdk = pdkafterremove[i].name;
                Assert.AreNotEqual(pdk.ToString(), "cabbage");
            }
        }


        [TestMethod]
        public void Test4part2()
        {
            // arrange  
            Product product1 = new Product("lettuce", 10.5, 50, "Leafy green");
            Product product2 = new Product("cabbage", 20, 100, "Cruciferous");
            Product product3 = new Product("pumpkin", 30, 30, " Marrow");
            Product product4 = new Product("cauliflower", 10, 25, "Cruciferous");
            Product product5 = new Product("zucchini", 20.5, 50, "Marrow");
            Product product6 = new Product("yam", 30, 50, " Root");
            Product product7 = new Product("spinach", 10, 100, "Leafy green");
            Product product8 = new Product("broccoli", 20.2, 75, "Cruciferous");
            Product product9 = new Product("Garlic", 30, 20, "Leafy green");
            Product product10 = new Product("silverbeet", 10, 50, " Marrow");
            var products = new List<Product> { product1, product2, product3, product4, product5, product6, product7, product8, product9, product10 };


            var check1 = new ProductRepository(products);
            // act  
            List<Product> pdkafterremove = check1.Removepdk("cabbage");
            int count2 = pdkafterremove.Count();
            for (int i = 0; i < count2; i++)
            {
                string pdk = pdkafterremove[i].name;
                Assert.AreNotEqual(pdk.ToString(), "cabbage");
            }
        }


        [TestMethod]
        public void Test5()
        {
            // arrange  
            Product product1 = new Product("lettuce", 10.5, 50, "Leafy green");
            Product product2 = new Product("cabbage", 20, 100, "Cruciferous");
            Product product3 = new Product("pumpkin", 30, 30, " Marrow");
            Product product4 = new Product("cauliflower", 10, 25, "Cruciferous");
            Product product5 = new Product("zucchini", 20.5, 50, "Marrow");
            Product product6 = new Product("yam", 30, 50, " Root");
            Product product7 = new Product("spinach", 10, 100, "Leafy green");
            Product product8 = new Product("broccoli", 20.2, 75, "Cruciferous");
            Product product9 = new Product("Garlic", 30, 20, "Leafy green");
            Product product10 = new Product("silverbeet", 10, 50, " Marrow");
            var products = new List<Product> { product1, product2, product3, product4, product5, product6, product7, product8, product9, product10 };
            var check1 = new ProductRepository(products);
            // act  
            Double totalcost = 0.0;
            totalcost = check1.Buypdk("silverbeet", 30);
            totalcost = check1.Buypdk("broccoli", 20);
            totalcost = check1.Buypdk("spinach", 40);
            Double finalcost = ( (10*30) + (20.2 * 20) + (10*40) );
            Assert.AreEqual(finalcost, totalcost);
          }
    }
}