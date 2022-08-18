namespace VSSystem.Forms
{
    partial class ConnectDatabaseDialog
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
            this.but_connect = new System.Windows.Forms.Button();
            this.lab_database = new System.Windows.Forms.Label();
            this.com_database = new System.Windows.Forms.ComboBox();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_ok = new System.Windows.Forms.Button();
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
            this.tlp_dbinfo.Controls.Add(this.but_connect, 1, 6);
            this.tlp_dbinfo.Controls.Add(this.lab_database, 0, 7);
            this.tlp_dbinfo.Controls.Add(this.com_database, 1, 7);
            this.tlp_dbinfo.Location = new System.Drawing.Point(12, 12);
            this.tlp_dbinfo.Name = "tlp_dbinfo";
            this.tlp_dbinfo.RowCount = 8;
            this.tlp_dbinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_dbinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_dbinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_dbinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_dbinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_dbinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_dbinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_dbinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_dbinfo.Size = new System.Drawing.Size(434, 275);
            this.tlp_dbinfo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Driver:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Port:";
            // 
            // com_driver
            // 
            this.com_driver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.com_driver.FormattingEnabled = true;
            this.com_driver.Location = new System.Drawing.Point(109, 6);
            this.com_driver.Name = "com_driver";
            this.com_driver.Size = new System.Drawing.Size(322, 24);
            this.com_driver.TabIndex = 5;
            // 
            // com_server
            // 
            this.com_server.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.com_server.FormattingEnabled = true;
            this.com_server.Location = new System.Drawing.Point(109, 40);
            this.com_server.Name = "com_server";
            this.com_server.Size = new System.Drawing.Size(322, 24);
            this.com_server.TabIndex = 6;
            // 
            // com_username
            // 
            this.com_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.com_username.FormattingEnabled = true;
            this.com_username.Location = new System.Drawing.Point(109, 74);
            this.com_username.Name = "com_username";
            this.com_username.Size = new System.Drawing.Size(322, 24);
            this.com_username.TabIndex = 7;
            // 
            // txt_password
            // 
            this.txt_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_password.Location = new System.Drawing.Point(109, 108);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(322, 22);
            this.txt_password.TabIndex = 8;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_port
            // 
            this.txt_port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_port.Location = new System.Drawing.Point(109, 142);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(322, 22);
            this.txt_port.TabIndex = 9;
            // 
            // chk_remember
            // 
            this.chk_remember.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chk_remember.AutoSize = true;
            this.chk_remember.Location = new System.Drawing.Point(109, 177);
            this.chk_remember.Name = "chk_remember";
            this.chk_remember.Size = new System.Drawing.Size(90, 20);
            this.chk_remember.TabIndex = 10;
            this.chk_remember.Text = "Remember";
            this.chk_remember.UseVisualStyleBackColor = true;
            // 
            // but_connect
            // 
            this.but_connect.Dock = System.Windows.Forms.DockStyle.Left;
            this.but_connect.Location = new System.Drawing.Point(109, 207);
            this.but_connect.Name = "but_connect";
            this.but_connect.Size = new System.Drawing.Size(167, 28);
            this.but_connect.TabIndex = 11;
            this.but_connect.Text = "Connect";
            this.but_connect.UseVisualStyleBackColor = true;
            this.but_connect.Click += new System.EventHandler(this.but_connect_Click);
            // 
            // lab_database
            // 
            this.lab_database.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_database.AutoSize = true;
            this.lab_database.Location = new System.Drawing.Point(3, 248);
            this.lab_database.Name = "lab_database";
            this.lab_database.Size = new System.Drawing.Size(67, 16);
            this.lab_database.TabIndex = 12;
            this.lab_database.Text = "Database:";
            // 
            // com_database
            // 
            this.com_database.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.com_database.FormattingEnabled = true;
            this.com_database.Location = new System.Drawing.Point(109, 246);
            this.com_database.Name = "com_database";
            this.com_database.Size = new System.Drawing.Size(322, 24);
            this.com_database.TabIndex = 13;
            // 
            // but_cancel
            // 
            this.but_cancel.Location = new System.Drawing.Point(232, 320);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(100, 30);
            this.but_cancel.TabIndex = 2;
            this.but_cancel.Text = "Cancel";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(120, 320);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(100, 30);
            this.but_ok.TabIndex = 3;
            this.but_ok.Text = "OK";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // ConnectDatabaseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 377);
            this.ControlBox = false;
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.tlp_dbinfo);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConnectDatabaseDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectDatabaseDialog";
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
        private System.Windows.Forms.Button but_connect;
        private System.Windows.Forms.Label lab_database;
        private System.Windows.Forms.ComboBox com_database;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_ok;
    }
}