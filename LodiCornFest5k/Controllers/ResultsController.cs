using LodiCornFest5k.Data;
using LodiCornFest5k.ViewModels;
using LodiCornFest5k.ViewModels.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LodiCornFest5k.Controllers
{
    public class ResultsController : Controller
    {
        private readonly RaceContext context;

        public ResultsController(RaceContext context)
        {
            this.context = context;
        }

        [HttpGet("/results/index")]
        public async Task<IActionResult> Index()
        {
            var viewModel = new IndexViewModel
            {
                Races = await this.context.Races.OrderByDescending(x => x.Date).ToListAsync()
            };

            return View(viewModel);
        }

        [HttpGet("/results/{year}")]
        public async Task<IActionResult> Race(int year)
        {
            var viewModel = new RaceViewModel
            {
                Race = await this.context.Races.SingleAsync(x => x.Date.Year == year)
            };

            return View(viewModel);
        }

        [HttpGet("/results/{year}/list")]
        public async Task<IActionResult> List(int year)
        {
            var race = await this.context.Races
                .Include(x => x.RaceRunners)
                    .ThenInclude(x => x.Runner)
                .Include(x => x.RaceRunners)
                    .ThenInclude(x => x.AgeGroup)
                .FirstAsync(x => x.Date.Year == year);

            var runners = new List<RunnerViewModel>();

            foreach (var raceRunner in race.RaceRunners.OrderBy(x => x.Runner.Gender).ThenBy(x => x.Runner.LastName))
            {
                var runner = new RunnerViewModel
                {
                    Name = $"{raceRunner.Runner.FirstName} {raceRunner.Runner.LastName}",
                    Gender = raceRunner.Runner.Gender,
                    AgeGroupName = raceRunner.AgeGroup.Name
                };

                runners.Add(runner);
            }

            var viewModel = new ListViewModel
            {
                Race = race,
                Runners = runners
            };

            return View(viewModel);
        }

        [HttpGet("/results/{year}/overall")]
        public async Task<IActionResult> Overall(int year)
        {
            var race = await this.context.Races
                .Include(x => x.RaceRunners)
                    .ThenInclude(x => x.Runner)
                .Include(x => x.RaceRunners)
                    .ThenInclude(x => x.AgeGroup)
                .Include(x => x.Results)
                    .ThenInclude(x => x.Runner)
                .FirstAsync(x => x.Date.Year == year);

            
            var results = new List<ResultViewModel>();

            foreach (var dbResult in race.Results.OrderBy(x => x.OverallPlace))
            {
                var ageGroup = race.RaceRunners.First(x => x.RunnerId == dbResult.Runner.Id).AgeGroup;

                var result = new ResultViewModel
                {
                    Place = dbResult.OverallPlace,
                    Name = $"{dbResult.Runner.FirstName} {dbResult.Runner.LastName}",
                    Gender = dbResult.Runner.Gender,
                    AgeGroupName = ageGroup.Name,
                    Time = dbResult.Time,
                    RaceName = race.Name
                };

                results.Add(result);
            }

            var viewModel = new OverallViewModel
            {
                Race = race,
                Results = results
            };

            return View(viewModel);
        }

        [HttpGet("/results/{year}/age")]
        public async Task<IActionResult> AgeGroup(int year)
        {
            var race = await this.context.Races
                .Include(x => x.AgeGroups)
                    .ThenInclude(x => x.Results)
                .Include(x => x.RaceRunners)
                    .ThenInclude(x => x.Runner)
                .Include(x => x.RaceRunners)
                    .ThenInclude(x => x.AgeGroup)
                .Include(x => x.Results)
                    .ThenInclude(x => x.Runner)
                .FirstAsync(x => x.Date.Year == year);

            var ageGroups = new List<AgeGroupResultsViewModel>();

            foreach (var ageGroup in race.AgeGroups)
            {
                var raceRunnerIds = race.RaceRunners.Where(x => x.AgeGroup.Id == ageGroup.Id).Select(x => x.Runner.Id);
                var ageGroupResults = race.Results.Where(x => raceRunnerIds.Contains(x.Runner.Id));

                var results = new List<ResultViewModel>();

                foreach (var ageGroupResult in ageGroupResults)
                {
                    var res = new ResultViewModel
                    {
                        Place = ageGroupResult.AgeGroupPlace,
                        Name = $"{ageGroupResult.Runner.FirstName} {ageGroupResult.Runner.LastName}",
                        Gender = ageGroupResult.Runner.Gender,
                        AgeGroupName = ageGroup.Name,
                        Time = ageGroupResult.Time,
                        RaceName = race.Name
                    };

                    results.Add(res);
                }

                var result = new AgeGroupResultsViewModel
                {
                    Name = ageGroup.Name,
                    Gender = ageGroup.Gender,
                    Results = results.OrderBy(x => x.Place).ToList()
                };

                ageGroups.Add(result);
            }

            var viewModel = new AgeGroupViewModel
            {
                Race = race,
                AgeGroups = ageGroups.OrderBy(x => x.Gender).ThenBy(x => x.Name).ToList()
            };

            return View(viewModel);
        }
    }
}