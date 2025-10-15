using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro_To_Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            imgThwomp.Visible = true;
            lblStatus.Text = "Status: Clicked";
            btnSubmit.Enabled = false;
            btnQuit.Enabled = true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
             
            Close();
        }

        private void imgThwomp_Click(object sender, EventArgs e)
        {
            imgThwomp.Visible = false;
            btnQuit.Enabled = false;
            btnSubmit.Enabled = true;
            lblStatus.Text = "Status: Not Clicked";

        }
    }
}
