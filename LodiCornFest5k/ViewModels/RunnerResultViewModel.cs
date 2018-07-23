using LodiCornFest5k.Models;
using System.Collections.Generic;

namespace LodiCornFest5k.ViewModels
{
    public class RunnerResultViewModel
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public List<ResultViewModel> Results { get; set; }
    }
}
