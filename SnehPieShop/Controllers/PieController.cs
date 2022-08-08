using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SnehaPieShop.Models;
using SnehaPieShop.ViewModels;
using SnehPieShop.Models;

namespace SnehaPieShop.Controllers
{
    public class PieController : Controller
    {
        //field -object for the repository
        private readonly IPieRepository _pieRepository;
        private readonly IMapper mapper;
        


        public PieController(IPieRepository pieRepository,IMapper mapper )
        {
          this._pieRepository = pieRepository;
            this.mapper = mapper;   
        }
       

        public async  Task<IActionResult> List()
        {
            IEnumerable<Pie> pies=new List<Pie>();
            using (var httpClient = new HttpClient())
        {
            using (var response = await httpClient.GetAsync("https://localhost:7073/Pie/AllPies"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                   pies = JsonConvert.DeserializeObject<IEnumerable<Pie>>(apiResponse);

                }
        }
            PieListViewModel pieListViewModel = new PieListViewModel();
            pieListViewModel.pies = pies;
            return View(pieListViewModel);
           
        }
        public IActionResult ListMini()
        {
           var pies= _pieRepository.AllPies;
           var piesMini= mapper.Map<IEnumerable<PieMini>>(pies);
            return View(piesMini);

        }
        [Authorize]
        public async Task<IActionResult> PiesOfTheWeek()
        {
            IEnumerable<Pie> pies = new List<Pie>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7073/Pie/PiesOfTheWeek"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    pies = JsonConvert.DeserializeObject<IEnumerable<Pie>>(apiResponse);

                }
            }
           // var pies= _pieRepository.PiesOfTheWeek;
            PieListViewModel pieListViewModel = new PieListViewModel();
            pieListViewModel.pies = pies;

            return View(pieListViewModel);
        }

        public  async Task<ViewResult> Details(int id)
        {
            var pie = new Pie();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7073/Pie/GetPieById?id=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    pie = JsonConvert.DeserializeObject<Pie>(apiResponse);

                }
            }
            //   var pie = _pieRepository.AllPies.FirstOrDefault(s => s.PieId == id);

                return View(pie);

        }
        public async Task<IActionResult> CreatePies(Pie pie)
        {
            IEnumerable<Pie> pies = new List<Pie>();
            using (var httpClient = new HttpClient())
            {

                JsonContent content = JsonContent.Create(pie);
                using (var response = await httpClient.PostAsync("https://localhost:7073/Pie/CreatePies",content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                  

                }
            }
            var newPies = _pieRepository.CreatePies(pie);
            return RedirectToAction("List");
        }
        public ViewResult Create()
        {
            return View();
        }
       
        public async Task<ViewResult> Remove(int id)
        {
                      /*   var removePies= _pieRepository.AllPies.FirstOrDefault(s=>s.PieId==id);
                       return View(removePies);*/
            var pie=new Pie();
            using (var httpClient = new HttpClient())
            {

                using (var response = await httpClient.GetAsync("https://localhost:7073/Pie/GetPieById?id=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    pie = JsonConvert.DeserializeObject<Pie>(apiResponse);

                }
            }
                   return View(pie);
           
        }
       
        public async Task<IActionResult> RemovePies(int PieId)
        {
            var id = PieId;
           
            using (var httpClient = new HttpClient())
            {
              
                using (var response = await httpClient.DeleteAsync("https://localhost:7073/Pie/RemovePies?pieId=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    

                }
            }

          
          return  RedirectToAction("List");
        }
        public async Task<ViewResult> Update(int id)
        {
            var pie = new Pie();
          using (var httpClient = new HttpClient())
          {

              using (var response = await httpClient.GetAsync("https://localhost:7073/Pie/GetPieById?id=" + id))
              {
                  string apiResponse = await response.Content.ReadAsStringAsync();
                  pie = JsonConvert.DeserializeObject<Pie>(apiResponse);

              }
          }
               //  var pies =  _pieRepository.AllPies.FirstOrDefault(s=>s.PieId==id);
            return View(pie);
        }
        public async Task<IActionResult> UpdatePies(Pie pie)
        {
            
            using (var httpClient = new HttpClient())
            {
           
                
                using (var response = await httpClient.PutAsJsonAsync("https://localhost:7073/api/Pie/UpdatePies",pie))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                     

                }
            }

           // var update = _pieRepository.UpdatePies(pie);
            return RedirectToAction("List");
        }


    }
}
