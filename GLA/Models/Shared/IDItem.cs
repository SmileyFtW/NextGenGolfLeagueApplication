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

        public string ID
        {
            get
            {
                string result="";

                if (InputIsEmpty(_prefix))
                {
                    result = "No Prefix";

                    //return _prefix + _separator + _seqnumber.ToString().PadLeft(_seqnumberNumDigits, '0');
                }
                if(InputIsEmpty(_separator))
                {
                    if (result == "")
                    {
                        result = "No Separator";
                    }
                    else
                    {
                        result += " and No Separator";
                    }
                }

                if (SeqNumberCompatibleWithNumberOfDigits(_seqnumber, _seqnumberNumDigits) == false)
                {
                    if (result != "")
                    {
                        result += " / ";
                    }
                    result += "Seq Number (" + _seqnumber + ") incompatible with Number of Digits (" + _seqnumberNumDigits + ")";
                }

                if (result == "")
                {
                    return _prefix + _separator + _seqnumber.ToString().PadLeft(_seqnumberNumDigits, '0');
                }
                else
                {
                    return result;
                }
            }
        }
        public bool InputIsEmpty(string input)
        {
            return (input == null || input=="");
        }

        public bool SeqNumberCompatibleWithNumberOfDigits(int SeqNumber, int NumberOfDigits)
        {
                if (NumberOfDigits > (SeqNumber.ToString().Length - 1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
        } 

        public bool HasID { get; }
        public bool IsValidID { get; }

        //Constructors
        public IDItem()
        {
            HasID = false;
            IsValidID=false;
        }
        public IDItem (string Prefix, string Separator, int SeqNumber, int NumberOfDigits)
        {
            if (SeqNumberCompatibleWithNumberOfDigits(SeqNumber, NumberOfDigits))
            {
                IsValidID = true;
                HasID = true;
                _prefix = Prefix;
                _separator = Separator;
                _seqnumber = SeqNumber;
                _seqnumberNumDigits = NumberOfDigits;
            }
            else
            {
                IsValidID = false;
                HasID = false;
            }
        }
    }
}
