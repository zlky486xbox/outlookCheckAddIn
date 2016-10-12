using System;
using System.Windows.Forms;
using System.Xml;


namespace CheckAddIn
{
    public partial class SettingForm : Form
    {
        string filename = "D://WhiteXML.xml";
        XMLDAL xdal = new XMLDAL();
        public SettingForm()
        {
            InitializeComponent();
            Load_WhiteList();
        }

        void Load_WhiteList()
        {
            this.LB_White.Items.Clear();
            XmlDocument readxml = new XmlDocument();
            readxml.Load(filename);
            XmlNode rootele = readxml.DocumentElement;
            recursiveLoadXML(rootele);
        }
        private void recursiveLoadXML(XmlNode xnode)
        {
           
            foreach (XmlNode childNode in xnode.ChildNodes)
            {
                if (childNode.NodeType == XmlNodeType.Element)
                {   
                    recursiveLoadXML(childNode);
                }
                else if (childNode.NodeType == XmlNodeType.Text)
                {
                    if (childNode.ParentNode.Name == "URL")
                    {
                        this.LB_White.Items.Add( childNode.Value);                       
                    }                             
                }
            }

        }
        private void BT_Add_Click(object sender, EventArgs e)
        {
            if(tb_add_white.Text!=string.Empty)
            {
                XMLDAL.Insert(tb_add_white.Text);
                Load_WhiteList();
            }
            else
            {
                MessageBox.Show("请填写添加项！");
            }

            
        }

        private void BT_Del_Click(object sender, EventArgs e)
        {
            XmlDocument delxml = new XmlDocument();
            delxml.Load(filename);
            XmlNode rootnode = delxml.DocumentElement;
            string del_url = "";
            del_url = LB_White.SelectedItem.ToString();
            if (MessageBox.Show("确定要将" + del_url + "移除白名单？", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                XMLDAL.Delete(rootnode, del_url);
                MessageBox.Show("已将" + del_url + "移除白名单");
                delxml.Save(filename);
                Load_WhiteList();
            }
        }
    }
}
