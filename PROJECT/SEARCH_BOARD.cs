using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using Ubiety.Dns.Core.Records.NotUsed;

namespace PROJECT
{
    public partial class SEARCH_BOARD : Form
    {
        public string check;
        //MySqlConnection Connect = new MySqlConnection("server=mpoctsgdb.maxim-ic.com;user id = a2_utilities;password = a2_utilities;database=a2_utitilies");
        //MySqlConnection Connect = new MySqlConnection("server=localhost;user id=root;password=onemigso101996;database=boards_for_verification;persistsecurityinfo=True");
        MySqlCommand command;
        public SEARCH_BOARD()
        {
            InitializeComponent();
        }

        private void SEARCH_BOARD_Load(object sender, EventArgs e)
        {
            Username.Focus();
            dataGridViewList.DataSource = table(3);
            commands(4);
            if (Connection.OpenConnection())
            {
                check = command.ExecuteScalar().ToString();
                Connection.CloseConnection();
                DUE_DATE.Text = string.Format("OVERDUE({0})", check);
            }
            else Connection.CloseConnection();
        }
        private void Click_data(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                try
                {
                    string endorsement_number = (dataGridViewList.SelectedCells[7].Value.ToString());
                    BOARD_DETAILS details = new BOARD_DETAILS(endorsement_number);
                    details.ShowDialog();
                }
                catch (Exception)
                {
                    return;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        private void commands(int cmd)
        {
            switch(cmd)
            {
               
                case 0: //TO CHECK IF THERE'S AND EXISTING DATA SEARCHED
                    command = new MySqlCommand("SELECT COUNT(*) FROM `boards_for_verification`.`board details` WHERE ('" + search_text.Text + "')" +
                        "IN (`SERIAL NUMBER`,`PART NUMBER`,`BOARD`,`TESTER PLATFORM`,`FIRST TESTER`,`TEST PROGRAM`,`STATUS`) LIMIT 1",Connection.connect);
                    break;
                case 1:  //TO DISPLAY THE DATA THAT IS SEARCHED BY THE USER
                    command = new MySqlCommand("SELECT `SERIAL NUMBER`,`PART NUMBER`,`BOARD`,`TESTER PLATFORM`,`TEST PROGRAM`,`FIRST DATE`,`STATUS`,`ENDORSEMENT NUMBER`" +
                        " FROM `boards_for_verification`.`board details` WHERE ('" + search_text.Text + "')" +
                        " IN (`SERIAL NUMBER`,`PART NUMBER`,`BOARD`,`TESTER PLATFORM`,`FIRST TESTER`,`TEST PROGRAM`,`FIRST DATE`,`STATUS`)" +
                        " ORDER BY `ENDORSEMENT NUMBER` DESC LIMIT 30",Connection.connect);
                    break;
                case 2:  //TO DISPLAY THE TESTER PLATFORMS
                    command = new MySqlCommand("SELECT * FROM `boards_for_verification`.`tester platforms`", Connection.connect);
                    break;
                case 3:  //FOR UPDATING PURPOSES
                    command = new MySqlCommand("SELECT `SERIAL NUMBER`,`PART NUMBER`,`BOARD`,`TESTER PLATFORM`,`TEST PROGRAM`,`FIRST DATE`,`STATUS`,`ENDORSEMENT NUMBER`" +
                        " FROM `boards_for_verification`.`board details` ORDER BY `ENDORSEMENT NUMBER` DESC LIMIT 20",Connection.connect);
                    break;
                case 4:
                    command = new MySqlCommand("SELECT count(`FIRST DATE`) FROM `board details` WHERE (`FIRST DATE` + 1 < current_date() AND `STATUS` = 'FOR SECOND VERIF')",                     
                        Connection.connect);
                    break;
            }
        }
        private DataTable table(int COMMAND)
        {
            commands(COMMAND);
            DataTable new_data = new DataTable();
            if (Connection.OpenConnection())
            {
                MySqlDataAdapter read = new MySqlDataAdapter(command);
                read.Fill(new_data);
                Connection.CloseConnection();
                return new_data;
            }
            else 
                return new_data;
        }
        private void load_data(int commandss)
        {
            check = null;
            if (string.IsNullOrWhiteSpace(search_text.Text))
            {
                MessageBox.Show("NO INPUT");
            }
            else
            {
                commands(0);
                if (Connection.OpenConnection())
                {
                    check = command.ExecuteScalar().ToString();
                    MessageBox.Show(check);
                    if (Connection.CloseConnection())
                    {
                        if (check == "0")
                        {
                            MessageBox.Show("NO DATA");
                            search_text.Clear();
                            return;
                        }
                        else
                        {
                            dataGridViewList.DataSource = table(commandss);
                        }
                    }
                    else return;
                }
                else return;
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            load_data(1);
        }

        private void key_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                load_data(1);
            }
        }
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ADD next = new ADD();
            next.ShowDialog();
        }
        private void REFRESH_Click(object sender, EventArgs e)
        {
            search_text.Clear();
            dataGridViewList.DataSource = table(3);
        }

        private void User(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(Username.Text) || string.IsNullOrWhiteSpace(Password.Text))
                {
                    MessageBox.Show("INCOMPLETE INPUT");
                }
                else
                {
                    if (Username.Text.ToLower() == "maxte" && Password.Text.ToLower() == "tsg")
                    {
                        Log_in.Visible = false;
                        Log_out.Visible = true;
                        Add_btn.Visible = true;
                    }
                    else if (Username.Text.ToLower() == "admin" && Password.Text.ToLower() == "admin")
                    {
                        Log_in.Visible = false;
                        Log_out.Visible = true;
                        Add_btn.Visible = true;
                        EDIT.Visible = true;
                    }
                    else
                        MessageBox.Show("INCORRECT");
                }
            }
        }
        private void Pass(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(Username.Text) || string.IsNullOrWhiteSpace(Password.Text))
                {
                    MessageBox.Show("INCOMPLETE INPUT");
                }
                else
                {
                    if (Username.Text.ToLower() == "maxte" && Password.Text.ToLower() == "tsg")
                    {
                        Log_in.Visible = false;
                        Log_out.Visible = true;
                        Add_btn.Visible = true;
                    }
                    else if (Username.Text.ToLower() == "admin" && Password.Text.ToLower() == "admin")
                    {
                        Log_in.Visible = false;
                        Log_out.Visible = true;
                        Add_btn.Visible = true;
                        EDIT.Visible = true;
                    }
                    else
                        MessageBox.Show("INCORRECT");
                }
            }
        } 
        private void EDIT_Click(object sender, EventArgs e)
        {
            EDIT_TESTERS edit = new EDIT_TESTERS();
            edit.ShowDialog();
        }

        private void Log_out_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Log_in.Visible = true;
            Log_out.Visible = false;
            Add_btn.Visible = false;
            EDIT.Visible = false;
            Username.Clear();
            Password.Clear();
            Username.Focus();
        }

        private void DUE_DATE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}
