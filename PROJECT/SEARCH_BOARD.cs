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
using Squirrel;

namespace PROJECT
{
    public partial class SEARCH_BOARD : Form
    {
        public string check;
        public int count;
        MySqlCommand command;
        public SEARCH_BOARD()
        {
            InitializeComponent();
        }

        private void SEARCH_BOARD_Load(object sender, EventArgs e)
        {
            dataGridViewList.DataSource = table(3);
            commands(4);
            if (Connection.OpenConnection())
            {
                check = command.ExecuteScalar().ToString();
                Connection.CloseConnection();
                DUE_DATE.Text = string.Format("OVERDUE({0})", check);
            }
            else Connection.CloseConnection();
            Stats.SelectedIndex = 0;
            AREA.SelectedIndex = 0;
            Tester_platform.SelectedIndex = 0;
            Boards.SelectedIndex = 0;
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
               
                case 0: //TO CHECK IF THERE'S EXISTING DATA SEARCHED
                    command = new MySqlCommand("SELECT COUNT(*) FROM `boards_for_verification`.`board details` WHERE ('" + search_text.Text + "')" +
                        "IN (`SERIAL NUMBER`,`PART NUMBER`,`BOARD`,`TESTER PLATFORM`,`FIRST TESTER`,`TEST PROGRAM`,`STATUS`) LIMIT 1",Connection.connect);
                    break;
                case 1:  //TO DISPLAY THE DATA THAT IS SEARCHED BY THE USER
                    command = new MySqlCommand("SELECT `SERIAL NUMBER`,`PART NUMBER`,`BOARD`,`TESTER PLATFORM`,`TEST PROGRAM`,date_format(`FIRST DATE`,'%Y-%m-%d'),`STATUS`,`ENDORSEMENT NUMBER`" +
                        " FROM `boards_for_verification`.`board details` WHERE '" + search_text.Text + "'" +
                        " IN (`SERIAL NUMBER`,`PART NUMBER`,`BOARD`,`TESTER PLATFORM`,`FIRST TESTER`,`TEST PROGRAM`,`STATUS`)" +
                        " ORDER BY `ENDORSEMENT NUMBER` DESC LIMIT 30",Connection.connect);
                    break;
                case 2:  //SEARCH DATA WITH SPECIFIC DATE
                    command = new MySqlCommand("SELECT `SERIAL NUMBER`,`PART NUMBER`,`BOARD`,`TESTER PLATFORM`,`TEST PROGRAM`,date_format(`FIRST DATE`,'%Y-%m-%d'),`STATUS`,`ENDORSEMENT NUMBER`" +
                        " FROM `boards_for_verification`.`board details` WHERE ('" + search_text.Text + "'" +
                        " IN (`SERIAL NUMBER`,`PART NUMBER`,`BOARD`,`TESTER PLATFORM`,`FIRST TESTER`,`TEST PROGRAM`,`STATUS`)) AND (`FIRST DATE` = '" + Date_search.Text + "')" +
                        " ORDER BY `ENDORSEMENT NUMBER` DESC LIMIT 30", Connection.connect);
                    break;
                case 3:  //FOR UPDATING PURPOSES
                    command = new MySqlCommand("SELECT `SERIAL NUMBER`,`PART NUMBER`,`BOARD`,`TESTER PLATFORM`,`TEST PROGRAM`,date_format(`FIRST DATE`,'%Y-%m-%d')," +
                        "`STATUS`,`ENDORSEMENT NUMBER`" +
                        " FROM `boards_for_verification`.`board details` ORDER BY `ENDORSEMENT NUMBER` DESC LIMIT 30",Connection.connect);
                    break;
                case 4: //TO CHECK AND COUNT THE OVERDUE TRANSACTIONS
                    command = new MySqlCommand("SELECT count(`FIRST DATE`) FROM `board details` WHERE (`FIRST DATE` + 1 < current_date() AND `STATUS` = 'FOR SECOND VERIF')",                     
                        Connection.connect);
                    break;
                case 5: //FOR OVERDUE TRANSACTIONS VIEWING
                    command = new MySqlCommand("SELECT `SERIAL NUMBER`,`PART NUMBER`,`BOARD`,`TESTER PLATFORM`,`TEST PROGRAM`,date_format(`FIRST DATE`,'%Y-%m-%d'),`STATUS`,`ENDORSEMENT NUMBER`" +
                        " FROM `boards_for_verification`.`board details` WHERE (`FIRST DATE` + 1 < current_date() AND `STATUS` = 'FOR SECOND VERIF')" +
                        "ORDER BY `ENDORSEMENT NUMBER` DESC LIMIT 30",Connection.connect);
                    break;
                case 6:  //FOR CHECKING TRANSACTIONS WITH SPECIFIC DATE
                    command = new MySqlCommand("SELECT `SERIAL NUMBER`,`PART NUMBER`,`BOARD`,`TESTER PLATFORM`,`TEST PROGRAM`,date_format(`FIRST DATE`,'%Y-%m-%d'),`STATUS`,`ENDORSEMENT NUMBER`" +
                        " FROM `boards_for_verification`.`board details` WHERE (`FIRST DATE` = '" + Date_search.Text + "') ORDER BY `ENDORSEMENT NUMBER` DESC LIMIT 30", Connection.connect);
                    break;
                case 7:
                    command = new MySqlCommand("SELECT COUNT(*) FROM `boards_for_verification`.`board details` WHERE (`FIRST DATE` = '" + Date_search.Text + "')",Connection.connect);
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
            commands(count);
            if (Connection.OpenConnection())
            {
                check = command.ExecuteScalar().ToString();
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

        private void Search_button_Click(object sender, EventArgs e)
        {
            if (Include_date.Checked == false && search_text.Text.Length > 0)
            {
                count = 0;
                load_data(1);
                Date_search.ResetText();
            }
            else if (Include_date.Checked == false && search_text.Text.Length == 0)
            {
                count = 7;
                load_data(6);
            }
            else
            {
                dataGridViewList.DataSource = table(2);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ADD next = new ADD();
            next.ShowDialog();
        }
        private void REFRESH_Click(object sender, EventArgs e)
        {
            Date_search.ResetText();
            search_text.Clear();
            Include_date.Checked = false;
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

        private void EDIT_Click(object sender, EventArgs e)
        {
            EDIT_TESTERS edit = new EDIT_TESTERS();
            edit.ShowDialog();
        }

        private void DUE_DATE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            search_text.Clear();
            if (check == "0")
            {
                return;
            }
            else
            {
                dataGridViewList.DataSource = table(5);
            }
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            CheckForUpdates();
            MessageBox.Show("UPDATE DONE, THE APPLICATION WILL CLOSE");
            this.Close();
        }

        private async Task CheckForUpdates()
        {
            using (var update = new UpdateManager(@"\\maxcavfs01\mpoc_asl_softwares\12_Projects and Activities\BFV APPLICATION"))
            {
                await update.UpdateApp();
            }
        }
        private void Date(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
 