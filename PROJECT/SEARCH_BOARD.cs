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
        string tester;
        MySqlCommand command;
        public SEARCH_BOARD()
        {
            InitializeComponent();
        }

        private void SEARCH_BOARD_Load(object sender, EventArgs e)
        {
            Date_search.CustomFormat = " ";
            Stats.SelectedIndex = 0;
            AREA.SelectedIndex = 0;
            Tester_platform.SelectedIndex = 0;
            Boards.SelectedIndex = 0;
            dataGridViewList.DataSource = table(3);
            commands(2);
            if (Connection.OpenConnection())
            {
                check = command.ExecuteScalar().ToString();
                Connection.CloseConnection();
                DUE_DATE.Text = string.Format("OVERDUE({0})", check);
            }
            else Connection.CloseConnection();
            commands(8);
            if (Connection.OpenConnection())
            {
                MySqlDataReader read_data = command.ExecuteReader();
                while (read_data.Read())
                {
                    Tester_platform.Items.Add(read_data.GetString("Tester platforms"));
                }
                Connection.CloseConnection();
            }
            else return;
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
                case 1:  //TO DISPLAY THE DATA THAT IS SEARCHED BY THE USER, NO DATE
                    command = new MySqlCommand("SELECT `SERIAL NUMBER`,`PART NUMBER`,`BOARD`,`TESTER PLATFORM`,`TEST PROGRAM`,date_format(`FIRST DATE`,'%Y-%m-%d'),`STATUS`,`ENDORSEMENT NUMBER`" +
                        " FROM `boards_for_verification`.`board details` WHERE '" + search_text.Text + "'" +
                        " IN (`SERIAL NUMBER`,`PART NUMBER`,`FIRST TESTER`,`TEST PROGRAM`)" +
                        " ORDER BY `ENDORSEMENT NUMBER` DESC LIMIT 30",Connection.connect);
                    break;
                case 2:
                    command = new MySqlCommand("SELECT count(`FIRST DATE`) FROM `board details` WHERE (`FIRST DATE` + 1 < current_date() AND `STATUS` = 'FOR SECOND VERIF')",
                        Connection.connect);
                    break;
                case 3:  //FOR UPDATING PURPOSES
                    command = new MySqlCommand("SELECT `SERIAL NUMBER`,`PART NUMBER`,`BOARD`,`TESTER PLATFORM`,`TEST PROGRAM`,date_format(`FIRST DATE`,'%Y-%m-%d')," +
                        "`STATUS`,`ENDORSEMENT NUMBER`" +
                        " FROM `boards_for_verification`.`board details` ORDER BY `ENDORSEMENT NUMBER` DESC LIMIT 30",Connection.connect);
                    break;
                case 4:                  
                    break;
                case 5:
                    break;
                case 6:  //FOR CHECKING TRANSACTIONS WITH DATE ONLY
                    command = new MySqlCommand("SELECT `SERIAL NUMBER`,`PART NUMBER`,`BOARD`,`TESTER PLATFORM`,`TEST PROGRAM`,date_format(`FIRST DATE`,'%Y-%m-%d'),`STATUS`,`ENDORSEMENT NUMBER`" +
                        " FROM `boards_for_verification`.`board details` WHERE (`FIRST DATE` = '" + Date_search.Text + "') ORDER BY `ENDORSEMENT NUMBER` DESC LIMIT 30", Connection.connect);
                    break;
                case 7:
                    command = new MySqlCommand("SELECT COUNT(*) FROM `boards_for_verification`.`board details` WHERE (`FIRST DATE` = '" + Date_search.Text + "')",Connection.connect);
                    break;
                case 8:
                    command = new MySqlCommand("SELECT * FROM `boards_for_verification`.`tester platforms`", Connection.connect);
                    break;
                case 9:
                    tester = string.Format("SELECT * FROM `boards_of_testers`.`{0}`", Tester_platform.Text.ToLower());
                    command = new MySqlCommand(tester, Connection.ConnectBoards);
                    break;
                case 10:
                    command = new MySqlCommand("SELECT * FROM `boards_of_testers`.`tmt`", Connection.ConnectBoards);
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
            if (string.IsNullOrWhiteSpace(search_text.Text))
            {
                if (Stats.SelectedIndex == 6)
                {
                    return;
                }
                else
                    return;
            }
            else
            {
                count = 0;
                load_data(1);
                Date_search.CustomFormat = " ";
                AREA.SelectedIndex = 0;
                Stats.SelectedIndex = 0;
                Tester_platform.SelectedIndex = 0;
                clearBoards();
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
            Date_search.CustomFormat = " ";
            AREA.SelectedIndex = 0;
            Stats.SelectedIndex = 0;
            Tester_platform.SelectedIndex = 0;
            clearBoards();
            search_text.Clear();
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
            if (e.KeyCode == Keys.Back)
                Date_search.CustomFormat = " ";
            else
                e.SuppressKeyPress = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AreaIndexChanged(object sender, EventArgs e)
        {
            search_text.Clear();
            Date_search.ResetText();
        }

        private void statusIndexChanged(object sender, EventArgs e)
        {
            search_text.Clear();
            Date_search.ResetText();
        }

        private void Boardsindexchanged(object sender, EventArgs e)
        {
            search_text.Clear();
            Date_search.ResetText();
        }

        private void ShowBoards(object sender, EventArgs e)
        {
            search_text.Clear();
            Date_search.ResetText();
            if (Tester_platform.SelectedIndex == 0)
            {
                clearBoards();
            }
            else
            {
                clearBoards();
                if (Tester_platform.Text == "ASL1K" || Tester_platform.Text == "ASL4K")
                {
                    commands(10);
                    if (Connection.OpenConnectionForBoards())
                    {
                        MySqlDataReader read_data = command.ExecuteReader();
                        while (read_data.Read())
                        {
                            Boards.Items.Add(read_data.GetString("TMT"));
                        }
                        Connection.CloseConnectionForBoards();
                    }
                    else return;
                }
                else
                {
                    commands(9);
                    if (Connection.OpenConnectionForBoards())
                    {
                        MySqlDataReader read_data = command.ExecuteReader();
                        while (read_data.Read())
                        {
                            Boards.Items.Add(read_data.GetString(Tester_platform.Text.ToUpper()));
                        }
                        Connection.CloseConnectionForBoards();
                    }
                    else return;
                }
            }
        }
        private void clearBoards()
        {
            Boards.Items.Clear();
            Boards.Items.Add(" ");
            Boards.SelectedIndex = 0;
        }

        private void Select_date(object sender, EventArgs e)
        {
            Date_search.CustomFormat = "yyyy-MM-dd";
        }
    }
}
 