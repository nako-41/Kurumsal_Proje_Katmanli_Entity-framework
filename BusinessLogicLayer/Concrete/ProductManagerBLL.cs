using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using Entities.Concrete;
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

        public List<Products> GetAll()
        {
            return _productDal.GetAll();
        }

        public Products Get(Products products)
        {
            return _productDal.Get(x=>x.ProductID==products.ProductID);
        }

        public List<Products> GelAllByCategoryId(int id)
        {
            return _productDal.GetAll(x=>x.CategoryID==id);
        }

        public List<Products> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max);
        }
    }
}
