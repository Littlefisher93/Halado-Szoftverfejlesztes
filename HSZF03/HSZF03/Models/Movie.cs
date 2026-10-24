namespace HSZF03.Models
{
    public class Movie
    {
        public string Name { get; set; }

        /// <summary>
        /// Length in minutes
        /// </summary>
        public int Length { get; set; }

        public int Released { get; set; }
        /// <summary>
        /// default konstruktor
        /// </summary>
        public Movie()
        {

        }

        public Movie(string name, int length, int released)
        {
            Name = name;
            Length = length;
            Released = released;
        }

        public override string ToString()
        {
            return $"{Name} ({Released}) -{Length} minutes";
        }
    }
}
