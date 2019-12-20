﻿using GLA.Interfaces;
using GLA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA.UI.Handlers
{
    class PlayerMgtUIHandler  : IPlayerMgtUIHandler 
    {
        public List<IPlayer> NewPlayers { get; } //TODO change Dictionary to HashSet

        public void AddNewPlayer(string idPrefix, string idSeparator, int idSeqNumber,int idNumDigits)
        {
            IPlayer player=new Player(idPrefix,idSeparator,idSeqNumber,idNumDigits);
            NewPlayers.Add(player);
        }
         
        public PlayerMgtUIHandler()
        {
            List<IPlayer> newPlayers = new List<IPlayer>();
        }

    }
}
