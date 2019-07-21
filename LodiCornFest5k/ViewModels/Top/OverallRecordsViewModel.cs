using System.Collections.Generic;

namespace LodiCornFest5k.ViewModels.Top
{
    public class OverallRecordsViewModel
    {
        public IList<ResultViewModel> MaleResults { get; set; } = new List<ResultViewModel>();
        public IList<ResultViewModel> FemaleResults { get; set; } = new List<ResultViewModel>();
    }
}