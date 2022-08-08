using AutoMapper;
using SnehPieShop.Models;

namespace SnehaPieShop.Models
{
    public class PieProfile : Profile
    {
        public PieProfile()
        {
            this.CreateMap<Pie,PieMini>();
        }
    }


}
