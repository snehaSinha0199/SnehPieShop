using Microsoft.AspNetCore.Mvc;
using PieApi.Models;

namespace PieApi.Controllers
{
    [ApiController]
    [Route("Pie")]
    public class PieController : ControllerBase
    {
        private readonly IPieRepository pieRepository;
        public PieController(IPieRepository pieRepository)
        {
            this.pieRepository = pieRepository;
        }
        //  private readonly IMapper mapper;
        [HttpGet]
        [Route("AllPies")]
       public IActionResult AllPies()
        {
            try
            {
              var pie= this. pieRepository.AllPies;
                return Ok(pie);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        [HttpGet]
        [Route("PiesOfTheWeek")]
        public IActionResult PiesOfTheWeek()
        {
            try
            {
                var pies =this. pieRepository.PiesOfTheWeek;
                return Ok(pies);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");


            }

        }
        [HttpGet]
        [Route("GetPieById")]
        public IActionResult GetPieById(int id)
        {
            try
            {
               var pies= pieRepository.GetPieById(id);
                return Ok(pies);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
                
            }
           
        }
        [HttpPost]
        [Route("CreatePies")]
        public IActionResult CreatePies(Pie pie)
        {
            try
            {
                pieRepository.CreatePies(pie);
                return Ok(pie);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
           
        }
        [HttpDelete]
        [Route("RemovePies")]
        public IActionResult RemovePies(int pieId)
        {
            try
            {
               var pies= pieRepository.AllPies.FirstOrDefault(s=>s.PieId==pieId);
                pieRepository.RemovePies(pies);
                return Ok(pies);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

        [HttpPut]
        [Route("UpdatePies")]
        public IActionResult UpdatePies(Pie pie) 
        {
            try
            {
                //var pie = pieRepository.AllPies.FirstOrDefault(s => s.PieId == id);
                var pies=pieRepository.UpdatePies(pie);
                return Ok(pies);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
            
        }
    }
}
