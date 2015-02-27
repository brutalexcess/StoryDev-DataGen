using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sddg
{
    [AttributeUsage(AttributeTargets.Field)]
    public class JsonCategory : Attribute
    {
        public string Name;

        public JsonCategory(string name)
        {
            Name = name;
        }
    }
}
