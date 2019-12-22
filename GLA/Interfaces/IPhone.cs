using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA.Interfaces
{
    interface IPhone
    {
        bool IsMobile{get;set;}
        string Code{get;set;}
        string Prefix{get;set;}
        string Number{get;set;}
        bool IsPrimary{get;set;}
    }
}
