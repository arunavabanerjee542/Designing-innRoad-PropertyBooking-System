using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnRoad_Property_Booking
{
    public enum PaymentStatus
    {
        Paid , NotPaid 
    }



    class Payment
    {
          public int amount;
          public int paymentid;
          public PaymentStatus paystatus; // declared above
          public  PaymentMode paymentmode;

       

    }
}
