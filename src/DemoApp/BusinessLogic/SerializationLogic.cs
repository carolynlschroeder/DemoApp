using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace DemoApp.BusinessLogic
{
    public class SerializationLogic<T>
    {

        public static string Serialize(T m)
        {
            return JsonConvert.SerializeObject(m);
        }

        public static T Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }

}