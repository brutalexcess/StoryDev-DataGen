using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sddg
{
    [System.AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class ControlType : Attribute
    {
        public string controlType;
        public bool Identifier;

        public ControlType(string type, bool identifier = false)
        {
            controlType = type;
            Identifier = identifier;
        }

    }
}
