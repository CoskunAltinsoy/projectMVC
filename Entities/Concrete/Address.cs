using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Address : IEntity<int>
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }

        public virtual Land Land { get; set; }
    }
}
