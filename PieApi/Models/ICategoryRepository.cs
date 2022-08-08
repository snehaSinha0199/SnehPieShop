namespace PieApi.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
      IEnumerable<Pie> GetPieByCategory(int id);
    }
}
