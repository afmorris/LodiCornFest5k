using System;

namespace LodiCornFest5k.Models
{
    public class Result
    {
        public int Id { get; set; }
        public TimeSpan Time { get; set; }
        public int AgeGroupPlace { get; set; }
        public int OverallPlace { get; set; }

        public Runner Runner { get; set; }
        public Race Race { get; set; }
        public AgeGroup AgeGroup { get; set; }
    }
}