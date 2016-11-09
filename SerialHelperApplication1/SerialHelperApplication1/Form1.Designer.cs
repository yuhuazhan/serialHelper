namespace SerialHelperApplication1
{
    partial class SerialHelper_Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialHelper_Form));
            this.recv_textb = new System.Windows.Forms.TextBox();
            this.dataLen_lbl = new System.Windows.Forms.Label();
            this.stopBits_lbl = new System.Windows.Forms.Label();
            this.checkBit_lbl = new System.Windows.Forms.Label();
            this.serialNumber_lbl = new System.Windows.Forms.Label();
            this.baudRate_lbl = new System.Windows.Forms.Label();
            this.comSelect_comb = new System.Windows.Forms.ComboBox();
            this.baudSelect_comb = new System.Windows.Forms.ComboBox();
            this.dataBitsSelect_comb = new System.Windows.Forms.ComboBox();
            this.stopBitsSelect_comb = new System.Windows.Forms.ComboBox();
            this.checkBitSelect_comb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SenData_btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mangeCom_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.clearRecvtxtb_btn = new System.Windows.Forms.Button();
            this.AutoScroll_chb = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.singleSendText_rtxtb = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.語言ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.简体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // recv_textb
            // 
            resources.ApplyResources(this.recv_textb, "recv_textb");
            this.recv_textb.Name = "recv_textb";
            this.recv_textb.TextChanged += new System.EventHandler(this.recv_textb_TextChanged);
            // 
            // dataLen_lbl
            // 
            resources.ApplyResources(this.dataLen_lbl, "dataLen_lbl");
            this.dataLen_lbl.Name = "dataLen_lbl";
            // 
            // stopBits_lbl
            // 
            resources.ApplyResources(this.stopBits_lbl, "stopBits_lbl");
            this.stopBits_lbl.Name = "stopBits_lbl";
            // 
            // checkBit_lbl
            // 
            resources.ApplyResources(this.checkBit_lbl, "checkBit_lbl");
            this.checkBit_lbl.Name = "checkBit_lbl";
            // 
            // serialNumber_lbl
            // 
            resources.ApplyResources(this.serialNumber_lbl, "serialNumber_lbl");
            this.serialNumber_lbl.Name = "serialNumber_lbl";
            // 
            // baudRate_lbl
            // 
            resources.ApplyResources(this.baudRate_lbl, "baudRate_lbl");
            this.baudRate_lbl.Name = "baudRate_lbl";
            // 
            // comSelect_comb
            // 
            this.comSelect_comb.FormattingEnabled = true;
            resources.ApplyResources(this.comSelect_comb, "comSelect_comb");
            this.comSelect_comb.Name = "comSelect_comb";
            // 
            // baudSelect_comb
            // 
            this.baudSelect_comb.FormattingEnabled = true;
            resources.ApplyResources(this.baudSelect_comb, "baudSelect_comb");
            this.baudSelect_comb.Name = "baudSelect_comb";
            // 
            // dataBitsSelect_comb
            // 
            this.dataBitsSelect_comb.FormattingEnabled = true;
            resources.ApplyResources(this.dataBitsSelect_comb, "dataBitsSelect_comb");
            this.dataBitsSelect_comb.Name = "dataBitsSelect_comb";
            // 
            // stopBitsSelect_comb
            // 
            this.stopBitsSelect_comb.FormattingEnabled = true;
            resources.ApplyResources(this.stopBitsSelect_comb, "stopBitsSelect_comb");
            this.stopBitsSelect_comb.Name = "stopBitsSelect_comb";
            // 
            // checkBitSelect_comb
            // 
            this.checkBitSelect_comb.FormattingEnabled = true;
            resources.ApplyResources(this.checkBitSelect_comb, "checkBitSelect_comb");
            this.checkBitSelect_comb.Name = "checkBitSelect_comb";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.SenData_btn);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.mangeCom_btn);
            this.groupBox1.Controls.Add(this.comSelect_comb);
            this.groupBox1.Controls.Add(this.serialNumber_lbl);
            this.groupBox1.Controls.Add(this.baudSelect_comb);
            this.groupBox1.Controls.Add(this.baudRate_lbl);
            this.groupBox1.Controls.Add(this.dataBitsSelect_comb);
            this.groupBox1.Controls.Add(this.dataLen_lbl);
            this.groupBox1.Controls.Add(this.stopBitsSelect_comb);
            this.groupBox1.Controls.Add(this.stopBits_lbl);
            this.groupBox1.Controls.Add(this.checkBitSelect_comb);
            this.groupBox1.Controls.Add(this.checkBit_lbl);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // SenData_btn
            // 
            resources.ApplyResources(this.SenData_btn, "SenData_btn");
            this.SenData_btn.Name = "SenData_btn";
            this.SenData_btn.UseVisualStyleBackColor = true;
            this.SenData_btn.Click += new System.EventHandler(this.SenData_btn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.checkedListBox2);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.Info;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            resources.GetString("checkedListBox2.Items"),
            resources.GetString("checkedListBox2.Items1")});
            resources.ApplyResources(this.checkedListBox2, "checkedListBox2");
            this.checkedListBox2.Name = "checkedListBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkedListBox1);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Info;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            resources.GetString("checkedListBox1.Items"),
            resources.GetString("checkedListBox1.Items1"),
            resources.GetString("checkedListBox1.Items2")});
            resources.ApplyResources(this.checkedListBox1, "checkedListBox1");
            this.checkedListBox1.Name = "checkedListBox1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // mangeCom_btn
            // 
            resources.ApplyResources(this.mangeCom_btn, "mangeCom_btn");
            this.mangeCom_btn.Name = "mangeCom_btn";
            this.mangeCom_btn.UseVisualStyleBackColor = true;
            this.mangeCom_btn.Click += new System.EventHandler(this.mangeCom_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.clearRecvtxtb_btn);
            this.groupBox2.Controls.Add(this.AutoScroll_chb);
            this.groupBox2.Controls.Add(this.recv_textb);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // clearRecvtxtb_btn
            // 
            resources.ApplyResources(this.clearRecvtxtb_btn, "clearRecvtxtb_btn");
            this.clearRecvtxtb_btn.Name = "clearRecvtxtb_btn";
            this.clearRecvtxtb_btn.UseVisualStyleBackColor = true;
            this.clearRecvtxtb_btn.Click += new System.EventHandler(this.clearRecvtxtb_btn_Click);
            // 
            // AutoScroll_chb
            // 
            resources.ApplyResources(this.AutoScroll_chb, "AutoScroll_chb");
            this.AutoScroll_chb.Name = "AutoScroll_chb";
            this.AutoScroll_chb.UseVisualStyleBackColor = true;
            this.AutoScroll_chb.CheckedChanged += new System.EventHandler(this.AutoScroll_chb_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.singleSendText_rtxtb);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // singleSendText_rtxtb
            // 
            resources.ApplyResources(this.singleSendText_rtxtb, "singleSendText_rtxtb");
            this.singleSendText_rtxtb.Name = "singleSendText_rtxtb";
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.語言ToolStripMenuItem,
            this.versionMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 語言ToolStripMenuItem
            // 
            this.語言ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.简体ToolStripMenuItem});
            this.語言ToolStripMenuItem.Name = "語言ToolStripMenuItem";
            resources.ApplyResources(this.語言ToolStripMenuItem, "語言ToolStripMenuItem");
            // 
            // 简体ToolStripMenuItem
            // 
            this.简体ToolStripMenuItem.Name = "简体ToolStripMenuItem";
            resources.ApplyResources(this.简体ToolStripMenuItem, "简体ToolStripMenuItem");
            this.简体ToolStripMenuItem.Click += new System.EventHandler(this.简体ToolStripMenuItem_Click);
            // 
            // versionMenuItem
            // 
            this.versionMenuItem.Name = "versionMenuItem";
            resources.ApplyResources(this.versionMenuItem, "versionMenuItem");
            this.versionMenuItem.Click += new System.EventHandler(this.versionMenuItem_Click);
            // 
            // SerialHelper_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SerialHelper_Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label serialNumber_lbl;
        private System.Windows.Forms.Label baudRate_lbl;
        private System.Windows.Forms.Label dataLen_lbl;
        private System.Windows.Forms.Label stopBits_lbl;
        private System.Windows.Forms.Label checkBit_lbl;
        private System.Windows.Forms.ComboBox checkBitSelect_comb;
        private System.Windows.Forms.ComboBox comSelect_comb;
        private System.Windows.Forms.ComboBox baudSelect_comb;
        private System.Windows.Forms.ComboBox dataBitsSelect_comb;
        private System.Windows.Forms.ComboBox stopBitsSelect_comb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button mangeCom_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox AutoScroll_chb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clearRecvtxtb_btn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button SenData_btn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 語言ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 简体ToolStripMenuItem;
        private System.Windows.Forms.TextBox recv_textb;
        private System.Windows.Forms.RichTextBox singleSendText_rtxtb;
        private System.Windows.Forms.ToolStripMenuItem versionMenuItem;
    }
}

