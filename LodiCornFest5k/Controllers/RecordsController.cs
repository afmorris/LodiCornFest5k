using System.Linq;
using System.Threading.Tasks;
using LodiCornFest5k.Data;
using LodiCornFest5k.Models;
using LodiCornFest5k.ViewModels;
using LodiCornFest5k.ViewModels.Top;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

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
        public async Task<ActionResult<OverallRecordsViewModel>> Overall()
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

            var viewModel = new OverallRecordsViewModel {MaleResults = maleResults, FemaleResults = femaleResults};

            return View(viewModel);
        }
        
        [HttpGet("/records/age-group/index")]
        public async Task<ActionResult<AgeGroupRecordsViewModel>> AgeGroup()
        {
            var maleAgeGroups = await context.AgeGroups
                .Where(x => x.Gender == Gender.Male)
                .Select(x => new
                {
                    Name = x.Name,
                    Gender = x.Gender
                })
                .Distinct()
                .ToListAsync();

            var femaleAgeGroups = await context.AgeGroups
                .Where(x => x.Gender == Gender.Female)
                .Select(x => new
                {
                    Name = x.Name,
                    Gender = x.Gender
                })
                .Distinct()
                .ToListAsync();

            var viewModel = new AgeGroupRecordsViewModel();
            
            foreach (var ageGroup in maleAgeGroups)
            {
                var results = await context.Results
                    .Where(x => x.AgeGroup.Name == ageGroup.Name && x.Runner.Gender == ageGroup.Gender)
                    .OrderBy(x => x.Time)
                    .Take(10)
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

                var ageGroupResults = new AgeGroupResultsViewModel
                {
                    Name = ageGroup.Name,
                    Gender = ageGroup.Gender,
                    Results = results
                };
                
                viewModel.MaleAgeGroups.Add(ageGroupResults);
            }

            foreach (var ageGroup in femaleAgeGroups)
            {
                var results = await context.Results
                    .Where(x => x.AgeGroup.Name == ageGroup.Name && x.Runner.Gender == ageGroup.Gender)
                    .OrderBy(x => x.Time)
                    .Take(10)
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
                
                var ageGroupResults = new AgeGroupResultsViewModel
                {
                    Name = ageGroup.Name,
                    Gender = ageGroup.Gender,
                    Results = results
                };
                
                viewModel.FemaleAgeGroups.Add(ageGroupResults);
            }
            
            return View(viewModel);
        }
    }
}