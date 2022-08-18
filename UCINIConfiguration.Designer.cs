namespace VSSystem.Forms
{
    partial class UCINIConfiguration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_configfilepath = new System.Windows.Forms.TextBox();
            this.but_refresh = new System.Windows.Forms.Button();
            this.but_browse = new System.Windows.Forms.Button();
            this.ts_top = new System.Windows.Forms.ToolStrip();
            this.sc_1 = new System.Windows.Forms.SplitContainer();
            this.tv_section = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_keyvalue = new System.Windows.Forms.DataGridView();
            this.col_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_update = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_1)).BeginInit();
            this.sc_1.Panel1.SuspendLayout();
            this.sc_1.Panel2.SuspendLayout();
            this.sc_1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_keyvalue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 5);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 5);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 421);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(780, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 421);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.but_browse);
            this.panel5.Controls.Add(this.but_refresh);
            this.panel5.Controls.Add(this.txt_configfilepath);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(775, 43);
            this.panel5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Config File:";
            // 
            // txt_configfilepath
            // 
            this.txt_configfilepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_configfilepath.Location = new System.Drawing.Point(85, 10);
            this.txt_configfilepath.Name = "txt_configfilepath";
            this.txt_configfilepath.Size = new System.Drawing.Size(512, 22);
            this.txt_configfilepath.TabIndex = 1;
            // 
            // but_refresh
            // 
            this.but_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_refresh.Location = new System.Drawing.Point(689, 6);
            this.but_refresh.Name = "but_refresh";
            this.but_refresh.Size = new System.Drawing.Size(80, 30);
            this.but_refresh.TabIndex = 2;
            this.but_refresh.Text = "Refresh";
            this.but_refresh.UseVisualStyleBackColor = true;
            // 
            // but_browse
            // 
            this.but_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_browse.Location = new System.Drawing.Point(603, 6);
            this.but_browse.Name = "but_browse";
            this.but_browse.Size = new System.Drawing.Size(80, 30);
            this.but_browse.TabIndex = 3;
            this.but_browse.Text = "Browse";
            this.but_browse.UseVisualStyleBackColor = true;
            // 
            // ts_top
            // 
            this.ts_top.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_top.Location = new System.Drawing.Point(5, 48);
            this.ts_top.Name = "ts_top";
            this.ts_top.Size = new System.Drawing.Size(775, 25);
            this.ts_top.TabIndex = 5;
            this.ts_top.Text = "toolStrip1";
            // 
            // sc_1
            // 
            this.sc_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_1.Location = new System.Drawing.Point(5, 73);
            this.sc_1.Name = "sc_1";
            // 
            // sc_1.Panel1
            // 
            this.sc_1.Panel1.Controls.Add(this.groupBox1);
            // 
            // sc_1.Panel2
            // 
            this.sc_1.Panel2.Controls.Add(this.groupBox2);
            this.sc_1.Size = new System.Drawing.Size(775, 353);
            this.sc_1.SplitterDistance = 258;
            this.sc_1.TabIndex = 6;
            // 
            // tv_section
            // 
            this.tv_section.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_section.Location = new System.Drawing.Point(3, 18);
            this.tv_section.Name = "tv_section";
            this.tv_section.Size = new System.Drawing.Size(252, 332);
            this.tv_section.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tv_section);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 353);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sections";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_update);
            this.groupBox2.Controls.Add(this.dgv_keyvalue);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 353);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "<Key - Value> Items";
            // 
            // dgv_keyvalue
            // 
            this.dgv_keyvalue.AllowUserToAddRows = false;
            this.dgv_keyvalue.AllowUserToDeleteRows = false;
            this.dgv_keyvalue.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_keyvalue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_keyvalue.ColumnHeadersHeight = 30;
            this.dgv_keyvalue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_key,
            this.col_value});
            this.dgv_keyvalue.Location = new System.Drawing.Point(6, 21);
            this.dgv_keyvalue.Name = "dgv_keyvalue";
            this.dgv_keyvalue.RowHeadersVisible = false;
            this.dgv_keyvalue.RowTemplate.Height = 30;
            this.dgv_keyvalue.Size = new System.Drawing.Size(501, 290);
            this.dgv_keyvalue.TabIndex = 0;
            // 
            // col_key
            // 
            this.col_key.HeaderText = "Key";
            this.col_key.Name = "col_key";
            this.col_key.ReadOnly = true;
            this.col_key.Width = 200;
            // 
            // col_value
            // 
            this.col_value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_value.HeaderText = "Value";
            this.col_value.MinimumWidth = 100;
            this.col_value.Name = "col_value";
            // 
            // but_update
            // 
            this.but_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_update.Location = new System.Drawing.Point(427, 317);
            this.but_update.Name = "but_update";
            this.but_update.Size = new System.Drawing.Size(80, 30);
            this.but_update.TabIndex = 4;
            this.but_update.Text = "Update";
            this.but_update.UseVisualStyleBackColor = true;
            // 
            // UCINIConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sc_1);
            this.Controls.Add(this.ts_top);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCINIConfiguration";
            this.Size = new System.Drawing.Size(785, 431);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.sc_1.Panel1.ResumeLayout(false);
            this.sc_1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_1)).EndInit();
            this.sc_1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_keyvalue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button but_browse;
        private System.Windows.Forms.Button but_refresh;
        private System.Windows.Forms.TextBox txt_configfilepath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip ts_top;
        private System.Windows.Forms.SplitContainer sc_1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tv_section;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_keyvalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_key;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_value;
        private System.Windows.Forms.Button but_update;
    }
}
