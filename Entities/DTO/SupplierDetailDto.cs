using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class SupplierDetailDto:IDto
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string ProductName { get; set; }

    }
}
