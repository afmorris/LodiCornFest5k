namespace LodiCornFest5k.Models
{
    public class RaceRunner
    {
        public int Id { get; set; }
        public int RaceId { get; set; }
        public int RunnerId { get; set; }
        public int AgeGroupId { get; set; }

        public Race Race { get; set; }
        public Runner Runner { get; set; }
        public AgeGroup AgeGroup { get; set; }
    }
}