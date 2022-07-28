namespace SnehaPieShop.Models
{
    public class TeamRepository : ITeamRepository
    {
        private AppDbContext _appDbContext;
        public TeamRepository(AppDbContext appContext)
        {
            _appDbContext = appContext;
        }
        public IEnumerable<Team> AllTeams => _appDbContext.team;
    }
}
