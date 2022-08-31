using BusinessLogicLayer.Abstract;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class ProductManagerBLL : IProductService
    {
        IProductDal _productDal;

        public ProductManagerBLL(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product Get(Product products)
        {
            return _productDal.Get(x=>x.ProductID==products.ProductID);
        }

        public List<Product> GelAllByCategoryId(int id)
        {
            return _productDal.GetAll(x=>x.CategoryID==id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max);
        }

        public List<ProductDetailDto> GetProductDetailse()
        {
            return _productDal.GetProductDetailse();
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length<2)
            {
                return new ErrorResult("urun ismi min 2 karakter olmalıdır.");
            }
            _productDal.Add(product);

            return new SuccessResult("ürün eklendi");
        }

        public Product GetById(int ProductId)
        {
            return _productDal.Get(p=>p.ProductID==ProductId);
        }
    }
}
