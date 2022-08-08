using Microsoft.AspNetCore.Mvc;
using SnehPieShop.Models;

namespace SnehaPieShop.Components
{
    public class CategoryMenuNew :ViewComponent
    {
        private ICategoryRepository categoryRepository;
        public CategoryMenuNew(ICategoryRepository category)
        {
                this.categoryRepository = category;
        }
        public IViewComponentResult Invoke()
        {
          var category=  categoryRepository.AllCategories;
            return View(category);
        }
    }
}
