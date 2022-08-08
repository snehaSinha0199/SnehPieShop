using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SnehPieShop.Models;

namespace SnehaPieShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository CategoryRepository;
        private readonly IPieRepository pieRepository;
        public CategoryController(ICategoryRepository category,IPieRepository pieRepository)
        {
            this.CategoryRepository = category;
            this.pieRepository = pieRepository;
        }

       public async Task<IActionResult> viewCategory()
        {
            IEnumerable<Category> pies = new List<Category>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7073/AllCategory"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    pies = JsonConvert.DeserializeObject<IEnumerable<Category>>(apiResponse);

                }
            }
            return View(pies);
            /* var categories=CategoryRepository.AllCategories;
              return View(categories);*/
        }
        public async Task<IActionResult> CategoryList(int id)
        {

            /*  var pies = pieRepository.AllPies.Where(p => p.CategoryId == id);
              return View(pies);*/
            IEnumerable<Pie> pies = new List<Pie>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7073/GetPieByCategory?id="+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    pies = JsonConvert.DeserializeObject<IEnumerable<Pie>>(apiResponse);

                }
            }
            return View(pies);
        }
    }
}
