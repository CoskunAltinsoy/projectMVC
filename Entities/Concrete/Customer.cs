using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer:IEntity<int>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        
    }
}
