using GLA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA.Models
{
    class Email : IEmail
    {
        string _address;
        bool _isPrimary;

        public string Address{get;set;}
        public bool IsPrimary { get; set; }
    }
}
