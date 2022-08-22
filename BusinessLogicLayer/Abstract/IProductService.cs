using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IProductService
    {
        List<Products> GetAll();
        List<Products> GelAllByCategoryId(int id);
        List<Products> GetByUnitPrice(decimal min,decimal max);

    }
}
