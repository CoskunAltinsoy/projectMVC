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
    public class EfUserDal : EfEntityRepositoryBase<User, RealtyContext>, IUserDal
    {
        public List<User> GetUsersRoleName()
        {
            using (var context = new RealtyContext())
            {
                return context.Users.Include(x => x.Role).ToList();
            }
        }
    }
}
