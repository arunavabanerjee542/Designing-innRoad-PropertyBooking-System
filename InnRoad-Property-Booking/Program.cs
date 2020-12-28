using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnRoad_Property_Booking
{
    public enum PropertyBookingCost
    {
        Hotel = 20000,
        Hospital = 30000
    }



    class Program
    {
        static void Main(string[] args)
        {
            // Property
            Property prop = new Hotel(1, "Hotel Inn", new Address("India", "WB", "KOLKATA", " MG ROAD", 713336),"www.hinn.in",240,144,12,49,80,51);

            // user is willing to add the property

            User user = new User();

            user.book(prop);

            // payment window for the user

            user.MakePayment(prop);

            // system will verify and send notification to Vise President

            System sys = new System();

            sys.SendNotification(new MailMessage(),prop.p);
            











        }
    }
}
