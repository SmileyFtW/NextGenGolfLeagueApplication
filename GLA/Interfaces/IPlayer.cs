using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA.Interfaces
{
    class IPlayer
    {
        IIDItem ID { get; } 
        IPersonalInfo PersonalInfo { get; }
    }
}
