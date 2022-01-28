using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class WorkPlace:IEntity<int>
    {
        public int Id { get; set; }
        public string NumberOfRoom { get; set; }
        public string AgeOfApartment { get; set; }
        public string WhichFloor { get; set; }
        public string NumberOfFloor { get; set; }
        public string WarmType { get; set; }
        public int RealtyId { get; set; }
        
    }
}
