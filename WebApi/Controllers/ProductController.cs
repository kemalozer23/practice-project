using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class ProductController : Controller
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}", Name ="ProductById")]
        public IActionResult GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] ProductForCreationDto product)
        {
            throw new NotImplementedException();
        }

        // Tümüyle değişecekse PUT yalnızca az bir kısım değişecekse maliyet açısından PATCH kullanılabilir
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int productId, [FromBody] ProductForUpdateDto product)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
