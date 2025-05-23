namespace ASP.Net_Project.Models
{
    public class Chickent
    {
        public string Name { get; set; }
        public Chickent chicken_right { get; set; }
        public Chickent chicken_left { get; set; }

        public Chickent(string name)
        {
            Name = name;
            chicken_right = null;
            chicken_left = null;
        }


    }
}
