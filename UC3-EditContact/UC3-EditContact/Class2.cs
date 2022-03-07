using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3EditContact
{
    class AddBook
    {
        static void Main(string[] args)
        {
            UC3EditContact.AddrBook.GetCustomer();
            UC3EditContact.AddrBook.Modify();
            UC3EditContact.AddrBook.ListingPeople();
            // Sample.AddrBook.RemovePeople();

        }
    }
}
