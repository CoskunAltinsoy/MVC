using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILandPropertyService
    {
        List<LandProperty> GetAll();
        LandProperty GetById(int id);
        void Add(LandProperty landProperty);
        void Update(LandProperty landProperty);
        void Delete(LandProperty landProperty);
    }
}
