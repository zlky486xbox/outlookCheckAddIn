using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace CheckAddIn
{
    public partial class RibbonList
    {
        private void RibbonList_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void Bt_Setting_Click(object sender, RibbonControlEventArgs e)
        {
            SettingForm sf = new SettingForm();
            sf.ShowDialog();
        }
    }
}
