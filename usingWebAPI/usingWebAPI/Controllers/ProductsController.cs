using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using usingWebAPI.Models;
using usingWebAPI.Services;

namespace usingWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }
        ////REST değil:
        //[HttpGet]
        //public async Task<IEnumerable<Products>> Get()
        //{
            
        //    return await productService.GetProducts();
        //}
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await productService.GetProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await productService.GetProduct(id);
            if (product == null)
            {
                return BadRequest();
            }

            return Ok(product);
        }
    }
}
