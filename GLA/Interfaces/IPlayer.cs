using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA.Interfaces
{
    public interface IPlayer
    {
        IIDItem IDItem { get; } 
        IPersonalInfo PersonalInfo { get; }
    }
}
