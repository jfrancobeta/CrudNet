using crudProduct.Models;
using crudProduct.Services;
using Microsoft.AspNetCore.Mvc;

namespace crudProduct.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _service;

        public ProductController(ProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _service.GetById(id);
            return product == null ? NotFound() : Ok(product);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            var success = _service.Create(product);
            return success
                ? CreatedAtAction(nameof(GetById), new { id = product.Id }, product)
                : BadRequest("Datos inválidos");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Product product) =>
            _service.Update(id, product) ? Ok() : NotFound();

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) =>
            _service.Delete(id) ? Ok() : NotFound();
    }
}
