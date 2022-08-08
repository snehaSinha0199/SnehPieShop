using SnehPieShop.Models;

namespace SnehaPieShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Pie PieId { get; set; }

        public string PieName { get; set; }
        public IEnumerable<Pie> pies { get; set; }
    }
}
