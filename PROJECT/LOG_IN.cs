using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class LOG_IN : Form
    {
        private string admin = "ADMIN";
        public LOG_IN()
        {
            InitializeComponent();
            this.ActiveControl = UserName;
            UserName.Focus();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (UserName.Text.ToUpper() == "MAXTE" && PassWord.Text.ToUpper() == "TSG")
            {
                this.Hide();
                CHOOSE next = new CHOOSE();
                next.ShowDialog();
            }
            else if (UserName.Text.ToUpper() == "ADMIN" && PassWord.Text.ToUpper() == "TMTADMIN")
            {
                this.Hide();
                CHOOSE next = new CHOOSE(admin);
                next.ShowDialog();
            }
            else
            {
                MessageBox.Show("TRY AGAIN");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
