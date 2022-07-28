using Microsoft.AspNetCore.Mvc;
using SnehaPieShop.Models;
using SnehaPieShop.ViewModels;

namespace SnehaPieShop.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamRepository teamRepository;
        public TeamController(ITeamRepository teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        public ViewResult List()
        {
            var Members = teamRepository.AllTeams;
            return View(Members);
        }
    }
}
