using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Serialization;
using System.IO;

namespace Serializer
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            var input = new Input { K = 10, Sums = new decimal[]{ 1.01M, 2.02M }, Muls = new int[]{ 1, 4 } };//разбить str на объект
            ISerializer serializer;
            var type = Console.ReadLine();
            if (type == "json")
                serializer = new JSONSerializer();
            else
                serializer = new XMLSerializer();

            var str = serializer.Serialize<Input>(input);
            var obj = serializer.Deserialize<Input>(str);

            Console.WriteLine(str);
            Console.WriteLine(obj);
            Console.ReadLine();
        }
    }
}
