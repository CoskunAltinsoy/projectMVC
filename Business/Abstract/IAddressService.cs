using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAddressService
    {
        List<Address> GetAll();
        Address GetById(int id);
        void Add(Address address);
        void Update(Address address);
        void Delete(Address address);
    }
}
