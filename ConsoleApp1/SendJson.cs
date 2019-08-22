using System;
using System.IO;
using System.Net;


namespace ConsoleApp1
{
    class SendJson
    {
        public void Send(string json)
        {
            var httpRequest = (HttpWebRequest)WebRequest.Create("http://ooo.ru");
            httpRequest.Method = "POST";
            httpRequest.ContentType = "application/json";

            using (var requestStream = httpRequest.GetRequestStream())

            using (var writer = new StreamWriter(requestStream))
            {
                writer.Write(json);
            }

            using (var httpResponse = httpRequest.GetResponse())
            using (var responseStream = httpResponse.GetResponseStream())
            using (var reader = new StreamReader(responseStream))
            {
                string response = reader.ReadToEnd();
            }
        }
    }
}
