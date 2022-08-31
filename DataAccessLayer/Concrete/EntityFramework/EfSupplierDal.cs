using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfSupplierDal : EfEntityRepositoryBase<Supplier, NorthwindDbContext>, ISupplierDal
    {
        public List<SupplierDetailDto> GetSupplierDetails()
        {
            using (NorthwindDbContext context=new NorthwindDbContext())
            {
                var result = from s in context.suppliers
                             join p in context.products
                             on s.SupplierID equals p.SupplierID
                             select new SupplierDetailDto { SupplierID = s.SupplierID, CompanyName = s.CompanyName, ProductName = p.ProductName };

                return result.ToList();
            }
        }
    }
}
