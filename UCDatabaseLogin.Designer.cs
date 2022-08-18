namespace VSSystem.Forms
{
    partial class UCDatabaseLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp_dbinfo = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.com_driver = new System.Windows.Forms.ComboBox();
            this.com_server = new System.Windows.Forms.ComboBox();
            this.com_username = new System.Windows.Forms.ComboBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.chk_remember = new System.Windows.Forms.CheckBox();
            this.tlp_dbinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_dbinfo
            // 
            this.tlp_dbinfo.AutoSize = true;
            this.tlp_dbinfo.ColumnCount = 2;
            this.tlp_dbinfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.45055F));
            this.tlp_dbinfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.54945F));
            this.tlp_dbinfo.Controls.Add(this.label1, 0, 0);
            this.tlp_dbinfo.Controls.Add(this.label2, 0, 1);
            this.tlp_dbinfo.Controls.Add(this.label3, 0, 2);
            this.tlp_dbinfo.Controls.Add(this.label4, 0, 3);
            this.tlp_dbinfo.Controls.Add(this.label5, 0, 4);
            this.tlp_dbinfo.Controls.Add(this.com_driver, 1, 0);
            this.tlp_dbinfo.Controls.Add(this.com_server, 1, 1);
            this.tlp_dbinfo.Controls.Add(this.com_username, 1, 2);
            this.tlp_dbinfo.Controls.Add(this.txt_password, 1, 3);
            this.tlp_dbinfo.Controls.Add(this.txt_port, 1, 4);
            this.tlp_dbinfo.Controls.Add(this.chk_remember, 1, 5);
            this.tlp_dbinfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_dbinfo.Location = new System.Drawing.Point(0, 0);
            this.tlp_dbinfo.Name = "tlp_dbinfo";
            this.tlp_dbinfo.RowCount = 6;
            this.tlp_dbinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_dbinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_dbinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_dbinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_dbinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_dbinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_dbinfo.Size = new System.Drawing.Size(364, 180);
            this.tlp_dbinfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Driver:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Port:";
            // 
            // com_driver
            // 
            this.com_driver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.com_driver.FormattingEnabled = true;
            this.com_driver.Location = new System.Drawing.Point(92, 3);
            this.com_driver.Name = "com_driver";
            this.com_driver.Size = new System.Drawing.Size(269, 24);
            this.com_driver.TabIndex = 5;
            // 
            // com_server
            // 
            this.com_server.Dock = System.Windows.Forms.DockStyle.Fill;
            this.com_server.FormattingEnabled = true;
            this.com_server.Location = new System.Drawing.Point(92, 32);
            this.com_server.Name = "com_server";
            this.com_server.Size = new System.Drawing.Size(269, 24);
            this.com_server.TabIndex = 6;
            // 
            // com_username
            // 
            this.com_username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.com_username.FormattingEnabled = true;
            this.com_username.Location = new System.Drawing.Point(92, 61);
            this.com_username.Name = "com_username";
            this.com_username.Size = new System.Drawing.Size(269, 24);
            this.com_username.TabIndex = 7;
            // 
            // txt_password
            // 
            this.txt_password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_password.Location = new System.Drawing.Point(92, 90);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(269, 22);
            this.txt_password.TabIndex = 8;
            // 
            // txt_port
            // 
            this.txt_port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_port.Location = new System.Drawing.Point(92, 119);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(269, 22);
            this.txt_port.TabIndex = 9;
            // 
            // chk_remember
            // 
            this.chk_remember.AutoSize = true;
            this.chk_remember.Location = new System.Drawing.Point(92, 148);
            this.chk_remember.Name = "chk_remember";
            this.chk_remember.Size = new System.Drawing.Size(90, 20);
            this.chk_remember.TabIndex = 10;
            this.chk_remember.Text = "Remember";
            this.chk_remember.UseVisualStyleBackColor = true;
            // 
            // UCDatabaseLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_dbinfo);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCDatabaseLogin";
            this.Size = new System.Drawing.Size(364, 223);
            this.tlp_dbinfo.ResumeLayout(false);
            this.tlp_dbinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_dbinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox com_driver;
        private System.Windows.Forms.ComboBox com_server;
        private System.Windows.Forms.ComboBox com_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.CheckBox chk_remember;
    }
}
