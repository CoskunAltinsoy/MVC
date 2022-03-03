using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Conrete.EntityFramework
{
    public class EfHomePropertyDal : EfEntityRepositoryBase<HomeProperty,RealEstateContext>, IHomePropertyDal
    {
       
    }
}
