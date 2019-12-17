using GLA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA.Models
{
    class Player : IPlayer
    {
        IIDItem _id;
        IPersonalInfo _personalInfo;

        IIDItem ID { get; }
        IPersonalInfo PersonalInfo {get;}
        //TODO add remaining properties

        public Player(string idPrefix,string idSeparator, int idSeqNumber,int idNumDigits)
        {
            IIDItem _id = new IDItem(idPrefix, idSeparator, idSeqNumber, idNumDigits);
            IPersonalInfo _personalInfo = new PersonalInfo();
        }
    }

}
