using LodiCornFest5k.Models;
using System.Collections.Generic;

namespace LodiCornFest5k.ViewModels.Results
{
    public class AgeGroupViewModel
    {
        public Race Race { get; set; }
        public List<AgeGroupResultsViewModel> AgeGroups { get; set; } = new List<AgeGroupResultsViewModel>();
    }
}
