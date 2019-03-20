namespace 销售管理.Main
{
    partial class 数据源切换
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(数据源切换));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(342, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "数据源选择";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 24;
            this.comboBox1.Items.AddRange(new object[] {
            "融通高科（内网）",
            "融通新材料（内网）",
            "融通高科（公网）",
            "融通新材料（公网）"});
            this.comboBox1.Location = new System.Drawing.Point(346, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(388, 32);
            this.comboBox1.TabIndex = 10;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::销售管理.Properties.Resources.rt150;
            this.LogoPictureBox.Location = new System.Drawing.Point(7, 15);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(330, 332);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 12;
            this.LogoPictureBox.TabStop = false;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(558, 289);
            this.Cancel.Margin = new System.Windows.Forms.Padding(6);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(188, 46);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "取消(&C)";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(358, 289);
            this.OK.Margin = new System.Windows.Forms.Padding(6);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(188, 46);
            this.OK.TabIndex = 13;
            this.OK.Text = "确定(&O)";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // 数据源切换
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::销售管理.Properties.Resources.smallback;
            this.ClientSize = new System.Drawing.Size(761, 350);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "数据源切换";
            this.Text = "数据源切换";
            this.Load += new System.EventHandler(this.数据源切换_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        internal System.Windows.Forms.PictureBox LogoPictureBox;
        internal System.Windows.Forms.Button Cancel;
        internal System.Windows.Forms.Button OK;
    }
}