using Microsoft.AspNetCore.Mvc;
using PieApi.Models;

namespace PieApi.Controllers
{
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryController(ICategoryRepository _categoryRepository)
        {
            this.categoryRepository = _categoryRepository;
        }
        [HttpGet]
        [Route("AllCategory")]
        public IActionResult AllCategory()
        {
            try
            {
               var category= this.categoryRepository.AllCategories;
                return Ok(category);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }

        }
        [HttpGet]
        [Route("GetPieByCategory")]
        public IActionResult GetPieByCategory(int id)
        {
            try
            {
                var category = this.categoryRepository.GetPieByCategory(id);
                return Ok(category);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }

        }
    }
}
