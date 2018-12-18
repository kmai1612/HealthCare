using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimMaiAssign4
{
    public class Patient
    {
        // private instance variable for storing first name
        private string firstNameValue;

        // private instance variable for storing last name
        private string lastNameValue;

        // private instance variable for storing birth date
        private DateTime birthDateValue;

        
        public Patient()
        {
        }

        
        public Patient(string first, string last, bool married, string gender,decimal salary, DateTime birthDate, Address homeAddress, PhoneNumber homePhone, PhoneNumber cellPhone)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Married = married;
            this.Salary = salary;
            this.Gender = gender;
            this.BirthDate = birthDate;
            this.HomeAddress = homeAddress;
            this.HomePhone = homePhone;
            this.CellPhone = cellPhone;
        } // end Employee constructor

        // property to get and set patient's first name
        public string FirstName
        {
            get
            {
                return Utility.Capitalize(firstNameValue);
            } // end get
            set
            {
                value = value.Trim().ToUpper();
                firstNameValue = value;
            } // end set
        } // end property FirstName

        // property to get and set patient's last name
        public string LastName
        {
            get
            {
                return Utility.Capitalize(lastNameValue);
            } // end get
            set
            {
                value = value.Trim().ToUpper();
                lastNameValue = value;
            } // end set
        } // end property LastName

        // read-only property to get patient's name
        public string Name
        {
            get
            {
                return LastName + ", " + FirstName;
            } // end get
        } // end property Name

        // property to get and set whether patient is married
        public bool Married { get; set; }

        // read-only property to get patient's marital status
        public string MaritalStatus
        {
            get
            {
                if (Married)
                    return "Married";
                else
                    return "Single";
            } // end get
        } // end property Name

        // property to get and set whether patient is male
        public bool IsMale { get; set; }

        // property to get and set whether patient is female
        public bool IsFemale
        {
            get
            {
                return !IsMale;
            } // end get
            set
            {
                IsMale = !value;
            } // end set
        } // end property IsFemale

        // property to get and set patient's gender
        public string Gender
        {
            get
            {
                if (IsMale)
                    return "Male";
                else
                    return "Female";
            } // end get
            set
            {
                value = value.ToUpper();
                if (value == "MALE" || value == "M")
                    IsMale = true;
                else if (value == "FEMALE" || value == "F")
                    IsMale = false;
            } // end set
        } // end property Gender

        // read-only property to get patient's title
        public string Title
        {
            get
            {
                if (IsMale)
                    return "Mr.";
                else
                    return "Ms.";
            } // end get
        } // end property Title

        // read-only property to get patient's title and name
        public string TitleName
        {
            get
            {
                return Title + " " + Name;
            } // end get
        } // end property TitleName

        // property to get and set patient's birth date
        public DateTime BirthDate
        {
            get
            {
                return birthDateValue;
            } // end get
            set
            {
                birthDateValue = value;
            } // end set
        } // end property BirthDate

        // read-only property to get patient's age
        public byte Age
        {
            get
            {
                // Get the birth date value 

                DateTime thisYearBirthDate = new DateTime(DateTime.Now.Year, BirthDate.Month, BirthDate.Day);

                // Calculate and return the age 

                if (thisYearBirthDate <= DateTime.Now)
                {
                    return (byte)(DateTime.Now.Year - BirthDate.Year);
                }
                else
                {
                    return (byte)(DateTime.Now.Year - BirthDate.Year - 1);
                }
            }
        }

        public Decimal Salary { get; set; }
        // property to get and set patient's home address
        public Address HomeAddress { get; set; }

        // property to get and set patient's home phone
        public PhoneNumber HomePhone { get; set; }

        // property to get and set patient's cell phone
        public PhoneNumber CellPhone { get; set; }

        // returns string representation of patient object
        public override string ToString()
        {
            return TitleName + "\t"
            + MaritalStatus + ""         
            + " Age: "+ Age + ",  "
            +"Expenses: " +Salary.ToString("C") +  ". "
            + HomeAddress + ". "
            + HomePhone.ToString() + "/"
            + CellPhone.ToString() + "\t";
            

        } // end method ToString

    }
}
