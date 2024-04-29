using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.VeiwModels.Helpers
{
    internal class JsonHelper
    {
        public static T Read<T>(string filename)
        {
            T types = JsonConvert.DeserializeObject<T>(File.ReadAllText(filename));
            return types;
        }

        public static void Write<T>(T types, string filename)
        {
            File.WriteAllText(filename, JsonConvert.SerializeObject(types));
        }
    }
}