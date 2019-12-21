using GLA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA.Models
{
    class PersonalInfo : IPersonalInfo
    {
        public INameOfPerson NameOfPerson{ get; protected set; }
        
        //TODO change each List<> to a HashSet<>
        public List<IEmail> Emails{ get; protected set; }
        public List<IPhone> Phones{ get; protected set; }

        public PersonalInfo ()
        {
            NameOfPerson = new NameOfPerson();
            Phones = new List<IPhone>();
            Emails = new List<IEmail>();
        }
        /* These are potential overloads
         * Depending on how the Contructors may be called these may be usable in the future
        
        public PersonalInfo(List<IPhone> phones)
        {
            INameOfPerson _nameOfPerson = new NameOfPerson();
            _phones = phones;
        }
        public PersonalInfo(List<IEmail> emails)
        {
            INameOfPerson _nameOfPerson = new NameOfPerson();
            _emails = emails;
        }
        public PersonalInfo(List<IPhone> phones, List<IEmail> emails)
        {
            INameOfPerson _nameOfPerson = new NameOfPerson();
            _phones = phones;
            _emails = emails;
        }

        */
    }
}
