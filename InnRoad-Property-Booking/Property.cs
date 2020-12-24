using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnRoad_Property_Booking
{
    abstract class Property
    {
        public int id;
        public string name;
        public Address address;
        public string website;
        public int landarea;
        public int PropertyCost;
        public int no_of_rooms;
        public int no_of_floors;

        public abstract void ShowPropertyDesctiption();

    }
}
