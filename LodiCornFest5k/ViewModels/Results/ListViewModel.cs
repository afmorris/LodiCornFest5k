using LodiCornFest5k.Models;
using System.Collections.Generic;

namespace LodiCornFest5k.ViewModels.Results
{
    public class ListViewModel
    {
        public Race Race { get; set; }
        public List<RunnerViewModel> Runners { get; set; } = new List<RunnerViewModel>();
    }
}
