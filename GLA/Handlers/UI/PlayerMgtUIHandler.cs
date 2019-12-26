using GLA.Interfaces;
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
        public List<IPlayer> NewPlayers { get; protected set; } //TODO change List to HashSet



        public void AddNewPlayer(string idPrefix, string idSeparator, int idSeqNumber,int idNumDigits)
        {
            IPlayer player=new Player(idPrefix,idSeparator,idSeqNumber,idNumDigits);
            NewPlayers.Add(player);
        }

        public void AddNewPlayer()
        {
            IPlayer player = new Player();
            NewPlayers.Add(player);
        }

        public PlayerMgtUIHandler()
        {
            NewPlayers = new List<IPlayer>();
        }

    }
}
