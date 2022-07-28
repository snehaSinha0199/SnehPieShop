using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SnehaPieShop.ViewModels;
using SnehPieShop.Models;

namespace SnehaPieShop.Controllers
{
    public class PieController : Controller
    {
        //field -object for the repository
        private readonly IPieRepository _pieRepository;

        public PieController(IPieRepository pieRepository )
        {
           _pieRepository = pieRepository;
        }
       
        public IActionResult List()
        {
            ViewBag.CurrentCategory = "Cheese cakes";
            //got the pies data
            var pies = _pieRepository.AllPies;

            PieListViewModel pieListViewModel = new PieListViewModel();
            pieListViewModel.pies = pies;
            pieListViewModel.CurrentCategory = "Cheese cakes";
            return View(pieListViewModel);
        }
        [Authorize]
        public IActionResult PiesOfTheWeek()
        {
           var pies= _pieRepository.PiesOfTheWeek;
            PieListViewModel pieListViewModel = new PieListViewModel();
            pieListViewModel.pies = pies;

            return View(pieListViewModel);
        }

        public ViewResult Details(int id)
        {
            var pie = _pieRepository.AllPies.FirstOrDefault(s => s.PieId == id);
            return View(pie);

        }
       

    }
}
