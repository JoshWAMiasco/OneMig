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
    public partial class CHOOSE : Form
    {
        public string Admin { get; set; }
        public CHOOSE()
        {
            InitializeComponent();
        }

        public CHOOSE(string admin)
        {
            InitializeComponent();
            Admin = admin;
            this.Text = "ADMIN MODE";
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOG_IN next = new LOG_IN();
            next.ShowDialog();
        }
        private void Boards_for_Verif_Click(object sender, EventArgs e)
        {
            this.Hide();
            SEARCH_BOARD next = new SEARCH_BOARD();
            next.ShowDialog();
        }
    }
}
