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
    public class RealtyManager : IRealtyService
    {
        IRealtyDal _realtyDal;
        public RealtyManager(IRealtyDal realtyDal)
        {
            _realtyDal = realtyDal;
        }
        public void Add(Realty realty)
        {
            _realtyDal.Add(realty);
        }

        public void Delete(Realty realty)
        {
            _realtyDal.Delete(realty);
        }

        public List<Realty> GetAll()
        {
            return _realtyDal.GetAll();
        }

        public Realty GetById(int id)
        {
            return _realtyDal.Get(r => r.Id == id);
        }

        public void Update(Realty realty)
        {
            _realtyDal.Update(realty);
        }
    }
}
