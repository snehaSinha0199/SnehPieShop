namespace PieApi.Models
{
    public class CategoryRepository :ICategoryRepository
    {
        private readonly AppDbContext appDbContext;
       // private readonly IPieRepository pieRepository;
        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
          //  this.pieRepository = pieRepository;
        }

        public IEnumerable<Category> AllCategories => appDbContext.Categories;
        public IEnumerable<Pie> GetPieByCategory(int id)
        {
            // return this.pieRepository.AllPies.Where(p => p.CategoryId == id);
            return this.appDbContext.Pies.Where(p => p.CategoryId == id);

            
        }
    }
}
