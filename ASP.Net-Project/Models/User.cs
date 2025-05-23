namespace ASP.Net_Project.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password {  get; set; }
        public User(int id,string name, string password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
        }
        public string toString()
        {
            return "id: " + id + " name: " + name + " password: " + password;
        }
    }
}
