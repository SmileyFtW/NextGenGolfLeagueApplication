﻿using GLA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA.Models
{
    class Phone : IPhone
    {
        public bool IsMobile { get; set; }
        public string Code { get; set; }
        public string Prefix { get; set; }
        public string Number { get; set; }
        public bool IsPrimary { get; set; }
    }
}
