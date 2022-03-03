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
    public class HomePropertyManager : IHomePropertyService
    {
        IHomePropertyDal _homePropertyDal;
        public HomePropertyManager(IHomePropertyDal homePropertyDal)
        {
            _homePropertyDal = homePropertyDal;
        }
        public void Add(HomeProperty homeProperty)
        {
            _homePropertyDal.Add(homeProperty);
        }

        public void Delete(HomeProperty homeProperty)
        {
            _homePropertyDal.Delete(homeProperty);
        }

        public List<HomeProperty> GetAll()
        {
            return _homePropertyDal.GetAll();
        }

        public HomeProperty GetById(int id)
        {
            return _homePropertyDal.Get(x=>x.Id == id);
        }

        public void Update(HomeProperty homeProperty)
        {
            _homePropertyDal.Update(homeProperty);
        }
    }
}
