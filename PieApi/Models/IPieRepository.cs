namespace PieApi.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById(int pieId);

        int CreatePies(Pie pie);

        int RemovePies(Pie pie);
        int UpdatePies(Pie pie);
    }
}
