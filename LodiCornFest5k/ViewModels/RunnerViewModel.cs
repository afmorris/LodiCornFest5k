using LodiCornFest5k.Models;

namespace LodiCornFest5k.ViewModels
{
    public class RunnerViewModel
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string AgeGroupName { get; set; }
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
    }
}
