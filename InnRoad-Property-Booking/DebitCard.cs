﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnRoad_Property_Booking
{
    class DebitCard : PaymentMode
    {
        public override void pay()
        {
            Console.WriteLine(" Paid via card ");
        }

    }
}
