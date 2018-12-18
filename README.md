using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimMaiAssign4
{
    public class Program
    {
   
        private static void Add(Patient patient)
        {
            string answer;
            bool ok;

            // enter first name
            Console.Write("First Name: ");
            patient.FirstName = Console.ReadLine();

            // enter last name
            Console.Write("Last Name: ");
            patient.LastName = Console.ReadLine();

            // gender
            do
            {
                ok = true;
                Console.Write("Gender(M/F): ");
                answer = Console.ReadLine().Trim();
                if (answer.Length < 1)
                {
                    ok = false;
                    continue;
                }
                switch (answer.ToUpper()[0])
                {
                    case 'M':
                        patient.Gender = "M";
                        break;
                    case 'F':
                        patient.Gender = "Female";
                        break;
                    default:
                        ok = false;
                        break;
                }
            }
            while (!ok);

            do
            {
                ok = true;
                Console.Write("Married (Y/N): ");
                answer = Console.ReadLine().Trim();
                if (answer.Length < 1)
                {
                    ok = false;
                    continue;
                }
                switch (answer.ToUpper()[0])
                {
                    case 'Y':
                        patient.Married = true;
                        break;
                    case 'N':
                        patient.Married = false;
                        break;
                    default:
                        ok = false;
                        break;     
        }
            }
            while (!ok);



            // birth date
            Console.Write("Birth Date: ");
            patient.BirthDate = DateTime.Parse(Console.ReadLine());


            //Enter Salary 
            Console.Write("Expenses ($): ");
           patient.Salary = decimal.Parse(Console.ReadLine());

            // address
            patient.HomeAddress = new Address();

            // street
            Console.Write("Street Address: ");
            patient.HomeAddress.Street = Console.ReadLine();

            // city
            Console.Write("City: ");
            patient.HomeAddress.City = Console.ReadLine();

            // state
            Console.Write("State: ");
            patient.HomeAddress.State = Console.ReadLine();

            // zip
            Console.Write("Zip: ");
            patient.HomeAddress.Zip = Console.ReadLine();

            // home phone
            Console.Write("Home Phone: ");
            patient.HomePhone = new PhoneNumber(Console.ReadLine());

            // work phone
            Console.Write("Cell Phone: ");
            patient.CellPhone = new PhoneNumber(Console.ReadLine());

        }

        // The main menu
        private void Menu()
        {
            bool quit = false;
            bool valid;
            string choice;
            Patient patient;

            Console.WriteLine("Welcome to the CCHI Insurance Coverage System!");

            do
            {
                Console.WriteLine("Enter data about a patient");
                Console.WriteLine();
                patient = new Patient();
                Add(patient);
                Console.WriteLine();
                Console.WriteLine(patient.ToString());
                

                Console.WriteLine();
                do
                {
                    valid = true;
                    Console.Write("Do you want to quit (Y/N)?: ");
                    choice = Console.ReadLine().Trim();
                    if (choice.Length < 1)
                    {
                        valid = false;
                        continue;
                    }
                    Console.WriteLine();
                    switch (choice.ToUpper()[0])
                    {
                        case 'N':
                            quit = false;
                            break;
                        case 'Y':
                            quit = true;
                            break;
                        default:
                            valid = false;
                            break;
                    }
                } while (!valid);
            }
            while (!quit);


            Console.WriteLine();
            Console.WriteLine("Thank you for using the CCHI Insurance Coverage System!");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Program sys = new Program();
            sys.Menu();
        }
    }
}
