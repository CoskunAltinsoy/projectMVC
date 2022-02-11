using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILandService
    {
        List<Land> GetAll();
        Land GetById(int id);
        void Add(Land land);
        void Update(Land land);
        void Delete(Land land);
    }
}
