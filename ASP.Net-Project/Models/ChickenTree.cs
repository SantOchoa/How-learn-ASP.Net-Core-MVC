namespace ASP.Net_Project.Models
{
    public class ChickenTree
    {
        public Chicken raiz { get; set; }
        public Chicken trabajo { get; set; }
        public int i = 0;
        public ChickenTree()
        {
            raiz = new Chicken();
        }
        public  void addChicken()
        {

        }
    }
}
