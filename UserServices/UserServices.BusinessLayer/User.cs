using UserServices.Shared;

namespace UserServices.BusinessLayer
{
    public class User
    {
        public int ID { get;private set; }
        public string Name { get; set; }
        public Role Role { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public Session Session { get; set; }
        public bool IsActivated { get; set; }
    }
}
