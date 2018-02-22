using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(String[] args)
        {

        }
    }
    public class Product
    {
        public String name;
        public Double price;
        public Double quantity;
        public String type;
        public Product(String name, Double price, Double quantity, String type)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.type = type;
        }
    }

    public class ProductRepository
    {
      List<Product> products1;
        Double cost = 0.0;
        public ProductRepository(List<Product> pdk)  
        {
            this.products1 = pdk;
           }

        public int Quantity()
        {                  
            int productcount = this.products1.Count;
            return productcount;          
        }

        public List<Product> AddPdk(Product pdk )
        {
            this.products1.Add(pdk);
            return products1;
        }

        public List<Product> Findpdk(String type)
        {
            var searchedproducts = new List<Product> {};
            int productcount = this.products1.Count;
            for (int i = 0; i < productcount; i++)
            {
                if (this.products1[i].type == type)
                {
                    searchedproducts.Add(this.products1[i]);
                }
            }
            return searchedproducts;
        }

         public List<Product> Removepdk(String name1)
            {
              int productcount = this.products1.Count;
                for (int i = 0; i < productcount ; i++)
                {
                if (this.products1[i].name == name1)
                    {
                        this.products1.RemoveAt(i);
                        break;
                    }
                }
                return this.products1;           
            }

        public double Buypdk (String name , Double quantity)
            {
                
                int productcount = this.products1.Count;
                for (int i = 0; i < productcount; i++)
                {
                    if (this.products1[i].name == name)
                    {
                        cost = cost + (quantity * products1[i].price);
                    }
                }
                return cost;
           }
    }
}
