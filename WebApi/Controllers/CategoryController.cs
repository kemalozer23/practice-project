using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}", Name = "ProductById")]
        public IActionResult GetCategoryById(int categoryId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult AddCategory([FromBody] CategoryForCreationDto category)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCategory(int categoryId, [FromBody] CategoryForUpdateDto category)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
