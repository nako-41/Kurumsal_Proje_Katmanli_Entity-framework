using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTO;
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
        List<Product> _Products;

        public InMemoryProductDal()
        {
            //SQL server veya diger db cesitleri varsaydım,suanlık bellek tarafında islem görüyorum runtime
            _Products = new List<Product>() 
            {new Product {ProductID=1,CategoryID=1,ProductName="telefon",UnitsInStock=10,UnitPrice=6000 },
             new Product {ProductID=2,CategoryID=2,ProductName="dolap",UnitsInStock=20,UnitPrice=300 },
             new Product {ProductID=3,CategoryID=2,ProductName="cekmece",UnitsInStock=15,UnitPrice=150 }
            };
        }

        public void Add(Product product)
        {
            _Products.Add(product);
        }

        public void Delete(Product product)
        {
            var result = _Products.FirstOrDefault(x=>x.ProductID==product.ProductID);
            _Products.Remove(result);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new Exception();
        }

        public List<Product> GetAll()
        {
            return _Products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new Exception();
        }

        public List<ProductDetailDto> GetProductDetailse()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            var result = _Products.FirstOrDefault(x=>x.ProductID==product.ProductID);
            result.ProductName = product.ProductName;
            result.CategoryID = product.CategoryID;
            result.UnitsInStock = product.UnitsInStock;
            result.UnitPrice = product.UnitPrice;
        }
    }
}
