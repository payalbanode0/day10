using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4_DeleteContact
{
    class AddBook
    {
        static void Main(string[] args)
        {
            UC4_DeleteContact.AddrBook.GetCustomer();
            UC4_DeleteContact.AddrBook.Modify();
            UC4_DeleteContact.AddrBook.ListingPeople();
            UC4_DeleteContact.AddrBook.RemovePeople();

        }
    }
}