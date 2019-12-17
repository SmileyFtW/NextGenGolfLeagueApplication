using GLA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA.Models
{
    class IDItem : IIDItem
    {
        string _prefix;
        string _separator;
        int _seqnumber;
        int _seqnumberNumDigits;

        public string ID()
        {
            return _prefix + _separator + _seqnumber.ToString().PadLeft(_seqnumberNumDigits,'0');
        }
        public IDItem (string Prefix, string Separator, int SeqNumber, int NumberOfDigits)
        {
            _prefix = Prefix;
            _separator = Separator;
            _seqnumber = SeqNumber;
            _seqnumberNumDigits = NumberOfDigits;
        }
    }
}
