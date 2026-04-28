using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository.VirtualDataBase;

namespace Repository.Seeds
{
    public static class ProductSeeds
    {
        public static void Seed()

        {
            if (MyData.Products.Count < 1)
            {
                Product p1 = new Product();
                p1.Id = 1;
                p1.Name = "Trembolona";
                p1.Price = 150;
                    

         
                Product p2 = new Product();
                p2.Id = 2;
                p2.Name = "Anavar";
                p2.Price = 150;

   

                MyData.Products.Add(p1);
                MyData.Products.Add(p2);
            }
        }
    }
};
