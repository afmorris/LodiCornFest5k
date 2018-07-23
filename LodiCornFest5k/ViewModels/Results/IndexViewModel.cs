using LodiCornFest5k.Models;
using System.Collections.Generic;

namespace LodiCornFest5k.ViewModels.Results
{
    public class IndexViewModel
    {
        public ICollection<Race> Races { get; set; } = new HashSet<Race>();
    }
}
