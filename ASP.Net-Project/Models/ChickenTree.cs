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
        public Chicken addChicken(string nameChickent, Chicken? chicken)
        {
            if(chicken == null)
            {
                raiz = new Chicken(nameChickent);
                raiz.chicken_son = null;
                raiz.chicken_brother = null;
                return raiz;
            }
            if (chicken.chicken_son == null)
            {
                Chicken sonChicken = new Chicken(nameChickent);
                chicken.chicken_son = sonChicken;
                return sonChicken;
            }
            else 
            {
                trabajo = chicken.chicken_son;
                while (trabajo.chicken_brother != null)
                {
                    trabajo = trabajo.chicken_brother;
                }
                Chicken brotherChicken = new Chicken(nameChickent);
                trabajo.chicken_brother = brotherChicken;
                return brotherChicken;
            }
        }

        public Chicken postOrdenSearch(Chicken chicken, string name)
        {
            if (chicken == null)
            {
                return null;
            }

            // 1. Buscar en el hijo
            Chicken encontrado = postOrdenSearch(chicken.chicken_son, name);
            if (encontrado != null)
            {
                return encontrado;
            }

            // 2. Buscar en el hermano
            encontrado = postOrdenSearch(chicken.chicken_brother, name);
            if (encontrado != null)
            {
                return encontrado;
            }

            // 3. Revisar el nodo actual
            if (chicken.Name.Equals(name))
            {
                return chicken;
            }

            return null;
        }
        
        







    }
}
