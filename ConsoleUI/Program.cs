using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            ProductManagerBLL pm = new ProductManagerBLL(new EfProductDal());
            List<Products> list = pm.GetByUnitPrice(30, 45);

            foreach (var item in pm.GelAllByCategoryId(2))
            {
                Console.WriteLine(item.ProductName);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item.ProductName);
            }

            foreach (var item in pm.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }

        }
    }
}
