using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WindowsFormsApp1.Impl
{
    public class Storage
    {
        public static void SerializeToJson(object Object, string jsonFile)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string data = serializer.Serialize(Object);

            string path = Path.Combine(Environment.CurrentDirectory, jsonFile);
            File.WriteAllText(path, data);
        }

        public static object DeserializeFromJson(object Object, string jsonFile)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string path = Path.Combine(Environment.CurrentDirectory, jsonFile);

            if (File.Exists(path))
            {
                string data = File.ReadAllText(path);
                Object = serializer.Deserialize<University>(data);
            }
            return Object;
            
        }
    }
}
