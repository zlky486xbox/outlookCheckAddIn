using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CheckAddIn
{
    public partial class CheckForm : Form
    {
      
        public List<string> nowhitelist = new List<string>();
        public CheckForm()
        {
            InitializeComponent();
        }
       
        void loadCheckBox ()
        {
            foreach(string item in nowhitelist)
            {
                CLB_NoWhiteList.Items.Add(item);
            }
        }

        private void BT_Send_Click(object sender, EventArgs e)
        {
            int item = 0;
            for(int i = 0;i < CLB_NoWhiteList.Items.Count;i++)
            {
                if (CLB_NoWhiteList.GetItemChecked(i))
                {
                    item++;
                }
            }
            if (item != CLB_NoWhiteList.Items.Count)
            {
                MessageBox.Show("全选后再点击发送！");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }       
        }

        private void BT_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void CheckForm_Load(object sender, EventArgs e)
        {
            loadCheckBox();
        }
    }
}
