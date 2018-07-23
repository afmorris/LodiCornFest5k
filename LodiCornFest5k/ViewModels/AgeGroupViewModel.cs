using LodiCornFest5k.Models;
using System.Collections.Generic;

namespace LodiCornFest5k.ViewModels
{
    public class AgeGroupResultsViewModel
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Link => $"{this.Gender.ToString()}-{this.Name.Replace(" ", "").Replace("&","and").Replace("+","plus")}";
        public List<ResultViewModel> Results { get; set; } = new List<ResultViewModel>();
    }
}
