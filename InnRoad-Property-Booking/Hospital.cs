using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnRoad_Property_Booking
{
    class Hospital : Property
    {
      
        public int no_of_doctors;
        public int no_of_nurses;

        public Hospital(int i, string n,Address a,string web,int la,int pc,int nr,int nf,int nd,int nn)
        {
            id = i;
            name = n;
            address = a;
            website = web;
            landarea = la;
            PropertyCost = pc;
            no_of_rooms = nr;
            no_of_floors = nf;
            no_of_doctors = nd;
            no_of_nurses = nn;



        }


        public override void ShowPropertyDesctiption()
        {
            
        }
    }
}
