using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace Scouting
{
    class EmbeddedResources
    {
        public static string root_ns = "Scouting";

        public static Dictionary<string, string> _preload = new Dictionary<string, string>();
        public static string sql(string name)
        {
            var res = root_ns + ".sql." + name + ".sql";
            if (_preload.ContainsKey(res)) return _preload[res];

            var asm = Assembly.GetExecutingAssembly();
            using (Stream s = asm.GetManifestResourceStream(res))
            using (StreamReader r = new StreamReader(s))
            {
                string str = r.ReadToEnd();
                _preload[res] = str;
                return str;
            }
        }
    }
}
