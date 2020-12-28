using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnRoad_Property_Booking
{
    class Hotel : Property
    {

        public int no_of_chefs;
        public int no_of_waiters;

        public Hotel(int i, string n, Address a, string web, int la, int pc, int nr, int nf, int nc, int nw)
        {
            id = i;
            name = n;
            address = a;
            website = web;
            landarea = la;
            PropertyCost = pc;
            no_of_rooms = nr;
            no_of_floors = nf;
            no_of_chefs = nc;
            no_of_waiters = nw;
           


        }

        public override void ShowPropertyDesctiption()
        {
            
        }
    }
}
