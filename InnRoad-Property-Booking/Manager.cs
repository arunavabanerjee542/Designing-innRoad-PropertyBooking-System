using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnRoad_Property_Booking
{
    class Manager
    {
  public  List<Property> plist;

        public Manager()
        {
            plist = new List<Property>();
        }


        public void ShowAllServices()
        {

        }

        public void AddServices(Property p)
        {
            plist.Add(p);
        }

    }
}
