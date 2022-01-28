using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public interface IEntity
    {
    }
    public interface IEntity<T>:IEntity where T : struct
    {
        public T Id { get; set; }
    }
}
