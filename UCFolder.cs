using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Controls.WindowsForms;
using Microsoft.WindowsAPICodePack.Shell;

namespace VSSystem.Forms
{
    public partial class UCFolder : UserControl
    {
        ExplorerBrowser _eb;
        DelegateProcess _dlg;
        public UCFolder()
        {
            InitializeComponent();

            _dlg = new DelegateProcess();
            _eb = new ExplorerBrowser() { Dock = DockStyle.Fill };
            _eb.NavigationComplete += _eb_NavigationComplete;
            ts_menu_com_path.SelectedIndexChanged += Ts_menu_com_path_SelectedIndexChanged;
            ts_menu_com_path.KeyUp += Ts_menu_com_path_KeyUp;

            panel_main.Controls.Add(_eb);


            try
            {
                _eb.Navigate(ShellObject.FromParsingName("c:\\"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Ts_menu_com_path_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ShellObject shObj = ShellObject.FromParsingName(ts_menu_com_path.Text);
                _eb.Navigate(shObj);
            }
        }

        private void Ts_menu_com_path_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                ShellObject shObj = ShellObject.FromParsingName(ts_menu_com_path.Text);
                _eb.Navigate(shObj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _eb_NavigationComplete(object sender, Microsoft.WindowsAPICodePack.Controls.NavigationCompleteEventArgs e)
        {
            try
            {
                string path = e?.NewLocation?.ParsingName ?? "";
                
                _dlg.Execute(ts_menu, () => 
                { 
                    if(!ts_menu_com_path.Items.Contains(path))
                    {
                        ts_menu_com_path.Items.Add(path);
                    }
                    ts_menu_com_path.Text = path; 
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
