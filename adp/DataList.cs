using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Helpers;

namespace sddg
{
    public class DataList<T>
    {
        public string Location;

        private List<T> data;
        public List<T> Data
        {
            get { return data; }
            private set { data = value; }
        }

        public DataList(string path)
        {
            Location = path;
            var dir = path.Substring(0, path.LastIndexOf('\\'));
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            Data = new List<T>();
        }

        public void Save()
        {
            File.WriteAllText(Location, Json.Encode(Data));
        }

        public void Load()
        {
            Data = Json.Decode<List<T>>(File.ReadAllText(Location));
        }

    }
}
