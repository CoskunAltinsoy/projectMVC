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
    public class LandManager : ILandService
    {
        ILandDal _landDal;
        public LandManager(ILandDal landDal)
        {
            _landDal = landDal;
        }
        public void Add(Land land)
        {
            _landDal.Add(land);
        }

        public void Delete(Land land)
        {
            _landDal.Delete(land);
        }

        public List<Land> GetAll()
        {
            return _landDal.GetLandsAndProperty();
        }

        public Land GetById(int id)
        {
            return _landDal.Get(x=>x.Id == id);
        }

        public void Update(Land land)
        {
            _landDal.Update(land);
        }
    }
}
