using Entities.Concrete;

namespace MvcWebUI.Models
{
    public class UserViewModel
    {
        public IEnumerable<Role> Roles { get; set; }
        public User User { get; set; }
    }
}
