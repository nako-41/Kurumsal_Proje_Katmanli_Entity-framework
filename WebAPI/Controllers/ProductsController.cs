using BusinessLogicLayer.Abstract;
using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;


        //Ioc
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet("get")]
        public IActionResult Get()
        {

            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            var result=_productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int Id)
        {
            var result = _productService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut]
        public void Update(Product product)
        {
            _productService.Update(product);
        }

        [HttpDelete]
        public void Delete(Product product)
        {
            _productService.Delete(product);
        }


    }
}
