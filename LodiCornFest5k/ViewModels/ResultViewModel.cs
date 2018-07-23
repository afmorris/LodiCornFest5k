using LodiCornFest5k.Models;
using System;

namespace LodiCornFest5k.ViewModels
{
    public class ResultViewModel
    {
        public int Place { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string AgeGroupName { get; set; }
        public TimeSpan Time { get; set; }
        public string RaceName { get; set; }
        public int OverallPlace { get; set; }
        public int AgeGroupPlace { get; set; }
        public int RaceYear { get; set; }

        public string LinkName
        {
            get
            {
                var names = this.Name.ToLower().Split(" ");
                var firstName = names[0];
                var lastName = names[1];

                return $"{firstName}-{lastName}";
            }
        }

        public string AgeGroupLink
        {
            get
            {
                return $"{this.Gender.ToString().ToLower()}-{this.AgeGroupName.Replace(" ", "").Replace("+", "-").Replace("&", "-").ToLower()}";
            }
        }
    }
}
