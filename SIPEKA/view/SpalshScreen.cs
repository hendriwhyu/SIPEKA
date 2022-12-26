using SIPEKA.view;
using System;
using System.Windows.Forms;

namespace SIPEKA
{
    public partial class SpalshScreen : Form
    {
        int waktu = 0;
        public SpalshScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (waktu == 3)
            {
                Login_frm login = new Login_frm();
                login.Show();
                this.Hide();
                timer1.Enabled = false;
            }
            waktu++;
        }
    }
}
