using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHomePropertyService
    {
        List<HomeProperty> GetAll();
        HomeProperty GetById(int id);
        void Add(HomeProperty homeProperty);
        void Update(HomeProperty homeProperty);
        void Delete(HomeProperty homeProperty);
    }
}
