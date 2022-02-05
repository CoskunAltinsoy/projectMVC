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
    public class EfRoleDal : EfEntityRepositoryBase<Role, RealtyContext>, IRoleDal
    {
        public List<Role> GetAllRole()
        {
            using (var context = new RealtyContext())
            {
                return context.Roles.Include(x=>x.Users).ToList();
            }
        }

    
    }
}
