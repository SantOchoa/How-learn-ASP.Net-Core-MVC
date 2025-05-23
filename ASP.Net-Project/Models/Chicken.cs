namespace ASP.Net_Project.Models
{
    public class Chicken
    {
        public string Name { get; set; }
        public Chicken chicken_son { get; set; }
        public Chicken chicken_brother { get; set; }

        public Chicken()
        {
            Name = "";
            chicken_son = null;
            chicken_brother = null;
        }

    }
}
