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
    public class LandPropertyManager : ILandPropertyService
    {
        ILandPropertyDal _landPropertyDal;
        public LandPropertyManager(ILandPropertyDal landPropertyDal)
        {
            _landPropertyDal = landPropertyDal;
        }
        public void Add(LandProperty landProperty)
        {
            _landPropertyDal.Add(landProperty);
        }

        public void Delete(LandProperty landProperty)
        {
            _landPropertyDal.Delete(landProperty);
        }

        public List<LandProperty> GetAll()
        {
            return _landPropertyDal.GetAll();
        }

        public LandProperty GetById(int id)
        {
            return _landPropertyDal.Get(x=>x.Id == id);
        }

        public void Update(LandProperty landProperty)
        {
            _landPropertyDal.Update(landProperty);
        }
    }
}
