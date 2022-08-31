using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GelAllByCategoryId(int id);
        List<Product> GetByUnitPrice(decimal min,decimal max);
        Product GetById(int ProductId);
        List<ProductDetailDto> GetProductDetailse();
        IResult Add(Product product);

    }
}
