using SnehaPieShop.Models;

namespace SnehPieShop.Models
{
    public class CategoryRepository :ICategoryRepository
    {
        private readonly AppDbContext appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => appDbContext.Categories;
          


    }
}
