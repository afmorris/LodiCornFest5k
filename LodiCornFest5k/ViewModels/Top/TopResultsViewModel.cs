using System.Collections.Generic;

namespace LodiCornFest5k.ViewModels.Top
{
    public class TopResultsViewModel
    {
        public IList<ResultViewModel> TopMaleResults { get; set; } = new List<ResultViewModel>();
        public IList<ResultViewModel> TopFemaleResults { get; set; } = new List<ResultViewModel>();
    }
}