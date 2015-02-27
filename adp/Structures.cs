using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Web.Helpers;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using System.CodeDom;
using Microsoft.CSharp;
using System.Text.RegularExpressions;

namespace sddg
{
    public class Structure
    {

        private static List<StructureType> structures;
        internal static List<StructureType> Structures
        {
            get
            {
                if (structures == null)
                    structures = new List<StructureType>();
                return structures;
            }
            private set
            {
                structures = value;
            }
        }

        public static void Save()
        {
            var stj = new List<StructureTypeJson>();
            foreach (StructureType item in Structures)
            {
                var obj = new StructureTypeJson();
                obj.ClassCode = item.ClassCode;
                foreach (dynamic listItem in item.ClassDataList)
                {
                    obj.Location.Add(listItem.Location);
                }
                stj.Add(obj);
            }
            File.WriteAllText("structures.json", Json.Encode(stj));
        }

        public static void Load()
        {
            if (!File.Exists("structures.json")) return;
            var stj = new List<StructureTypeJson>();
            stj = Json.Decode<List<StructureTypeJson>>(File.ReadAllText("structures.json"));

            foreach (var item in stj)
            {
                Add(item.ClassCode);
                foreach (string location in item.Location)
                {
                    var structureListItem = Structures[stj.IndexOf(item)];
                    var obj = Activator.CreateInstance(typeof(DataList<>).MakeGenericType(structureListItem.ClassType), location);
                    Type t = structureListItem.ClassDataList.GetType();
                    t.GetMethod("Add").Invoke(structureListItem.ClassDataList, new object[] { obj });
                }
            }
        }

        public static bool Add(string code)
        {
            var matchName = Regex.Match(code, @"(class)\s(\w+)");
            var className = matchName.Groups[2].Value;

            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();
            parameters.ReferencedAssemblies.Add("sddg.exe");
            parameters.GenerateInMemory = true;
            parameters.GenerateExecutable = false;
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, code);

            if (results.Errors.HasErrors)
            {
                StringBuilder sb = new StringBuilder();

                foreach (CompilerError err in results.Errors)
                {
                    sb.AppendLine(String.Format("Error ({0}): {1}", err.ErrorNumber, err.ErrorText));
                }

                MessageBox.Show("Errors were found:\n" + sb.ToString());
                return false;
            }

            Assembly compiled = results.CompiledAssembly;
            Type classType = compiled.GetType("sddg." + className);

            var st = new StructureType();
            st.ClassType = classType;
            st.ClassName = className;
            st.ClassCode = code;

            var type = typeof(DataList<>).MakeGenericType(classType);
            var typeList = typeof(List<>).MakeGenericType(type);
            st.ClassDataList = Activator.CreateInstance(typeList);
            st.ListType = st.ClassDataList.GetType();

            Structures.Add(st);
            return true;
        }

    }

    public struct StructureType
    {
        public string ClassName;
        public Type ClassType;
        public string ClassCode;
        public dynamic ClassDataList;
        public Type ListType;
    }

    public struct StructureTypeJson
    {
        public string ClassCode;
        public List<string> Location;
    }
}
