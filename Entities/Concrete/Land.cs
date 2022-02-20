using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Land:IEntity
    {
        [ForeignKey("Property")]
        public int LandId { get; set; }
        public string Precedent { get; set; }
        public string Template { get; set; }
        public string DeedStatus { get; set; }
        public string LandType { get; set; }
        public string ExchangeSatus { get; set; }

        public virtual Property Property { get; set; }
     
    }
}
