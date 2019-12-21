﻿using GLA.Interfaces;
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

        public IIDItem ID { get; protected set; }
        public IPersonalInfo PersonalInfo { get; protected set; }

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
            ID = new IDItem(idPrefix, idSeparator, idSeqNumber, idNumDigits);
            PersonalInfo = new PersonalInfo();
        }
    }

}
