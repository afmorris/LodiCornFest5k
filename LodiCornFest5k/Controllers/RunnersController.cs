using LodiCornFest5k.Data;
using LodiCornFest5k.ViewModels;
using LodiCornFest5k.ViewModels.Runners;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LodiCornFest5k.Controllers
{
    public class RunnersController : Controller
    {
        private readonly RaceContext context;

        public RunnersController(RaceContext context)
        {
            this.context = context;
        }

        [HttpGet("/runners/{runnerName}/index")]
        public async Task<IActionResult> RunnerDetails(string runnerName)
        {
            var names = runnerName.Split("-");
            var firstName = names[0];
            var lastName = names[1];

            var runner = await this.context.Runners
                .Include(x => x.Results)
                    .ThenInclude(x => x.Race)
                .Include(x => x.RaceRunners)
                    .ThenInclude(x => x.AgeGroup)
                .Include(x => x.RaceRunners)
                    .ThenInclude(x => x.Race)
                .FirstAsync(x => x.FirstName == firstName && x.LastName == lastName);

            var results = new List<ResultViewModel>();

            foreach (var dbResult in runner.Results.OrderBy(x => x.Race.Date))
            {
                var raceRunner = runner.RaceRunners.First(x => x.Race.Id == dbResult.Race.Id);

                var result = new ResultViewModel
                {
                    Name = $"{runner.FirstName} {runner.LastName}",
                    Gender = runner.Gender,
                    OverallPlace = dbResult.OverallPlace,
                    AgeGroupPlace = dbResult.AgeGroupPlace,
                    RaceName = dbResult.Race.Name,
                    Time = dbResult.Time,
                    AgeGroupName = raceRunner.AgeGroup.Name,
                    RaceYear = dbResult.Race.Date.Year
                };
                
                results.Add(result);
            }

            var viewModel = new RunnerDetailsViewModel
            {
                Runner = runner,
                Results = results
            };

            return View(viewModel);
        }
    }
}