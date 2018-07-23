using LodiCornFest5k.Models;
using System.Collections.Generic;

namespace LodiCornFest5k.ViewModels.Runners
{
    public class RunnerDetailsViewModel
    {
        public Runner Runner { get; set; }
        public List<ResultViewModel> Results { get; set; }
    }
}
