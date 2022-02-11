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
    public class AddressManager : IAddressService
    {
        IAddressDal _addressDal;
        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }
        public void Add(Address address)
        {
            _addressDal.Add(address);
        }

        public void Delete(Address address)
        {
            _addressDal.Delete(address);
        }

        public List<Address> GetAll()
        {
            return _addressDal.GetAll();
        }

        public Address GetById(int id)
        {
            return _addressDal.Get(x=>x.Id == id);
        }

        public void Update(Address address)
        {
            _addressDal.Update(address);
        }
    }
}
