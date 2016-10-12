using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            foreach(int item in CLB_NoWhiteList.CheckedIndices)
            {
                if(item!=CLB_NoWhiteList.Items.Count)
                {
                    MessageBox.Show("");
                }
            }
        }

        private void BT_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
