using Microsoft.AspNetCore.Mvc;
using SnehaPieShop.Models;
using SnehPieShop.Models;

namespace SnehaPieShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public OrderController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult AddToCart(int id)
        {
            var pies = _pieRepository.AllPies.FirstOrDefault(p => p.PieId == id);

           // Order order = new Order();
           // order.PieId = pies.PieId;
           // order.PieName = pies.Name;

          //  int result = _pieRepository.CreateOrder(order);
            return RedirectToAction("List");


        }
    }
}
