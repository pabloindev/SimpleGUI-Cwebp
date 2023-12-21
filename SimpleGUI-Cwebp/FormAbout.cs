using System;
using System.Windows.Forms;
using System.Configuration;

namespace SimpleGUI_Cwebp
{
    public partial class FormAbout : Form
    {
        static string simplegui_for_cwebp_homepage = ConfigurationManager.AppSettings["simplegui_for_cwebp_homepage"].ToString();
        public FormAbout()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(simplegui_for_cwebp_homepage);
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
