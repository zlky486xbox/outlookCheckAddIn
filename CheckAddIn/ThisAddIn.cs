using Outlook = Microsoft.Office.Interop.Outlook;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace CheckAddIn
{
    public partial class ThisAddIn
    {
        List<string> whitelist = new List<string>();
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            
            Application.ItemSend += new Outlook.ApplicationEvents_11_ItemSendEventHandler(Application_ItemSend);
            Application.ItemLoad += new Outlook.ApplicationEvents_11_ItemLoadEventHandler(ProgramStart);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // 备注: Outlook不会再触发这个事件。如果具有
            //关闭 Outlook 时必须运行的代码，请参阅 http://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO 生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
        void Application_ItemSend(object item,ref bool Cancel)
        {
            List<string> nowhitelist = new List<string>();
            Outlook.MailItem mail = item as Outlook.MailItem;             
            Outlook.Recipients recipients = mail.Recipients;
            if (mail!=null)
            {
                foreach (Outlook.Recipient recipient in recipients)
                {
                    string message = recipient.Address.ToString();
                    if (checkEmailAdd_XML(message)==false)
                    {
                        nowhitelist.Add(message);
                      
                    }
                }
                if(nowhitelist.Count!=0)
                {
                    CheckForm cf = new CheckForm();
                    cf.nowhitelist = nowhitelist;
                    cf.ShowDialog();
                }
                
            }
        }
 
        bool checkEmailAdd_XML(string address)
        {
            bool result=false;
            int x = address.IndexOf("@", 0);
            x++;
            string temp = address.Substring(x, address.Length - x);
           foreach(string whiteadd in whitelist)
            {
                if(whiteadd==temp)
                {
                    result = true;
                }
            }
            return result;
            
            
        }
        void ProgramStart(object item)
        {
            string filename = "D://WhiteXML.xml";
            if (!File.Exists(filename))
            {
                XmlDocument doc = new XmlDocument();
                XmlElement rootElement = doc.CreateElement("root");
                doc.AppendChild(rootElement);
                XmlNode xn = doc.SelectSingleNode("root");
                XmlElement childElement = doc.CreateElement("WhiteList");
                XmlElement URLElement = doc.CreateElement("URL");
                URLElement.InnerText = "mcz.mitsui-chem.com";
                childElement.AppendChild(URLElement);
                rootElement.AppendChild(childElement);
                doc.Save(filename);
                XMLDAL.Insert("mitsuichemicals.com");
            }
            XmlDocument readxml = new XmlDocument();
            readxml.Load(filename);
            XmlElement xnn = readxml.DocumentElement;
            ReadX(xnn);
        }
        void ReadX(XmlNode xnode)
        {
            foreach (XmlNode childNode in xnode.ChildNodes)
            {

                if (childNode.NodeType == XmlNodeType.Element)
                {

                    ReadX(childNode);
                }
                else if (childNode.NodeType == XmlNodeType.Text)
                {
                    if (childNode.ParentNode.Name == "URL")
                    {
                       whitelist.Add(childNode.Value);
                    }
                }
            }
        }
     
      
    }
}
