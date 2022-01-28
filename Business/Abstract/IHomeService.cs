using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHomeService
    {
        List<Home> GetAll();
        Home GetById(int id);
        void Add(Home home);
        void Update(Home home);
        void Delete(Home home);
    }
}
