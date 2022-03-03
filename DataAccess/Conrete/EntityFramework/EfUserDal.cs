using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Conrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, RealEstateContext>, IUserDal
    {
        public List<User> GetUserAndRoles()
        {
            using (var context = new RealEstateContext())
            {
                return context.Users.Include(x=>x.Role).ToList();
            }
        }
    }
}
