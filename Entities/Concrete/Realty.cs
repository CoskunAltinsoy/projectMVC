using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Realty:IEntity<int>
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string Price { get; set; }
        public string Square { get; set; }
        public string Picture { get; set; }
        public string Video { get; set; }
        public DateTime ListingDate { get; set; }
        
    }
}
