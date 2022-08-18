namespace VSSystem.Forms
{
    partial class UCDatabaseConfiguration
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
            this.label1 = new System.Windows.Forms.Label();
            this.com_driver = new System.Windows.Forms.ComboBox();
            this.com_server = new System.Windows.Forms.ComboBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.chk_remember = new System.Windows.Forms.CheckBox();
            this.com_database = new System.Windows.Forms.ComboBox();
            this.but_connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.com_username = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Driver:";
            // 
            // com_driver
            // 
            this.com_driver.FormattingEnabled = true;
            this.com_driver.Location = new System.Drawing.Point(85, 3);
            this.com_driver.Name = "com_driver";
            this.com_driver.Size = new System.Drawing.Size(221, 24);
            this.com_driver.TabIndex = 1;
            // 
            // com_server
            // 
            this.com_server.FormattingEnabled = true;
            this.com_server.Location = new System.Drawing.Point(85, 33);
            this.com_server.Name = "com_server";
            this.com_server.Size = new System.Drawing.Size(221, 24);
            this.com_server.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(83, 93);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(221, 22);
            this.txt_password.TabIndex = 4;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // chk_remember
            // 
            this.chk_remember.AutoSize = true;
            this.chk_remember.Location = new System.Drawing.Point(85, 152);
            this.chk_remember.Name = "chk_remember";
            this.chk_remember.Size = new System.Drawing.Size(90, 20);
            this.chk_remember.TabIndex = 6;
            this.chk_remember.Text = "Remember";
            this.chk_remember.UseVisualStyleBackColor = true;
            // 
            // com_database
            // 
            this.com_database.FormattingEnabled = true;
            this.com_database.Location = new System.Drawing.Point(85, 180);
            this.com_database.Name = "com_database";
            this.com_database.Size = new System.Drawing.Size(221, 24);
            this.com_database.TabIndex = 8;
            // 
            // but_connect
            // 
            this.but_connect.Location = new System.Drawing.Point(207, 149);
            this.but_connect.Name = "but_connect";
            this.but_connect.Size = new System.Drawing.Size(99, 25);
            this.but_connect.TabIndex = 7;
            this.but_connect.Text = "Connect";
            this.but_connect.UseVisualStyleBackColor = true;
            this.but_connect.Click += new System.EventHandler(this.but_connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Server:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Database:";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(85, 121);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(221, 22);
            this.txt_port.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Port:";
            // 
            // com_username
            // 
            this.com_username.FormattingEnabled = true;
            this.com_username.Location = new System.Drawing.Point(85, 63);
            this.com_username.Name = "com_username";
            this.com_username.Size = new System.Drawing.Size(221, 24);
            this.com_username.TabIndex = 3;
            // 
            // UCDatabaseConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.com_username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.but_connect);
            this.Controls.Add(this.com_database);
            this.Controls.Add(this.chk_remember);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.com_server);
            this.Controls.Add(this.com_driver);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCDatabaseConfiguration";
            this.Size = new System.Drawing.Size(315, 219);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox com_driver;
        private System.Windows.Forms.ComboBox com_server;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.CheckBox chk_remember;
        private System.Windows.Forms.ComboBox com_database;
        private System.Windows.Forms.Button but_connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox com_username;
    }
}
