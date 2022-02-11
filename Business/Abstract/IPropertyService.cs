using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPropertyService
    {
        List<Property> GetAll();
        Property GetById(int id);
        void Add(Property property);
        void Update(Property property);
        void Delete(Property property);
    }
}
