using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Home:IEntity<int>
    {
        public int Id { get; set; }
        public string ApartmentType { get; set; }
        public string NumberOfRoom { get; set; }
        public string NumberOfBath { get; set; }
        public string AgeOfApartment { get; set; }
        public string WhichFloor { get; set; }
        public string NumberOfFloor { get; set; }
        public string DeedStatus { get; set; }
        public string WarmType { get; set; }
        public bool FurnitureStatus { get; set; }
        public bool Lift { get; set; }
        public bool CarPark { get; set; }
        public bool Exchange { get; set; }
        public int RealtyId { get; set; }
        
    }
}
