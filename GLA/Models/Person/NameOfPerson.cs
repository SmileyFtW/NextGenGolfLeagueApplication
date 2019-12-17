using GLA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA.Models
{
    class NameOfPerson : INameOfPerson
    {
        string _first;
        string _middle;
        string _last;
        string _suffix;

        public string First { get; set; }
        public string Middle { get; set; }
        public string Last { get; set; }
        public string Suffix { get; set; }

        string FullNameLastFirst()
        {
            string result = _last + ", " + _first;
            if (_middle != "")
            {
                result = result + " " + _middle;
            }
            if (_suffix != "")
            {
                result = result + ", " + _suffix;
            }
            return result;
        }
        public string FullName()
        {
            string result = _first;
            if (_middle != "")
            {
                result = result + " " + _middle;
            }
            result = result + " " + _last;
            if (_suffix != "")
            {
                result = result + ", " + _suffix;
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
        public NameOfPerson ()
        {
            _first = "First Name";
            _middle = "Middle Intitial or Name";
            _last = "Last Name";
            _suffix = "Jr., Sr., etc.";
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
