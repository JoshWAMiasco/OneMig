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
        string testers = "boards_for_verification";
        string boards = "boards_of_testers";
        string List_value, List_AddOrDelete,database;
        public EDIT_TESTERS()
        {
            InitializeComponent();
        }
        private void LoadTesters()
        {
            AddOrDelete.Items.Clear();
            Current_List.Items.Clear();
            database = testers;
            Commands(1);
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

        private void LoadBoards()
        {
            AddOrDelete.Items.Clear();
            Current_List.Items.Clear();
            database = boards;
            Commands(1);
            if (Connection.OpenConnectionForBoards())
            {
                MySqlDataReader readBoards = Command.ExecuteReader();
                while (readBoards.Read())
                {
                    Current_List.Items.Add(readBoards.GetString(Tester_platforms.Text.ToUpper()));
                }
                Connection.CloseConnectionForBoards();
            }
        }

        private void EDIT_TESTERS_Load(object sender, EventArgs e)
        {
            Commands(0);
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
            if(Mode.SelectedIndex == 0)
            {
                AddOrRemoveText.Text = "ADD MODE";
                label3.Visible = true;
                ADD.Visible = true;
            }
            else
            {
                AddOrRemoveText.Text = "DELETE MODE";
                label3.Visible = false;
                ADD.Visible = false;
            }
        }
        private void CheckTextInListBox()
        {
            for (int CurrentList = 0; CurrentList < Current_List.Items.Count; CurrentList++)
            {
                Current_List.SelectedIndex = CurrentList;
                if (ADD.Text == Current_List.SelectedItem.ToString())
                {
                    Current_List.SelectedIndex = -1;
                    AddOrDelete.SelectedIndex = -1;
                    MessageBox.Show(ADD.Text + " ALREADY EXIST TO THE CURRENT LIST, THIS WILL NOT BE ADDED.");
                    return;
                }
            }
            for (int AddToList = 0; AddToList < AddOrDelete.Items.Count; AddToList++)
            {
                AddOrDelete.SelectedIndex = AddToList;
                if (ADD.Text == AddOrDelete.SelectedItem.ToString())
                {
                    AddOrDelete.SelectedIndex = -1;
                    Current_List.SelectedIndex = -1;
                    MessageBox.Show(ADD.Text + " ALREADY EXIST IN THE LIST, THIS WILL NOT BE ADDED.");
                    return;
                }
            }
            Current_List.SelectedIndex = -1;
            AddOrDelete.SelectedIndex = -1;
            AddOrDelete.Items.Add(ADD.Text);
            ADD.Clear();
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
                    if (Tester.Checked)
                    {
                        if (ADD.Text.Contains(Tester_platforms.Text))
                        {
                            CheckTextInListBox();
                        }
                        else
                        {
                            MessageBox.Show("INVALID TESTER NAME");
                            ADD.Clear();
                        }
                    }
                    else
                    {
                        CheckTextInListBox();
                    }
                }
            }
        }

        private void REMOVE_Click(object sender, EventArgs e)
        {
            if (Mode.SelectedIndex == 0)
            {
                if (AddOrDelete.Items.Count != 0)
                {
                    if (AddOrDelete.SelectedIndex == -1)
                        MessageBox.Show("PLEASE SELECT ON THE LIST");
                    else
                        AddOrDelete.Items.RemoveAt(AddOrDelete.SelectedIndex);
                }
                else
                    MessageBox.Show("LIST IS EMPTY");
            }
            else if (Mode.SelectedIndex == 1)
            {
                if (Current_List.SelectedIndex < 0)
                    MessageBox.Show("PLEASE SELECT A VALUE FIRST");
                else
                {
                    AddOrDelete.Items.Add(Current_List.SelectedItem);
                    Current_List.Items.RemoveAt(Current_List.SelectedIndex);
                }
            }
            else
                MessageBox.Show("PLEASE CHOOSE OPTION");
        }
        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (Mode.SelectedIndex == 0)   //FOR ADDING NEW DATA
            {
                if (AddOrDelete.Items.Count == 0)
                    MessageBox.Show("LIST IS EMPTY");
                else
                {
                    if (Tester.Checked)
                        database = testers;
                    else
                        database = boards;
                    Save_data(2);
                }
            }
            else if (Mode.SelectedIndex == 1)    // FOR REMOVING DATA FROM DATABASE
            {
                if (AddOrDelete.Items.Count == 0)
                    MessageBox.Show("LIST TO BE DELETED IS EMPTY");
                else
                {
                    if (Tester.Checked)
                        database = testers;
                    else
                        database = boards;
                    Save_data(3);
                }
            }
            else
                MessageBox.Show("PLEASE CHOOSE OPTION");
        }
        private void Save_data(int save)  //FOR SAVING THE DATA
        {
            DialogResult yes_no = MessageBox.Show("ARE YOU SURE YOU WANT TO SAVE IT?", "CONFIRMATION", MessageBoxButtons.YesNo);
            switch (yes_no)
            {
                case DialogResult.Yes:
                    for (int ListCount = 0; ListCount < AddOrDelete.Items.Count; ListCount++)
                    {
                        AddOrDelete.SelectedIndex = ListCount;
                        List_value = AddOrDelete.SelectedItem.ToString();
                        Commands(save);
                        if (Tester.Checked)
                        {
                            if (Connection.OpenConnection())
                            {
                                Command.ExecuteNonQuery();
                                Connection.CloseConnection();
                            }
                            else return;
                        }
                        else
                        {
                            if (Connection.OpenConnectionForBoards())
                            {
                                Command.ExecuteNonQuery();
                                Connection.CloseConnectionForBoards();
                            }
                            else return;
                        }
                    }
                    AddOrDelete.SelectedIndex = -1;
                    MessageBox.Show("SAVED SUCCESSFULLY TO DATABASE");
                    if (Tester.Checked)
                        LoadTesters();
                    else
                        LoadBoards();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void User(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Username.Text.ToLower() == "maxte" && Password.Text.ToLower() == "tsg")
                {
                    Log_in.Visible = false;
                    Log_out.Visible = true;
                    Editor_panel.Visible = true;
                    SearchBoard.Visible = true;
                }
                else
                    MessageBox.Show("INVALID");
            }
        }

        private void Pass(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Username.Text.ToLower() == "maxte" && Password.Text.ToLower() == "tsg")
                {
                    Log_in.Visible = false;
                    Log_out.Visible = true;
                    Editor_panel.Visible = true;
                    SearchBoard.Visible = true;
                }
                else
                    MessageBox.Show("INVALID");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Log_out.Visible = false;
            Log_in.Visible = true;
            Editor_panel.Visible = false;
            SearchBoard.Visible = false;
            Username.Clear();
            Password.Clear();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SEARCH_BOARD search = new SEARCH_BOARD();
            search.ShowDialog();
        }

        private void Tester_platforms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tester.Checked)
                LoadTesters();
            else if (Board.Checked)
                LoadBoards();
            else
                return;
        }

        private void Tester_mode(object sender, EventArgs e)
        {
            if (Tester_platforms.SelectedIndex == -1)
                return;
            LoadTesters();
        }

        private void Boards_mode(object sender, EventArgs e)
        {
            if (Tester_platforms.SelectedIndex == -1)
                return;
            LoadBoards();
        }
        private void Commands(int commads)
        {
            switch (commads)
            {
                case 0:  //LOAD TESTER PLATFORMS
                    Command = new MySqlCommand("SELECT * FROM `boards_for_verification`.`tester platforms`", Connection.connect);
                    break;
                case 1:  //LOAD TESTERS OR BOARDS IN THE TESTER PLATFORM
                    if (Tester.Checked)
                        Command = new MySqlCommand(string.Format("SELECT * FROM `{0}`.`{1}`",
                        database, Tester_platforms.Text.ToLower()), Connection.connect);
                    else
                        Command = new MySqlCommand(string.Format("SELECT * FROM `{0}`.`{1}`",
                        database, Tester_platforms.Text.ToLower()), Connection.ConnectBoards);
                    break;
                case 2:  //INSERT NEW TESTERS OR BOARDS IN THE CHOSEN TESTER PLATFORM
                    List_AddOrDelete = string.Format("INSERT INTO `{0}`.`{1}`(`{2}`) VALUES ('{3}')"
                        , database, Tester_platforms.Text.ToLower(), Tester_platforms.Text.ToUpper(), List_value);
                    if (Tester.Checked)
                        Command = new MySqlCommand(List_AddOrDelete, Connection.connect);
                    else
                        Command = new MySqlCommand(List_AddOrDelete, Connection.ConnectBoards);
                    break;
                case 3:  ///DELETE TESTERS OR BOARDS IN THE CHOSEN TESTER PLATFORM
                    List_AddOrDelete = string.Format("DELETE FROM `{0}`.`{1}` WHERE (`{2}` = '{3}')",
                        database, Tester_platforms.Text.ToLower(), Tester_platforms.Text.ToUpper(), List_value);
                    if (Tester.Checked)
                        Command = new MySqlCommand(List_AddOrDelete, Connection.connect);
                    else
                        Command = new MySqlCommand(List_AddOrDelete, Connection.ConnectBoards);
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
