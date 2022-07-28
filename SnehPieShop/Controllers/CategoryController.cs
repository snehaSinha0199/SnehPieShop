using Microsoft.AspNetCore.Mvc;
using SnehPieShop.Models;

namespace SnehaPieShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository CategoryRepository;
        private readonly IPieRepository pieRepository;
        public CategoryController(ICategoryRepository category,IPieRepository pieRepository)
        {
            this.CategoryRepository = category;
            this.pieRepository = pieRepository;
        }

       public IActionResult viewCategory()
        {
           var categories=CategoryRepository.AllCategories;
            return View(categories);
        }
        public IActionResult CategoryList(int id)
        {
            
            var pies = pieRepository.AllPies.Where(p => p.CategoryId == id);
            return View(pies);
        }
    }
}
