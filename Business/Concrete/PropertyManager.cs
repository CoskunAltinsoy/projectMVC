using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PropertyManager : IPropertyService
    {
        IPropertyDal _propertyDal;
        public PropertyManager(IPropertyDal propertyDal)
        {
            _propertyDal = propertyDal;
        }

        public void Add(Property property)
        {
            _propertyDal.Add(property);
        }

        public void Delete(Property property)
        {
            _propertyDal.Delete(property);
        }

        public List<Property> GetAll()
        {
            return _propertyDal.GetAll();
        }

        public Property GetById(int id)
        {
            return _propertyDal.Get(x=>x.Id == id);
        }

        public void Update(Property property)
        {
            _propertyDal.Update(property);
        }
    }
}
