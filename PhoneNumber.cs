using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimMaiAssign4
{
    public class PhoneNumber
    {
        // private instance variable for storing the formatted phone number.
        private string phoneNumberValue = "";

        // read-only property to get area code
        public string AreaCode
        {
            get
            {
                return phoneNumberValue.Substring(0, 3);
            }
        }

        // returns string representation of PhoneNumber object.
        public override string ToString()
        {
            if (phoneNumberValue == "")
                return "";
            else
                return "("
                        + phoneNumberValue.Substring(0, 3)
                        + ")"
                        + phoneNumberValue.Substring(3, 3)
                        + "-"
                        + phoneNumberValue.Substring(6, 4);
        }

        // Constructor
        public PhoneNumber(string phoneNumber)
        {
            // check whether string is empty.
            if (phoneNumber == "")
                return;
            // extract numeric digits
            foreach (char c in phoneNumber)
            {
                if (c >= '0' && c <= '9')
                {
                    phoneNumberValue += c;
                }
            }
        }
    }
}
