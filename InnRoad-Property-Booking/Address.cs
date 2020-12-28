namespace InnRoad_Property_Booking
{
    public class Address
    {
        public string country;
        public string state;
        public string city;
        public string street;
        public int pin;

        public Address(string c,string s,string City,string str,int p)
        {
            country = c;
            state = s;
            city = City;
            str = street;
            p = pin;

        }


    }
}