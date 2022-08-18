namespace VSSystem.Forms
{
    partial class UCFolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFolder));
            this.ts_menu = new System.Windows.Forms.ToolStrip();
            this.ts_menu_but_back = new System.Windows.Forms.ToolStripButton();
            this.ts_menu_but_forward = new System.Windows.Forms.ToolStripButton();
            this.ts_menu_but_up = new System.Windows.Forms.ToolStripButton();
            this.ts_menu_com_path = new System.Windows.Forms.ToolStripComboBox();
            this.ts_menu_but_refresh = new System.Windows.Forms.ToolStripButton();
            this.panel_main = new System.Windows.Forms.Panel();
            this.ts_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts_menu
            // 
            this.ts_menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_menu_but_back,
            this.ts_menu_but_forward,
            this.ts_menu_but_up,
            this.ts_menu_com_path,
            this.ts_menu_but_refresh});
            this.ts_menu.Location = new System.Drawing.Point(0, 0);
            this.ts_menu.Name = "ts_menu";
            this.ts_menu.Size = new System.Drawing.Size(750, 25);
            this.ts_menu.TabIndex = 0;
            this.ts_menu.Text = "toolStrip1";
            // 
            // ts_menu_but_back
            // 
            this.ts_menu_but_back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_menu_but_back.Image = ((System.Drawing.Image)(resources.GetObject("ts_menu_but_back.Image")));
            this.ts_menu_but_back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_menu_but_back.Name = "ts_menu_but_back";
            this.ts_menu_but_back.Size = new System.Drawing.Size(23, 22);
            this.ts_menu_but_back.Text = "Back";
            // 
            // ts_menu_but_forward
            // 
            this.ts_menu_but_forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_menu_but_forward.Image = ((System.Drawing.Image)(resources.GetObject("ts_menu_but_forward.Image")));
            this.ts_menu_but_forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_menu_but_forward.Name = "ts_menu_but_forward";
            this.ts_menu_but_forward.Size = new System.Drawing.Size(23, 22);
            this.ts_menu_but_forward.Text = "Forward";
            // 
            // ts_menu_but_up
            // 
            this.ts_menu_but_up.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_menu_but_up.Image = ((System.Drawing.Image)(resources.GetObject("ts_menu_but_up.Image")));
            this.ts_menu_but_up.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_menu_but_up.Name = "ts_menu_but_up";
            this.ts_menu_but_up.Size = new System.Drawing.Size(23, 22);
            this.ts_menu_but_up.Text = "Up";
            // 
            // ts_menu_com_path
            // 
            this.ts_menu_com_path.Name = "ts_menu_com_path";
            this.ts_menu_com_path.Size = new System.Drawing.Size(200, 25);
            // 
            // ts_menu_but_refresh
            // 
            this.ts_menu_but_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_menu_but_refresh.Image = ((System.Drawing.Image)(resources.GetObject("ts_menu_but_refresh.Image")));
            this.ts_menu_but_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_menu_but_refresh.Name = "ts_menu_but_refresh";
            this.ts_menu_but_refresh.Size = new System.Drawing.Size(23, 22);
            this.ts_menu_but_refresh.Text = "Refresh";
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 25);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(750, 567);
            this.panel_main.TabIndex = 1;
            // 
            // UCFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.ts_menu);
            this.Name = "UCFolder";
            this.Size = new System.Drawing.Size(750, 592);
            this.ts_menu.ResumeLayout(false);
            this.ts_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_menu;
        private System.Windows.Forms.ToolStripButton ts_menu_but_back;
        private System.Windows.Forms.ToolStripButton ts_menu_but_forward;
        private System.Windows.Forms.ToolStripButton ts_menu_but_up;
        private System.Windows.Forms.ToolStripComboBox ts_menu_com_path;
        private System.Windows.Forms.ToolStripButton ts_menu_but_refresh;
        private System.Windows.Forms.Panel panel_main;
    }
}
