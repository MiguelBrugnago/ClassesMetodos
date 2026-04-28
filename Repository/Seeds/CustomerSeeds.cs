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
    public static class CustomerSeeds
    {
        public static void Seed()

        {
            if (MyData.Customers.Count < 1)
            {
                Customer c1 = new Customer();
                c1.Id = 1;
                c1.FirstName = "Jão";
                c1.LastName = "Oliveira";
                c1.Email = "jao.oliveira@bol.com";
                c1.Phone = "123-456-7890";

                Adress c1Adress = new Adress();
                c1Adress.Id = 1;
                c1Adress.Country = "Brazil";
                c1Adress.FederalState = "SC";
                c1Adress.City = "Videira";
                c1Adress.PostalCode = "89560-000";
                c1Adress.Street = "Rua das Flores";
                c1Adress.Number = "24";

                c1.HomeAddress = c1Adress;
                c1.ShippingAddress = c1Adress;

                Customer c2 = new Customer();
                c2.Id = 2;
                c2.FirstName = "Maria";
                c2.LastName = "Trembolona";
                c2.Email = "maria.trembolona@bol.com";
                c2.Phone = "123-456-9078";

                Adress c2Adress = new Adress();
                c2Adress.Id = 2;
                c2Adress.Country = "Brazil";
                c2Adress.FederalState = "SC";
                c2Adress.City = "Videira";
                c2Adress.PostalCode = "89560-000";
                c2Adress.Street = "Rua das Madeiras";
                c2Adress.Number = "67";

                c2.HomeAddress = c2Adress;
                c2.ShippingAddress = c2Adress;

                MyData.Customers.Add(c1);
                MyData.Customers.Add(c2);
            }
        }
    }
};
