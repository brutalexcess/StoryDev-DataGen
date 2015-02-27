using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sddg
{
    [System.AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class JsonControlType : Attribute
    {
        public string controlType;
        public bool Identifier;
        public string FieldTitle;

        public JsonControlType(string type, string fieldTitle = "",  bool identifier = false)
        {
            controlType = type;
            Identifier = identifier;
            FieldTitle = fieldTitle;
        }

    }
}
