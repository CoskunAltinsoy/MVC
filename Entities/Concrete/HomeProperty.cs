using Core.Entities;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class HomeProperty : BaseEntity,IEntity
    {
        public string ApartmentType { get; set; }
        public string NumberOfRoom { get; set; }
        public string NumberOfBath { get; set; }
        public string AgeOfApartment { get; set; }
        public string WhichFloor { get; set; }
        public string DeedStatus { get; set; }
        public string WarmType { get; set; }
        public string Facede { get; set; }
        public bool FurnitureStatus { get; set; }
        public bool Lift { get; set; }
        public bool CarPark { get; set; }
    }
}
