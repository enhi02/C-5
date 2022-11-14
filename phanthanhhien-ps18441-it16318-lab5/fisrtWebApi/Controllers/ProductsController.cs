using fisrtWebApi.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace fisrtWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        protected IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<ProductViewModel> Get()
        {
            return _productService.getAll();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public ActionResult<ProductViewModel> Get(int id)
        {
            if (id != 0)
                return _productService.findByID(id);
            else
                return BadRequest("Value must be passed in the request body.");
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] ProductViewModel res)
        {
            _productService.Add(new ProductViewModel
            {
                Id = res.Id,
                Name = res.Name
            });
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProductViewModel res)
        {
            _productService.Edit(res);
        }
        [HttpPatch("{id}")]
        public StatusCodeResult Patch(int id, [FromForm] JsonPatchDocument<ProductViewModel> patch)
        {
            var res = (ProductViewModel)((OkObjectResult)Get(id).Result).Value;
            if (res != null)
            {
                patch.ApplyTo(res);
                return Ok();
            }
            return NotFound();
        }
        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.Delete(id);
        }
    }
}
