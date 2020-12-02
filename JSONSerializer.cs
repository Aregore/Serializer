using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer
{
    class JSONSerializer : ISerializer
    {
        public T Deserialize<T>(string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }

        public string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);

        }
    }
}
