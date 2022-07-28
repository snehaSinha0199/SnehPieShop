using Microsoft.EntityFrameworkCore;
using SnehaPieShop.Models;

namespace SnehPieShop.Models
{
    public class PieRepository :IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository;
        private AppDbContext _appDbContext;

        public PieRepository(ICategoryRepository categoryRepository,AppDbContext appDbContext)
        {
                _categoryRepository= categoryRepository;
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> AllPies => _appDbContext.Pies;

        public IEnumerable<Pie> PiesOfTheWeek => _appDbContext.Pies.Where(pie => pie.IsPieOfTheWeek);

        public Pie GetPieById(int pieId)
        {
            return this.AllPies.FirstOrDefault(p => p.PieId == pieId);
                
        }
        public int CreateOrder(Order order)
        {

         //   _appDbContext.order.Add(order);
            return _appDbContext.SaveChanges();
        }

    }
}
