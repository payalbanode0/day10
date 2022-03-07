using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC5_MultipleEntries
{
    class Addr
    {
        //main Method-Calling the method present in AddrBook class by using switch case
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System!");
            Console.WriteLine("1.Enter to add the details");
            Console.WriteLine("2.Enter to modify the details");
            Console.WriteLine("3.Listing the details..");
            Console.WriteLine("4.Remove the details");
            Console.WriteLine("Enter a option");
            switch (Console.ReadLine())
            {
                case "1":
                    UC5_MultipleEntries.AddBook.GetCustomer();
                    UC5_MultipleEntries.AddBook.ListingPeople();
                    break;
                case "2":
                    UC5_MultipleEntries.AddBook.GetCustomer();
                    UC5_MultipleEntries.AddBook.Modify();
                    UC5_MultipleEntries.AddBook.ListingPeople();
                    break;
                case "3":
                    UC5_MultipleEntries.AddBook.GetCustomer();
                    UC5_MultipleEntries.AddBook.ListingPeople();
                    break;
                case "4":
                    UC5_MultipleEntries.AddBook.GetCustomer();
                    UC5_MultipleEntries.AddBook.RemovePeople();

                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;

            }



        }
    }
}