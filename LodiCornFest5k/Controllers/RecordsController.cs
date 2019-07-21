using System.Linq;
using System.Threading.Tasks;
using LodiCornFest5k.Data;
using LodiCornFest5k.Models;
using LodiCornFest5k.ViewModels;
using LodiCornFest5k.ViewModels.Top;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LodiCornFest5k.Controllers
{
    public class RecordsController : Controller
    {
        private readonly RaceContext context;

        public RecordsController(RaceContext context)
        {
            this.context = context;
        }
        
        [HttpGet("/records/overall/index")]
        public async Task<IActionResult> Overall()
        {
            var maleResults = await context.Results
                .Where(x => x.Runner.Gender == Gender.Male)
                .OrderBy(x => x.Time)
                .Take(50)
                .Select(x => new ResultViewModel
                {
                    Name = $"{x.Runner.FirstName} {x.Runner.LastName}",
                    Gender = x.Runner.Gender,
                    RaceName = x.Race.Name,
                    RaceYear = x.Race.Date.Year,
                    Time = x.Time,
                    AgeGroupPlace = x.AgeGroupPlace,
                    OverallPlace = x.OverallPlace,
                    AgeGroupName = x.Race.RaceRunners.Single(y => y.Runner.Id == x.Runner.Id).AgeGroup.Name
                })
                .ToListAsync();
            
            var femaleResults = await context.Results
                .Where(x => x.Runner.Gender == Gender.Female)
                .OrderBy(x => x.Time)
                .Take(50)
                .Select(x => new ResultViewModel
                {
                    Name = $"{x.Runner.FirstName} {x.Runner.LastName}",
                    Gender = x.Runner.Gender,
                    RaceName = x.Race.Name,
                    RaceYear = x.Race.Date.Year,
                    Time = x.Time,
                    AgeGroupPlace = x.AgeGroupPlace,
                    OverallPlace = x.OverallPlace,
                    AgeGroupName = x.Race.RaceRunners.Single(y => y.Runner.Id == x.Runner.Id).AgeGroup.Name
                })
                .ToListAsync();

            var viewModel = new TopResultsViewModel {TopMaleResults = maleResults, TopFemaleResults = femaleResults};

            return View(viewModel);
        }
        
        [HttpGet("/records/age-group/index")]
        public IActionResult AgeGroup()
        {
            return View();
        }
    }
}