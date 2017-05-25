using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SessionApp
{
    [Serializable]
    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public  string CellNumber { get;  set; }

        public Contact(string name, string email, string cellNumber)
        {
            Name = name;
            Email = email;
            CellNumber = cellNumber;
        }

        public Contact()
        {
            
        }
    }
}