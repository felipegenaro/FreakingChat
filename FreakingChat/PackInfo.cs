using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Chat
{
    public class PackInfo
    {
        public string Command { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
        public object Data { get; set; }

        public PackInfo(string command)
        {
            Command = command;
        }

        public void AddParameter(string name, string value)
        {
            if (Parameters == null)
            {
                Parameters = new Dictionary<string, string>();
            }

            Parameters.Add(name, value);
        }

        public string GetParameter(string name, string defaultValue = "")
        {
            if (Parameters != null && Parameters.ContainsKey(name))
            {
                return Parameters[name];
            }

            return defaultValue;
        }

        public T GetData<T>()
        {
            JToken obj = Data as JToken;

            if (obj != null)
            {
                return obj.ToObject<T>();
            }

            return default(T);
        }
    }
}