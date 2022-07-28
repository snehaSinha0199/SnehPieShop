using SnehaPieShop.Models;
using SnehPieShop.Models;

namespace SnehaPieShop.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> pies { get; set; }
        public string CurrentCategory { get; set; }


    }
}
