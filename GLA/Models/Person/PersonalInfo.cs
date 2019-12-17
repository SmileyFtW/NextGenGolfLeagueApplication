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
        List<IPhone> _phones;
        List<IEmail> _emails;
        INameOfPerson _nameOfPerson;

        INameOfPerson IPersonalInfo.NameOfPerson
        {
            get
            {
                return _nameOfPerson;
            }
        }

        List<IEmail> IPersonalInfo.Emails
        {
            get
            {
                return _emails;
            }
        }

        List<IPhone> IPersonalInfo.Phones
        {
            get
            {
                return _phones;
            }
        }

   
        public PersonalInfo ()
        {
            INameOfPerson _nameOfPerson = new NameOfPerson();
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
