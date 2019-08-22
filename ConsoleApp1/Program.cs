using System;
using System.IO;
using Newtonsoft.Json;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlReader xmlReader = new XmlReader();
            JsonData jdata = new JsonData();
            SendJson jSend = new SendJson();

            jdata.Teststep = xmlReader.readXml();

            jSend.Send(JsonConvert.SerializeObject(jdata));

            File.WriteAllText(@"testcase.json", JsonConvert.SerializeObject(jdata));

            Console.ReadKey();
        }
    }
}
