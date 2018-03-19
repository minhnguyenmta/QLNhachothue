using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MainProgram.Forms;
using MainProgram.UCs;

namespace MainProgram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ucStart ucstart1 = new ucStart();
            ucstart1.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ucstart1);
        }

        private void tsbLogin_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.ShowDialog();

            if (Login.isSuccess)
            {
                ucAdmin ucadmin1 = new ucAdmin();
                ucadmin1.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add(ucadmin1);
            }
        }
    }
}
