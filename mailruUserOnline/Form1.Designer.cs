namespace mailruUserOnline
{
    partial class Form1
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
			this.tb_addr = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pb_status = new System.Windows.Forms.PictureBox();
			this.b_check = new System.Windows.Forms.Button();
			this.lb_addrList = new System.Windows.Forms.ListBox();
			this.b_makeMonitor = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.pb_status)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tb_addr
			// 
			this.tb_addr.Location = new System.Drawing.Point(9, 32);
			this.tb_addr.Name = "tb_addr";
			this.tb_addr.Size = new System.Drawing.Size(223, 20);
			this.tb_addr.TabIndex = 0;
			this.tb_addr.Text = "ebanoemilo@list.ru";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "addr";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(100, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "status";
			// 
			// pb_status
			// 
			this.pb_status.Location = new System.Drawing.Point(141, 58);
			this.pb_status.Name = "pb_status";
			this.pb_status.Size = new System.Drawing.Size(62, 55);
			this.pb_status.TabIndex = 3;
			this.pb_status.TabStop = false;
			// 
			// b_check
			// 
			this.b_check.Location = new System.Drawing.Point(22, 58);
			this.b_check.Name = "b_check";
			this.b_check.Size = new System.Drawing.Size(58, 39);
			this.b_check.TabIndex = 4;
			this.b_check.Text = "Check!";
			this.b_check.UseVisualStyleBackColor = true;
			this.b_check.Click += new System.EventHandler(this.b_check_Click);
			// 
			// lb_addrList
			// 
			this.lb_addrList.FormattingEnabled = true;
			this.lb_addrList.Items.AddRange(new object[] {
            "ebanoemilo@list.ru"});
			this.lb_addrList.Location = new System.Drawing.Point(47, 61);
			this.lb_addrList.Name = "lb_addrList";
			this.lb_addrList.Size = new System.Drawing.Size(214, 95);
			this.lb_addrList.TabIndex = 5;
			// 
			// b_makeMonitor
			// 
			this.b_makeMonitor.Location = new System.Drawing.Point(158, 32);
			this.b_makeMonitor.Name = "b_makeMonitor";
			this.b_makeMonitor.Size = new System.Drawing.Size(103, 23);
			this.b_makeMonitor.TabIndex = 6;
			this.b_makeMonitor.Text = "MakeAMonitor";
			this.b_makeMonitor.UseVisualStyleBackColor = true;
			this.b_makeMonitor.Click += new System.EventHandler(this.b_makeMonitor_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tb_addr);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.b_check);
			this.groupBox1.Controls.Add(this.pb_status);
			this.groupBox1.Location = new System.Drawing.Point(25, 33);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(238, 120);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "manual check";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.b_makeMonitor);
			this.groupBox2.Controls.Add(this.lb_addrList);
			this.groupBox2.Location = new System.Drawing.Point(34, 168);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(333, 167);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Monitor!";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(483, 389);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pb_status)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_addr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_status;
        private System.Windows.Forms.Button b_check;
		private System.Windows.Forms.ListBox lb_addrList;
		private System.Windows.Forms.Button b_makeMonitor;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
    }
}

