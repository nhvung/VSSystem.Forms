namespace VSSystem.Forms
{
    partial class CopyFolderDialog
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
            this.sc_1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel_right = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sc_1)).BeginInit();
            this.sc_1.Panel1.SuspendLayout();
            this.sc_1.Panel2.SuspendLayout();
            this.sc_1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sc_1
            // 
            this.sc_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_1.Location = new System.Drawing.Point(0, 0);
            this.sc_1.Name = "sc_1";
            // 
            // sc_1.Panel1
            // 
            this.sc_1.Panel1.Controls.Add(this.panel_left);
            // 
            // sc_1.Panel2
            // 
            this.sc_1.Panel2.Controls.Add(this.panel_right);
            this.sc_1.Panel2.Controls.Add(this.panel1);
            this.sc_1.Size = new System.Drawing.Size(1184, 594);
            this.sc_1.SplitterDistance = 489;
            this.sc_1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 594);
            this.panel1.TabIndex = 0;
            // 
            // panel_left
            // 
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(489, 594);
            this.panel_left.TabIndex = 0;
            // 
            // panel_right
            // 
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right.Location = new System.Drawing.Point(150, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(541, 594);
            this.panel_right.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CopyFolderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 594);
            this.Controls.Add(this.sc_1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CopyFolderDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CopyFolderDialog";
            this.sc_1.Panel1.ResumeLayout(false);
            this.sc_1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_1)).EndInit();
            this.sc_1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc_1;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}