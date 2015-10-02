using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfContacts.Classes
{
    // Class to generate unique ID for contact entries
    public class ID
    {
        // Value to indicate null ID
        public const int NullId = 0;

        // Initialize ID
        static int Id = NullId;

        // Generate new ID by incrementing
        public static int getNewId ()
        {
            ++Id;
            return Id;
        }
    }
}
