using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA.Interfaces
{
    class IPersonalInfo
    {
        IIDItem id { get; }
        INameOfPerson nameOfPerson { get; }
        List<IEmail> emails { get; }
        List<IPhone> phones { get; }
    }
}
