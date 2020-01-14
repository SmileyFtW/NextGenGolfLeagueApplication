using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GLA.Models;

namespace GLA.Interfaces
{
    public interface IEmail
    {
        bool IsPrimary {get;set;}
        string Address{get;set;}
    }
}
