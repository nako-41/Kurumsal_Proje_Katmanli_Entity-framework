using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Products> _Products;

        public InMemoryProductDal()
        {
            //SQL server veya diger db cesitleri varsaydım,suanlık bellek tarafında islem görüyorum runtime
            _Products = new List<Products>() 
            {new Products {ProductID=1,CategoryID=1,ProductName="telefon",UnitsInStock=10,UnitPrice=6000 },
             new Products {ProductID=2,CategoryID=2,ProductName="dolap",UnitsInStock=20,UnitPrice=300 },
             new Products {ProductID=3,CategoryID=2,ProductName="cekmece",UnitsInStock=15,UnitPrice=150 }
            };
        }

        public void Add(Products product)
        {
            _Products.Add(product);
        }

        public void Delete(Products product)
        {
            var result = _Products.FirstOrDefault(x=>x.ProductID==product.ProductID);
            _Products.Remove(result);
        }

        public Products Get(Expression<Func<Products, bool>> filter)
        {
            throw new Exception();
        }

        public List<Products> GetAll()
        {
            return _Products;
        }

        public List<Products> GetAll(Expression<Func<Products, bool>> filter = null)
        {
            throw new Exception();
        }

        public void Update(Products product)
        {
            var result = _Products.FirstOrDefault(x=>x.ProductID==product.ProductID);
            result.ProductName = product.ProductName;
            result.CategoryID = product.CategoryID;
            result.UnitsInStock = product.UnitsInStock;
            result.UnitPrice = product.UnitPrice;
        }
    }
}
