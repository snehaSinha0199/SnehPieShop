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
            return _appDbContext.Pies.FirstOrDefault(s => s.PieId == pieId);
                
        }
        public int CreateOrder(Order order)
        {

         //   _appDbContext.order.Add(order);
            return _appDbContext.SaveChanges();
        }
        public int CreatePies(Pie pie)
        {
            _appDbContext.Pies.Add(pie);
            return _appDbContext.SaveChanges();
        }
        public int RemovePies(Pie pie)
        {
            _appDbContext.Pies.Remove(pie);
            return _appDbContext.SaveChanges();

        }
        public int UpdatePies(Pie pie)
        {
            _appDbContext.Pies.Update(pie);
            return _appDbContext.SaveChanges();
        }
    }
}
