using Core.Entities;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class LandProperty : BaseEntity, IEntity
    {
        public string Precedent { get; set; }
        public string Template { get; set; }
        public string DeedStatus { get; set; }
        public string LandType { get; set; }
        
    }
}
