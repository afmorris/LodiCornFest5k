using System.Collections.Generic;

namespace LodiCornFest5k.Models
{
    public class AgeGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        
        public Race Race { get; set; }
        public ICollection<Result> Results { get; set; } = new HashSet<Result>();
    }
}