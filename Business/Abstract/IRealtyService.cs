using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRealtyService
    {
        List<Realty> GetAll();
        Realty GetById(int id);
        void Add(Realty realty);
        void Update(Realty realty);
        void Delete(Realty realty);
    }
}
