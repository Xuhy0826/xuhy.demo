using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Json.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonStr = File.ReadAllText("./json.json");

            //(1) Deserialize
            var obj = Welcome.FromJson(jsonStr);

            //(2) JObject
            JObject jObject = JObject.Parse(jsonStr);
            Console.WriteLine(jObject["greeting"]);

            Console.WriteLine(jObject["instructions"][0]);

            Console.ReadLine();
        }
    }
}
