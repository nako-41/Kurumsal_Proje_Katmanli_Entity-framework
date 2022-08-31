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

        ////// İlk kullanım sekli ////////

        // List<Product> GetAll();
        // List<Product> GelAllByCategoryId(int id);
        //List<Product> GetByUnitPrice(decimal min,decimal max);
        // Product GetById(int ProductId);
        //List<ProductDetailDto> GetProductDetailse();
        //void Add(Product product);


        ///////// YENI KULLANIM ///////////

        // birazdaha farklı kullanmak icin sectigim yontem,burada kullandıgım yapı şöyle;ben
        //deger döndürürken aynı zamanda mesaj da bilgi de döndürmek istedim,bu yüzden
        //IDataResult interface olusturup bu tipte dondurmek istedim
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GelAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<Product> GetById(int ProductId);
        IDataResult<List<ProductDetailDto>> GetProductDetailse();
        IResult Add(Product product);

    }
}
