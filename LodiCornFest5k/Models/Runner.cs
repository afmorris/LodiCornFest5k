using System.Collections.Generic;

namespace LodiCornFest5k.Models
{
    public class Runner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }

        public ICollection<RaceRunner> RaceRunners { get; set; } = new HashSet<RaceRunner>();
        public ICollection<Result> Results { get; set; } = new HashSet<Result>();
    }
}