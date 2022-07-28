namespace SnehaPieShop.Models
{
    public interface ITeamRepository
    {
        IEnumerable<Team> AllTeams { get; }
    }
}
