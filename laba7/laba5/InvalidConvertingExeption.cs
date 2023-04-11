using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    public class InvalidConvertingException : FormatException
    {
        private string _rtype = "";

        public InvalidConvertingException(string m, string type) : base(m)
        {
            switch (type)
            {
                case "StringToNumber":
                    _rtype = "int";
                    break;
                case "ParseDouble":
                    _rtype = "double";
                    break;
                case "ThrowOverflowOrFormatException":
                    _rtype = "long";
                    break;
            }
        }
        public string GetRtype() { return _rtype; }
    }
}
