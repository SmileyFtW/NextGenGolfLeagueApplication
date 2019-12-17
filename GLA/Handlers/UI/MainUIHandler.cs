using GLA.Interfaces;
using GLA.UI.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA.Handlers.UI
{
    class MainUIHandler : IMainUIHandler
    {
        public IPlayerMgtUIHandler HandlerNewPlayer { get; }
        public MainUIHandler()
        {
            HandlerNewPlayer = new PlayerMgtUIHandler();
        }
    }
}
