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
        //IIDItem id;
        //IPersonalInfo personalInfo;

        public IIDItem ID { get; }
        public IPersonalInfo PersonalInfo {get;}

        //TODO add remaining properties
        /*
         * CourseStatus
         * LeagueStatus
         * Scores
         * ScoreResults
         * Handicaps
         * Team
         * Fees
         * Authorities
         */
        public Player(string idPrefix,string idSeparator, int idSeqNumber,int idNumDigits)
        {
            IIDItem id = new IDItem(idPrefix, idSeparator, idSeqNumber, idNumDigits);
            IPersonalInfo personalInfo = new PersonalInfo();
        }
    }

}
