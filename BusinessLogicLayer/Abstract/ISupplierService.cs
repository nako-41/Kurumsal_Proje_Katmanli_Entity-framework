using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface ISupplierService
    {

        List<SupplierDetailDto> GetProductDetailse();

    }
}
