using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ForTheExam.Library
{
    public class Storage
    {
        public void Save(List<Information> info)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(@"data.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, info);
                sw.Close();
            }
        }

        public List<Information> Load()
        {
            JsonSerializer serializer = new JsonSerializer();
            List<Information> result = new List<Information>();

            using (StreamReader sr = new StreamReader(@"data.xml"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                result = serializer.Deserialize<List<Information>>(reader);
                sr.Close();
            }

            return result;
        }

        //For the tests
        public void Save(List<Information> info, string file)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter($@"{file}.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, info);
                sw.Close();
            }
        }

        public List<Information> Load(string file)
        {
            JsonSerializer serializer = new JsonSerializer();
            List<Information> result = new List<Information>();

            using (StreamReader sr = new StreamReader($@"{file}.json"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                result = serializer.Deserialize<List<Information>>(reader);
                sr.Close();
            }

            return result;
        }
    }
}
