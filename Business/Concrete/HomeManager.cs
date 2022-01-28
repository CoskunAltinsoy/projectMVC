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
    public class HomeManager : IHomeService
    {
        IHomeDal _homeDal;
        public HomeManager(IHomeDal homeDal)
        {
            _homeDal = homeDal;
        }
        public void Add(Home home)
        {
            _homeDal.Add(home);
        }

        public void Delete(Home home)
        {
            _homeDal.Delete(home);
        }

        public List<Home> GetAll()
        {
            return _homeDal.GetAll();
        }

        public Home GetById(int id)
        {
            return _homeDal.Get(h=>h.Id == id);
        }

        public void Update(Home home)
        {
            _homeDal.Update(home);
        }
    }
}
