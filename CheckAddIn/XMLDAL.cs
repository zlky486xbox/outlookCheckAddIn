using System.Xml;

namespace CheckAddIn
{
    class XMLDAL
    {
        private static string _path = "D://WhiteXML.xml";  
        public static void Insert(string _URL)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(_path);
                XmlNode xn = doc.SelectSingleNode("root");
                XmlElement childElement = doc.CreateElement("WhiteList");
                XmlElement URLElement = doc.CreateElement("URL");
                URLElement.InnerText = _URL;
                childElement.AppendChild(URLElement);
                xn.AppendChild(childElement);
                doc.Save(_path);
            }
            catch { }
        }
       
        public static void Delete(XmlNode xnode,string _value)
        {  
            try
            {
                
                foreach(XmlNode item in xnode.ChildNodes)
                {
                    if (item.NodeType == XmlNodeType.Element)
                    {

                        Delete(item,_value);
                    }
                    else if (item.NodeType == XmlNodeType.Text)
                    {
                        if (item.Value == _value)
                        {
                            XmlElement xmle = (XmlElement)item.ParentNode;
                            item.ParentNode.ParentNode.RemoveChild(xmle);
                        }
                    }
                   
                    
                }
       
                
            }
            catch { }
        }
       
    }
}
