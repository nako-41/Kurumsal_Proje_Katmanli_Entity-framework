using BusinessLogicLayer.Concrete;
using Core.Utilities.Results;
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
            //ProductTest();

            //CategoryTest();


            //Ioc - DTO

            ProductManagerBLL pm = new ProductManagerBLL(new EfProductDal());

            var result = pm.GetProductDetailse();

            foreach (var IDataResult in result.Data)
            {
                Console.WriteLine(IDataResult.ProductName + " " + IDataResult.CategoryName);
            }

            //ProductManagerBLL productManagerBLL = new ProductManagerBLL(new EfProductDal());
            //IResult result=  productManagerBLL.Add(new Product {ProductName="masa" });
            //Console.WriteLine(result.Message + " " + result.Success);

            //SupplierManager supplier = new SupplierManager(new EfSupplierDal());

            //foreach (var item in supplier.GetProductDetailse())
            //{
            //    Console.WriteLine(item.CompanyName + " " + item.ProductName);
            //}




            Console.ReadKey();
        }

        private static void CategoryTest()
        {
            CategoryManager category = new CategoryManager(new EfCategoryDal());

            foreach (var item in category.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            //ProductManagerBLL pm = new ProductManagerBLL(new EfProductDal());
            //List<Product> list = pm.GetByUnitPrice(30, 45);

            //foreach (var item in pm.GelAllByCategoryId(2))
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            //foreach (var item in pm.GetAll())
            //{
            //    Console.WriteLine(item.ProductName);
            //}
        }
    }
}
