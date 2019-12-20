using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA.Interfaces
{
    interface IPlayerMgtUIHandler
    {
        List<IPlayer> NewPlayers { get; } //TODO this should be a HashSet not a Dictionary
        void AddNewPlayer(string idPrefix, string idSeparator, int idSeqNumber,int idNumDigits);
    }
}
