namespace CheckAddIn
{
    partial class CheckForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CLB_NoWhiteList = new System.Windows.Forms.CheckedListBox();
            this.BT_Send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CLB_NoWhiteList
            // 
            this.CLB_NoWhiteList.FormattingEnabled = true;
            this.CLB_NoWhiteList.Location = new System.Drawing.Point(12, 37);
            this.CLB_NoWhiteList.Name = "CLB_NoWhiteList";
            this.CLB_NoWhiteList.Size = new System.Drawing.Size(260, 180);
            this.CLB_NoWhiteList.TabIndex = 0;
            // 
            // BT_Send
            // 
            this.BT_Send.Location = new System.Drawing.Point(15, 223);
            this.BT_Send.Name = "BT_Send";
            this.BT_Send.Size = new System.Drawing.Size(98, 36);
            this.BT_Send.TabIndex = 1;
            this.BT_Send.Text = "发送";
            this.BT_Send.UseVisualStyleBackColor = true;
            this.BT_Send.Click += new System.EventHandler(this.BT_Send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "以下名单为非白名单地址，请确认";
            // 
            // BT_cancel
            // 
            this.BT_cancel.Location = new System.Drawing.Point(174, 223);
            this.BT_cancel.Name = "BT_cancel";
            this.BT_cancel.Size = new System.Drawing.Size(98, 36);
            this.BT_cancel.TabIndex = 3;
            this.BT_cancel.Text = "取消";
            this.BT_cancel.UseVisualStyleBackColor = true;
            this.BT_cancel.Click += new System.EventHandler(this.BT_cancel_Click);
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.BT_cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_Send);
            this.Controls.Add(this.CLB_NoWhiteList);
            this.Name = "CheckForm";
            this.Text = "CheckForm";
            this.Load += new System.EventHandler(this.CheckForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CLB_NoWhiteList;
        private System.Windows.Forms.Button BT_Send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_cancel;
    }
}