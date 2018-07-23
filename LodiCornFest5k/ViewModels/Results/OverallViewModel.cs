using LodiCornFest5k.Models;
using System.Collections.Generic;

namespace LodiCornFest5k.ViewModels.Results
{
    public class OverallViewModel
    {
        public Race Race { get; set; }
        public List<ResultViewModel> Results { get; set; } = new List<ResultViewModel>();
    }
}
