using System;
using System.Collections.Generic;
using System.Xml.Linq;


namespace ConsoleApp1
{
    class XmlReader
    {
        XDocument xdoc;
        public List<TestCase> testList;
        TestCase testItem;

        public XmlReader()
        {
            xdoc = XDocument.Load("xmldoc.xml");
            testList = new List<TestCase>();
        }
    public List<TestCase> readXml()
    {
            foreach (var item in xdoc.Element("testcase").Elements("teststep"))
            {
                testItem = new TestCase();
                testItem.Name = item.Attribute("name").Value;
                testItem.Priority = item.Attribute("priority").Value;
                testItem.Component = item.Attribute("component").Value;
                testItem.Description = item.Value;
                testList.Add(testItem);
            }
            return testList;
        }
    }
}
