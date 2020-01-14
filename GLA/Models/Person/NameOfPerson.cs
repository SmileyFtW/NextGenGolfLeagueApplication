using GLA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA.Models
{
    public class NameOfPerson : INameOfPerson
    {
        public string First { get; set; }
        public string Middle { get; set; }
        public string Last { get; set; }
        public string Suffix { get; set; }

        string FullNameLastFirst()
        {
            string result = Last + ", " + First;
            if (Middle != "")
            {
                result = result + " " + Middle;
            }
            if (Suffix != "")
            {
                result = result + ", " + Suffix;
            }
            return result;
        }
        public string FullName()
        {
            string result = First;
            if (Middle != "")
            {
                result = result + " " + Middle;
            }
            result = result + " " + Last;
            if (Suffix != "")
            {
                result = result + ", " + Suffix;
            }
            return result;
        }
        public string FullName(bool lastFirst)
        {
            if (lastFirst == true)
            {
                return FullNameLastFirst();
            }
            else
            {
                return FullName();
            }
        }

        //Default values for Name
        public NameOfPerson ()
        {
            First = "FirstName";
            Middle = "MiddleIntitialOrName";
            Last = "LastName";
            Suffix = "Jr., Sr., etc.";
        }

         /* This is a potential overload
         * Depending on how the Contructor may be called this may be usable in the future
        
        public NameOfPerson(string firstName, string lastName,string middle, string suffix)
        {
            _first =firstName;
            _middle = middle;
            _last = lastName;
            _suffix =suffix;
        }
        */
    }
}
