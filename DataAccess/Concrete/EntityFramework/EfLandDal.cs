using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfLandDal : EfEntityRepositoryBase<Land, RealtyContext>, ILandDal
    {
        public List<Land> GetLandsAndProperty()
        {
            using (var context = new RealtyContext())
            {
                return context.Lands.Include(x => x.Property).ThenInclude(x=>x.Address).ToList();
            }
        }
    }
}
