namespace CheckAddIn
{
    partial class SettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.LB_White = new System.Windows.Forms.ListBox();
            this.BT_Add = new System.Windows.Forms.Button();
            this.BT_Del = new System.Windows.Forms.Button();
            this.tb_add_white = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "白名单";
            // 
            // LB_White
            // 
            this.LB_White.FormattingEnabled = true;
            this.LB_White.ItemHeight = 12;
            this.LB_White.Location = new System.Drawing.Point(14, 24);
            this.LB_White.Name = "LB_White";
            this.LB_White.Size = new System.Drawing.Size(258, 172);
            this.LB_White.TabIndex = 1;
            // 
            // BT_Add
            // 
            this.BT_Add.Location = new System.Drawing.Point(12, 260);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(75, 33);
            this.BT_Add.TabIndex = 2;
            this.BT_Add.Text = "新增";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // BT_Del
            // 
            this.BT_Del.Location = new System.Drawing.Point(197, 260);
            this.BT_Del.Name = "BT_Del";
            this.BT_Del.Size = new System.Drawing.Size(75, 33);
            this.BT_Del.TabIndex = 3;
            this.BT_Del.Text = "删除";
            this.BT_Del.UseVisualStyleBackColor = true;
            this.BT_Del.Click += new System.EventHandler(this.BT_Del_Click);
            // 
            // tb_add_white
            // 
            this.tb_add_white.Location = new System.Drawing.Point(14, 233);
            this.tb_add_white.Name = "tb_add_white";
            this.tb_add_white.Size = new System.Drawing.Size(258, 21);
            this.tb_add_white.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "新增白名单";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_add_white);
            this.Controls.Add(this.BT_Del);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.LB_White);
            this.Controls.Add(this.label1);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB_White;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.Button BT_Del;
        private System.Windows.Forms.TextBox tb_add_white;
        private System.Windows.Forms.Label label2;
    }
}