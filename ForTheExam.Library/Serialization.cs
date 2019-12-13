using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace ForTheExam.Library
{
    public class Serialization
    {
        public void Save(List<Information> info)
        {
            StreamWriter sw = new StreamWriter(@"data.xml");
            var xmlSave = new XmlSerializer(typeof(List<Information>));
            xmlSave.Serialize(sw, info);
            sw.Close();
        }

        public List<Information> Load()
        {
            XmlSerializer form = new XmlSerializer(typeof(List<Information>));
            StreamReader sr = new StreamReader(@"data.xml");
            var xmlLoad = form.Deserialize(sr) as List<Information>;
            sr.Close();
            return xmlLoad;
        }
    }
}
