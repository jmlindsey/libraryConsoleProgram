using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgram
{
    class Address
    {
        private String streetAddress;
        private String city;
        private String state;
        private String zipcode;

        public Address(String streetAddress, String city, String state, String zipcode)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
        }

        public override string ToString()
        {
            return String.Format("\n{0}\n{1}\n{2}\n{3}\n", streetAddress, city, state, zipcode);
        }

        public static Address ParseToAddress(String addressString)
        {
            String[] addressList = addressString.Split(',');
            return new Address(addressList[0], addressList[1], addressList[2], addressList[3]);
        }
    }
}
