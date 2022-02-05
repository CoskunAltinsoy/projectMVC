using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Role : IEntity<int>
    {
        public int Id { get; set; }
        public string RoleName { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
