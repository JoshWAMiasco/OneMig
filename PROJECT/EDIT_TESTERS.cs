using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROJECT
{
    public partial class EDIT_TESTERS : Form
    {
        MySqlCommand Command;
        string List;
        public EDIT_TESTERS()
        {
            InitializeComponent();
        }

        private void EDIT_TESTERS_Load(object sender, EventArgs e)
        {
            Command = new MySqlCommand("SELECT * FROM `boards_for_verification`.`tester platforms`", Connection.connect);

            if (Connection.OpenConnection())
            {
                MySqlDataReader read_data = Command.ExecuteReader();
                while (read_data.Read())
                {
                    Tester_platforms.Items.Add(read_data.GetString("Tester platforms"));
                }
                Connection.CloseConnection();
            }
        }

        private void Option_selection(object sender, EventArgs e)
        {
            if(Option.SelectedIndex == 0)
            {
                label3.Visible = true;
                ADD.Visible = true;
            }
            else
            {
                label3.Visible = false;
                ADD.Visible = false;
            }
        }

        private void Tester_platfrom(object sender, EventArgs e)
        {
            AddOrDelete.Items.Clear();
            Current_List.Items.Clear();
            List = string.Format("SELECT * FROM `boards_for_verification`.`{0}`", Tester_platforms.Text.ToLower());
            Command = new MySqlCommand(List, Connection.connect);
            if (Connection.OpenConnection())
            {
                MySqlDataReader read = Command.ExecuteReader();
                while (read.Read())
                {
                    Current_List.Items.Add(read.GetString(Tester_platforms.Text.ToUpper()));
                }
                Connection.CloseConnection();
            }
        }

        private void Add_Tester(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(ADD.Text))
                {
                    MessageBox.Show("NO INPUT");
                    return;
                }
                else
                {
                    AddOrDelete.Items.Add(ADD.Text);
                    ADD.Clear();
                }
            }
        }
    }
}
