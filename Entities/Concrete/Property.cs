using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Property : IEntity
    {

        public int PropertyId { get; set; }
        public int Price { get; set; }
        public string Picture { get; set; }
        public string Video { get; set; }
        public DateTime ListingDate { get; set; }
        public string AdvertNo { get; set; }
        public string AdvertState { get; set; }
        public int Square { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }

        public virtual Land Land { get; set; }
       

    }
}
