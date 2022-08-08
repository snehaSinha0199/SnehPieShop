namespace PieApi.Models
{
    public class PieRepository :IPieRepository
    {
       
        private readonly ICategoryRepository _categoryRepository;
        private AppDbContext _appDbContext;

        public PieRepository(ICategoryRepository categoryRepository, AppDbContext appDbContext)
        {
            _categoryRepository = categoryRepository;
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> AllPies => _appDbContext.Pies;

        public IEnumerable<Pie> PiesOfTheWeek => _appDbContext.Pies.Where(pie => pie.IsPieOfTheWeek);

        public Pie GetPieById(int pieId)
        {
            return this.AllPies.FirstOrDefault(p => p.PieId == pieId);

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
