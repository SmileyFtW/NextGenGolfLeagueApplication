using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA.Interfaces
{
    public interface INameOfPerson
    {
        string First{get; set;}
        string Middle{get; set;}
        string Last{get; set;}
        string Suffix{get; set;}
        string FullName();
    }
}
