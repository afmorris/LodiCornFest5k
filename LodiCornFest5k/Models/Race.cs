using System;
using System.Collections.Generic;

namespace LodiCornFest5k.Models
{
    public class Race
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public ICollection<AgeGroup> AgeGroups { get; set; } = new HashSet<AgeGroup>();
        public ICollection<RaceRunner> RaceRunners { get; set; } = new HashSet<RaceRunner>();
        public ICollection<Result> Results { get; set; } = new HashSet<Result>();
    }
}