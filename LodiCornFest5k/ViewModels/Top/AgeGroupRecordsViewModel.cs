using System.Collections.Generic;

namespace LodiCornFest5k.ViewModels.Top
{
    public class AgeGroupRecordsViewModel
    {
        public List<AgeGroupResultsViewModel> MaleAgeGroups { get; set; } = new List<AgeGroupResultsViewModel>();
        public List<AgeGroupResultsViewModel> FemaleAgeGroups { get; set; } = new List<AgeGroupResultsViewModel>();
    }
}