namespace VSSystem.Forms
{
    partial class ViewLogDialog
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grp_folder = new System.Windows.Forms.GroupBox();
            this.tv_log = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxt_log = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.but_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grp_folder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(8, 8);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grp_folder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(977, 599);
            this.splitContainer1.SplitterDistance = 351;
            this.splitContainer1.TabIndex = 11;
            // 
            // grp_folder
            // 
            this.grp_folder.Controls.Add(this.tv_log);
            this.grp_folder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_folder.Location = new System.Drawing.Point(0, 0);
            this.grp_folder.Name = "grp_folder";
            this.grp_folder.Size = new System.Drawing.Size(351, 599);
            this.grp_folder.TabIndex = 0;
            this.grp_folder.TabStop = false;
            this.grp_folder.Text = "Items";
            // 
            // tv_log
            // 
            this.tv_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_log.Location = new System.Drawing.Point(3, 19);
            this.tv_log.Name = "tv_log";
            this.tv_log.Size = new System.Drawing.Size(345, 577);
            this.tv_log.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxt_log);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 599);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // rtxt_log
            // 
            this.rtxt_log.AcceptsTab = true;
            this.rtxt_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_log.Location = new System.Drawing.Point(3, 19);
            this.rtxt_log.Name = "rtxt_log";
            this.rtxt_log.ReadOnly = true;
            this.rtxt_log.Size = new System.Drawing.Size(616, 577);
            this.rtxt_log.TabIndex = 0;
            this.rtxt_log.Text = "";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(977, 8);
            this.panel5.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.but_close);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(8, 607);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(977, 53);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(985, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 660);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 660);
            this.panel2.TabIndex = 7;
            // 
            // but_close
            // 
            this.but_close.Location = new System.Drawing.Point(419, 13);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(100, 28);
            this.but_close.TabIndex = 0;
            this.but_close.Text = "Close";
            this.but_close.UseVisualStyleBackColor = true;
            this.but_close.Click += new System.EventHandler(this.but_close_Click);
            // 
            // ViewLogDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 660);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewLogDialog";
            this.Text = "ViewLogDialog";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grp_folder.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grp_folder;
        private System.Windows.Forms.TreeView tv_log;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxt_log;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button but_close;
    }
}