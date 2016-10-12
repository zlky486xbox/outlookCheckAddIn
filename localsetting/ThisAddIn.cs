using Outlook = Microsoft.Office.Interop.Outlook;
using System.Windows.Forms;

namespace CheckAddIn
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Application.ItemSend += new Outlook.ApplicationEvents_11_ItemSendEventHandler(Application_ItemSend);
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
            Outlook.MailItem mail = item as Outlook.MailItem;             
            Outlook.Recipients recipients = mail.Recipients;
            if (mail!=null)
            {
                foreach (Outlook.Recipient recipient in recipients)
                {
                    string message = recipient.Address.ToString();
                    if (checkEmailAdd(message)==false)
                    {
                        if(MessageBox.Show(""+message+"的邮箱地址非本社地址！是否继续发送？","Info",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.Cancel)
                        {
                          
                            Cancel = true;
                            mail.Display(item);
                            
                        }
                    }
                }
                
            }
        }

        bool checkEmailAdd(string address)
        {
            bool result;
            int x = address.IndexOf("@", 0);
            x ++;
            string temp = address.Substring(x, address.Length - x);
            if (temp.Contains("mcz.mitsui-chem.com"))
            {
                result = true;
            }
            else if (temp.Contains("mitsuichemicals.com"))
            {
                result = true;
            }
            else
                result = false;
            return result;
        }

     
      
    }
}
