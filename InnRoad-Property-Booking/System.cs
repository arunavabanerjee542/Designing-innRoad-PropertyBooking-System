using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnRoad_Property_Booking
{
    class System
    {
        public bool IsPaymentdone(Payment p)
        {
         

           if((int)p.paystatus == 0)
            {
                return true;
            }

            return false;
        }


        public void SendNotification(Message m,Payment p)
        {
            if(IsPaymentdone(p))
            {
                m.send();
            }
            else
            {
                Console.WriteLine(" NO PAYMENT MADE ");
            }

        }




    }
}
