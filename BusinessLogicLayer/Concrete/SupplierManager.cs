using BusinessLogicLayer.Abstract;
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
    public class SupplierManager : ISupplierService
    {
        ISupplierDal _supplierDal;

        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
          
           
        }

        public List<SupplierDetailDto> GetProductDetailse()
        {
            return _supplierDal.GetSupplierDetails();
        }

        //public void Add(Supplier supplier)
        //{
        //    _supplierDal.Add(supplier);
        //}


    }
}
