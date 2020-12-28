using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnRoad_Property_Booking
{
    class User
    {
        public string name { get; set; }


        public void book(Property p)
        {

            Manager m1 = new Manager();
            m1.AddServices(p);
             // we will call the addservice method of manager class
        }

        public void cancelbooking(Property p)
        {
            // we will call the removeservice method of manager class 
        }

        public void MakePayment(Property prop)
        {

            prop.p = new Payment();

            prop.p.amount = (int)PropertyBookingCost.Hotel;

            prop.p.paymentid = 123;

            prop.p.paymentmode = new DebitCard();

            prop.p.paymentmode.pay();

            prop.p.paystatus = PaymentStatus.Paid;




        }

        public void ViewAvailableServices()
        {

        }



    }
}
