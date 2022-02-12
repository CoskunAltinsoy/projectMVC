using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Land:IEntity<int>
    {
        public int Id { get; set; }
        public string Precedent { get; set; }
        public string Template { get; set; }
        public string DeedStatus { get; set; }
        public string LandType { get; set; }
        public bool ExchangeSatus { get; set; }

        public virtual Property Property { get; set; }
     
    }
}
