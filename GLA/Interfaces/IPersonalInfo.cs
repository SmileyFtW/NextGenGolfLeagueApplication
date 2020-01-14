using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA.Interfaces
{
    public interface IPersonalInfo
    {
        INameOfPerson NameOfPerson { get; }
        List<IEmail> Emails { get; }
        List<IPhone> Phones { get; }
    }
}
