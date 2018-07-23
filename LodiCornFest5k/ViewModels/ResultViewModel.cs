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
    }
}
