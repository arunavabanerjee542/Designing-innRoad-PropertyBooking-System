using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnRoad_Property_Booking
{
    class SMSmessage : Message
    {
        public override void send()
        {
            Console.WriteLine(" Payment done And Notification sent to VP via mail ");
        }
    }
}
