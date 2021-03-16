﻿using System;
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
using Renci.SshNet.Security;
using Ubiety.Dns.Core.Records.NotUsed;
using MySqlX.XDevAPI;
using Microsoft.VisualBasic;


namespace PROJECT
{
    public partial class ADD : Form
    {
        MySqlCommand command;
        public string tester_platform, get_status, inputBox,FileName,status,displayStatus,boardQuery,database,ForTmT;
        public int sites, DoNotLoadBoard;

        byte[] data;
        public ADD()
        {
            InitializeComponent();
        }
        private void error()
        {
            MessageBox.Show("INCOMPLETE DETAILS!");
        }
        private byte[] SaveFile(string file)
        {
            using (Stream getDatalog = File.OpenRead(file))
            {
                data = new byte[getDatalog.Length];
                getDatalog.Read(data, 0, data.Length);
            }
            return data;
        }
        private string Filename(string filename)
        {
            FileName = new FileInfo(filename).Name;
            return FileName;
        }
        private void Save_data(int InputCommand)
        {
            DialogResult yes_no = MessageBox.Show(string.Format("PLEASE DOUBLE CHECK YOUR DATA,THIS WILL BE SAVE PERMANENTLY. SAVE IT? STATUS: {0}",status), "ATTENTION", MessageBoxButtons.YesNo);
                switch (yes_no)
                {
                    case DialogResult.Yes:
                        commands(InputCommand);
                        break;
                    case DialogResult.No:
                        return;
                }
            command.Connection = Connection.connect;
            if (Connection.OpenConnection())
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (MySqlException m)
                {
                    MessageBox.Show(m.ToString());
                    Connection.CloseConnection();
                    return;
                }
                if (Connection.CloseConnection())
                {
                    MessageBox.Show("FILE SAVED SUCCESSFULLY");
                    clear_all();
                    Save_btn.Visible = false;
                    Update_Button.Visible = false;
                    Serial_number.Visible = true;
                    Serial_number.Clear();
                    LoadTesterPlatforms();
                }
                else return;
            }
            else
                return;
        }
        private bool ForFirstVerif()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox == Failure_mode_others || textBox == Failed_during_others || textBox == Remarks)
                        continue;
                    else
                    {
                        if (string.IsNullOrWhiteSpace(textBox.Text))
                        {
                            error();
                            return false;
                        }
                        else if (textBox.Text.Length > 20)
                        {
                            MessageBox.Show("TOO LONG INPUT!");
                            return false;
                        }
                        else continue;

                    }
                }
                else if (c is ComboBox)
                {
                    ComboBox comboBox = c as ComboBox;
                    if (comboBox.SelectedIndex == -1)
                    {
                        error();
                        return false;
                    }
                    else if (comboBox == Failed_during)
                    {
                        if (Failed_during.SelectedIndex == 2)
                        {
                            if (string.IsNullOrWhiteSpace(Failed_during_others.Text))
                            {
                                error();
                                return false;
                            }
                            else if (Failed_during_others.Text.Length > 20)
                            {
                                MessageBox.Show("TOO LONG INPUT!");
                                return false;
                            }
                            else continue;
                        }
                    }
                    else if (comboBox == Failure_mode)
                    {
                        if (Failure_mode.SelectedIndex == 9)
                        {
                            if (string.IsNullOrWhiteSpace(Failure_mode_others.Text))
                            {
                                error();
                                return false;
                            }
                            else if (Failure_mode_others.Text.Length > 40)
                            {
                                MessageBox.Show("TOO LONG INPUT!");
                                return false;
                            }
                            else continue;
                        }
                    }
                }
                else continue;
            }
            if (first_verif_link.Text == string.Empty || First_tester.SelectedIndex == -1 || string.IsNullOrWhiteSpace(First_board_slot.Text)
                || first_endorser.SelectedIndex == -1)
            {
                error();
                return false;
            }
            else if (First_board_slot.Text.Length > 5)
            {
                MessageBox.Show("TOO LONG INPUT!");
                return false;
            }
            else
            {
                if (First_Site.Items.Count != 0)
                {
                    if (First_Site.SelectedIndex == -1)
                    {
                        error();
                        return false;
                    }
                }
            }
            return true;
        }
        private bool ForSecondVerif()
        {
            if (compare_date())
            {
                if (second_verif_link.Text == string.Empty || Second_tester.SelectedIndex == -1 || string.IsNullOrWhiteSpace(Second_slot.Text)
                        || second_endorser.SelectedIndex == -1 || string.IsNullOrWhiteSpace(Remarks.Text))
                {
                    error();
                    return false;
                }
                else if (Second_slot.Text.Length > 5)
                {
                    MessageBox.Show("TOO LONG INPUT!");
                    return false;
                }
                else
                {
                    if (Second_Site.Items.Count != 0)
                    {
                        if (Second_Site.SelectedIndex == -1)
                        {
                            error();
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }
        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (FAILURE_CHANGED.Checked)
            {
                if (Second_Site.Items.Count == 0)
                {
                    if (second_endorser.SelectedIndex == -1 || Second_tester.SelectedIndex == -1)
                    {
                        error();
                        return;
                    }
                    status = "FAILURE CHANGED";
                    Save_data(6);
                }
                else
                {
                    if (second_endorser.SelectedIndex == -1 || Second_tester.SelectedIndex == -1 || Second_Site.SelectedIndex == - 1 || string.IsNullOrWhiteSpace(Second_slot.Text))
                    {
                        error();
                        return;
                    }
                    status = "FAILURE CHANGED";
                    Save_data(9);
                }
            }
            else if (INSTALL_TO_TESTER.Checked)
            {
                if (Second_Site.Items.Count == 0)
                {
                    if (second_endorser.SelectedIndex == -1 || Second_tester.SelectedIndex == -1)
                    {
                        error();
                        return;
                    }
                    status = "INSTALL TO A TESTER";
                    Save_data(7);
                }
                else
                {
                    if (second_endorser.SelectedIndex == -1 || Second_tester.SelectedIndex == -1 || Second_Site.SelectedIndex == - 1 || string.IsNullOrWhiteSpace(Second_slot.Text))
                    {
                        error();
                        return;
                    }
                    status = "INSTALL TO A TESTER";
                    Save_data(10);
                }
            }
            else if (BRG.Checked)
            {
                if (ForSecondVerif())
                {
                    status = "BRG";
                    Save_data(3);
                }
            }
            else if (SPARES.Checked)
            {
                if (ForSecondVerif())
                {
                    status = "SPARES";
                    Save_data(3);
                }
            }
            else
            {
                MessageBox.Show("CHOOSE STATUS");
            }
        }
        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (FOR_SECOND_VERIF.Checked)
            {
                if(ForFirstVerif())
                {
                    status = "FOR SECOND VERIF";
                    Save_data(2);
                }
            }
            else if (BRG.Checked)
            {
                if (ForFirstVerif())
                {
                    if (ForSecondVerif())
                    {
                        status = "BRG";
                        Save_data(4);
                    }
                }
            }
            else if (SPARES.Checked)
            {
                if (ForFirstVerif())
                {
                    if (ForSecondVerif())
                    {
                        status = "SPARES";
                        Save_data(4);
                    }
                }
            }
            else
            {
                MessageBox.Show("CHOOSE STATUS");
            }
        }
        private void Add_first_verif_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.Title = "BROWSE A FILE";
            openFileDialog1.FileName = null;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                first_verif_link.Visible = true;
                first_verif_link.Text = openFileDialog1.FileName;
            }
            Show_second_grpBox();
        }
        private void Add_second_verif_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = @"c:\";
            openFileDialog2.Title = "BROWSE A FILE";
            openFileDialog2.FileName = null;
            openFileDialog2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                second_verif_link.Visible = true;
                second_verif_link.Text = openFileDialog2.FileName;
            }
        }
        private void first_verif_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Save_btn.Visible == false)
            {
                string DatalogFile = string.Format("C:\\Users\\{0}\\Desktop\\{1}", Environment.UserName, FileName);
                File.WriteAllBytes(DatalogFile, data);
                System.Diagnostics.Process.Start(DatalogFile);
            }
            else
            {
                try
                {
                    System.Diagnostics.Process.Start(first_verif_link.Text);
                }
                catch (Exception me)
                {
                    MessageBox.Show("ERROR " + me.ToString());
                }
            }
        }
        private void second_verif_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(second_verif_link.Text);
            }
            catch (Exception mess)
            {
                MessageBox.Show("ERROR " + mess.ToString());
            }
        }

        private bool CheckTextBox(string textBox)
        {
            char[] text = textBox.ToCharArray();
            if (textBox.Length > 15)
            {
                MessageBox.Show("MAXIMUM OF TEN CHARACTERS ONLY");
                return false;
            }
            for (int Txt = 0; Txt < textBox.Length ; Txt++)
            {
                if (char.IsLetterOrDigit(text[Txt]))
                {
                    continue;
                }
                else
                {
                    MessageBox.Show("PLEASE ENTER NUMBER OR LETTER ONLY");
                    return false;
                }
            }
            return true;
        }
        private void Key_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Timer.Stop();
                Timer2.Stop();
                if (CheckTextBox(Serial_number.Text))
                {
                    if (string.IsNullOrWhiteSpace(Serial_number.Text))
                    {
                        MessageBox.Show("NO INPUT");
                        return;
                    }
                    commands(1);
                    command.Connection = Connection.connect;

                    if (Connection.OpenConnection())
                    {
                        MySqlDataReader read_data = command.ExecuteReader();
                        read_data.Read();
                        try
                        {
                            get_status = read_data["STATUS"].ToString();
                            if (get_status == "SPARES" || get_status == "BRG" || get_status.Contains("INSTALL") || get_status == "FAILURE CHANGED")
                            {
                                DialogResult yes_no = MessageBox.Show("LAST TRANSACTION: " + get_status + ", ADD NEW?", "ATTENTION!",
                                    MessageBoxButtons.YesNo);
                                switch (yes_no)
                                {
                                    case DialogResult.Yes:
                                        clear_all();
                                        enable_control();
                                        all_controls();
                                        Part_number.Text = read_data["PART NUMBER"].ToString();
                                        Revision.Text = read_data["REVISION"].ToString();
                                        Test_system.Items.Add(read_data["TESTER PLATFORM"].ToString());
                                        Boards.Items.Add(read_data["BOARD"].ToString());
                                        Connection.CloseConnection();
                                        Boards.SelectedIndex = 0;
                                        Boards.SelectedIndex = 0;
                                        Update_Button.Visible = false;
                                        FAILURE_CHANGED.Visible = false;
                                        INSTALL_TO_TESTER.Visible = false;
                                        Timer.Start();
                                        DoNotLoadBoard = 1;
                                        if (Test_system.Items.Contains("ASL4K"))
                                            Test_system.Items.Add("ASL1K");
                                        else if (Test_system.Items.Contains("ASL1K"))
                                            Test_system.Items.Add("ASL4K");
                                        else
                                        {
                                            Test_system.SelectedIndex = 0;
                                            Testers();
                                            return;
                                        }
                                        return;
                                    case DialogResult.No:
                                        Connection.CloseConnection();
                                        clear_all();
                                        Serial_number.Clear();
                                        Save_btn.Visible = false;
                                        Update_Button.Visible = false;
                                        FAILURE_CHANGED.Visible = false;
                                        INSTALL_TO_TESTER.Visible = false;
                                        DoNotLoadBoard = 0;
                                        return;
                                }
                            }
                            else
                            {
                                ClearItemsInTesterBox();
                                Test_system.Items.Clear();
                                Boards.Items.Clear();
                                all_controls();
                                Part_number.Text = read_data["PART NUMBER"].ToString();
                                Revision.Text = read_data["REVISION"].ToString();
                                Boards.Items.Add(read_data["BOARD"].ToString());
                                Test_program.Text = read_data["TEST PROGRAM"].ToString();
                                Test_system.Items.Add(read_data["TESTER PLATFORM"].ToString());
                                Failed_during.Text = read_data["FAILED DURING"].ToString();
                                Failed_during_others.Text = read_data["FAILED DURING OTHERS"].ToString();
                                Failure_mode.Text = read_data["FAILURE MODE"].ToString();
                                Failure_mode_others.Text = read_data["FAILURE MODE OTHERS"].ToString();
                                Test_option.Text = read_data["TEST OPTION"].ToString();
                                Remarks.Text = read_data["REMARKS"].ToString();
                                data = (byte[])read_data["FIRST DATALOG"];
                                Date_first_verif.Text = read_data["FIRST DATE"].ToString();
                                First_tester.Items.Add(read_data["FIRST TESTER"]);
                                First_Site.Items.Add(read_data["FIRST SITE"].ToString());
                                First_board_slot.Text = read_data["FIRST SLOT"].ToString();
                                first_endorser.Text = read_data["FIRST ENDORSER"].ToString();
                                FileName = read_data["FILENAME 1"].ToString();
                                Area.Text = read_data["AREA"].ToString();
                                FirstTime.Text = read_data["FIRST TIME"].ToString();
                                Connection.CloseConnection();
                                disable_control();
                                first_verif_link.Text = FileName;
                                Test_system.SelectedIndex = 0;
                                Boards.SelectedIndex = 0;
                                First_tester.SelectedIndex = 0;
                                First_Site.SelectedIndex = 0;
                                Timer2.Start();
                                if (First_Site.Text.Equals(string.Empty))
                                    First_Site.Visible = false;
                                else
                                    First_Site.Visible = true;
                                Save_btn.Visible = false;
                                Update_Button.Visible = true;
                                Second_box.Visible = true;
                                FAILURE_CHANGED.Visible = true;
                                INSTALL_TO_TESTER.Visible = true;
                                FOR_SECOND_VERIF.Visible = false;
                                if (Test_system.Text == "ASL4K" || Test_system.Text == "ASL1K")
                                {
                                    command = new MySqlCommand("select * from `boards_for_verification`.`asl1k`", Connection.connect);
                                    Connection.OpenConnection();
                                    MySqlDataReader read1k = command.ExecuteReader();
                                    while (read1k.Read())
                                    {
                                        Second_tester.Items.Add(read1k["ASL1K"].ToString());
                                    }
                                    Connection.CloseConnection();
                                    command = new MySqlCommand("select * from `boards_for_verification`.`asl4k`", Connection.connect);
                                    Connection.OpenConnection();
                                    MySqlDataReader read4k = command.ExecuteReader();
                                    while (read4k.Read())
                                    {
                                        Second_tester.Items.Add(read4k["ASL4K"].ToString());
                                    }
                                    Connection.CloseConnection();
                                }
                                else
                                {
                                    tester_platform = string.Format("SELECT * FROM `boards_for_verification`.`{0}`", Test_system.Text.ToLower());
                                    command = new MySqlCommand(tester_platform, Connection.connect);

                                    Connection.OpenConnection();
                                    MySqlDataReader read = command.ExecuteReader();
                                    while (read.Read())
                                    {
                                        Second_tester.Items.Add(read.GetString(Test_system.Text.ToUpper()));
                                    }
                                    sites = int.Parse(read["SITE"].ToString());
                                    Connection.CloseConnection();
                                    if (sites != 0)
                                    {
                                        for (int CountSite = 1; CountSite <= sites; CountSite++)
                                        {
                                            Second_Site.Items.Add(CountSite.ToString());
                                        }
                                        Second_Site.Visible = true;
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                            DialogResult yes_no = MessageBox.Show("NO DATA, ADD NEW?", "ATTENTION!", MessageBoxButtons.YesNo);
                            switch (yes_no)
                            {
                                case DialogResult.Yes:
                                    Connection.CloseConnection();
                                    clear_all();
                                    all_controls();
                                    enable_control();
                                    Update_Button.Visible = false;
                                    FAILURE_CHANGED.Visible = false;
                                    INSTALL_TO_TESTER.Visible = false;
                                    DoNotLoadBoard = 0;
                                    Timer.Start();
                                    LoadTesterPlatforms();
                                    break;
                                case DialogResult.No:
                                    Connection.CloseConnection();
                                    Serial_number.Clear();
                                    clear_all();
                                    Save_btn.Visible = false;
                                    Update_Button.Visible = false;
                                    break;
                            }
                        }
                    }
                }
            }
        }
        private void commands(int Pick)
        {
            switch (Pick)
            {
                case 1:  // FOR CHECKING THE LAST TRANSACTION
                    command = new MySqlCommand("SELECT * FROM `boards_for_verification`.`board details` WHERE (`SERIAL NUMBER` = '" + Serial_number.Text + "') ORDER BY `ENDORSEMENT NUMBER` DESC LIMIT 1");
                    break;

                case 2:  // FOR ADDING A NEW TRANSACTION FOR NO SECOND VERIFICATION
                    command = new MySqlCommand("INSERT INTO `boards_for_verification`." +
            "`board details`(`SERIAL NUMBER`,`PART NUMBER`,REVISION,BOARD,`TEST PROGRAM`,`FAILED DURING`,`FAILED DURING OTHERS`,`FAILURE MODE`,`FAILURE MODE OTHERS`," +
            "`TEST OPTION`,STATUS,REMARKS,`FIRST DATALOG`,`FIRST DATE`,`FIRST TESTER`,`FIRST SITE`,`FIRST SLOT`,`FIRST ENDORSER`,`TESTER PLATFORM`,`FILENAME 1`,`AREA`,`FIRST TIME`) VALUES('" + Serial_number.Text + "'," +
            "'" + Part_number.Text + "','" + Revision.Text + "','" + Boards.Text + "','" + Test_program.Text + "','" + Failed_during.Text + "','" + Failed_during_others.Text + "'," +
            "'" + Failure_mode.Text + "','" + Failure_mode_others.Text + "','" + Test_option.Text + "','" + status + "','" + Remarks.Text + "',@FIRST_DATA," +
            "'" + Date_first_verif.Text + "','" + First_tester.Text + "','" + First_Site.Text + "','" + First_board_slot.Text + "','" + first_endorser.Text + "','" + Test_system.Text + "'," +
            "'" + Filename(first_verif_link.Text) + "','" + Area.Text + "','" + FirstTime.Text + "')");
                    command.Parameters.Add("@FIRST_DATA", MySqlDbType.VarBinary).Value = SaveFile(first_verif_link.Text);
                    break;

                case 3:  // FOR UPDATING THE LAST TRANSACTION
                    command = new MySqlCommand("UPDATE `boards_for_verification`.`board details` SET `STATUS` = '" + status + "',`SECOND DATALOG` = @SECOND_DATA," +
                        "`SECOND DATE` = '" + Date_second_verif.Text + "',`SECOND TESTER` = '" + Second_tester.Text + "',`SECOND SITE` = '" + Second_Site.Text + "'," +
                        "`SECOND SLOT` = '" + Second_slot.Text + "',`SECOND ENDORSER` = '" + second_endorser.Text + "',`REMARKS` = '" + Remarks.Text + "'," +
                        "`FILENAME 2` = '" + Filename(second_verif_link.Text) + "',`SECOND TIME` = '" + SecondTime.Text + "'"  +
                        " WHERE (`SERIAL NUMBER` = '" + Serial_number.Text + "') ORDER BY `ENDORSEMENT NUMBER` DESC LIMIT 1");
                    command.Parameters.Add("@SECOND_DATA", MySqlDbType.VarBinary).Value = SaveFile(second_verif_link.Text);
                    break;

                case 4: //FOR ADDING A NEW TRANSACTION WITH FIRST AND SECOND VERIFICATION
                    command = new MySqlCommand("INSERT INTO `boards_for_verification`." +
            "`board details`(`SERIAL NUMBER`,`PART NUMBER`,REVISION,BOARD,`TEST PROGRAM`,`FAILED DURING`,`FAILED DURING OTHERS`,`FAILURE MODE`,`FAILURE MODE OTHERS`," +
            "`TEST OPTION`,STATUS,REMARKS,`FIRST DATALOG`,`FIRST DATE`,`FIRST TESTER`,`FIRST SITE`,`FIRST SLOT`,`FIRST ENDORSER`,`SECOND DATALOG`,`SECOND DATE`," +
            "`SECOND TESTER`,`SECOND SITE`,`SECOND SLOT`,`SECOND ENDORSER`,`TESTER PLATFORM`,`FILENAME 1`,`FILENAME 2`,`AREA`,`FIRST TIME`,`SECOND TIME`) " +
            "VALUES('" + Serial_number.Text + "','" + Part_number.Text + "','" + Revision.Text + "','" + Boards.Text + "','" + Test_program.Text + "','" + Failed_during.Text + "','" + Failed_during_others.Text + "'," +
            "'" + Failure_mode.Text + "','" + Failure_mode_others.Text + "','" + Test_option.Text + "','" + status + "','" + Remarks.Text + "',@FIRST_DATA," +
            "'" + Date_first_verif.Text + "','" + First_tester.Text + "','" + First_Site.Text + "','" + First_board_slot.Text + "','" + first_endorser.Text + "',@SECOND_DATA," +
            "'" + Date_second_verif.Text + "','" + Second_tester.Text + "','" + Second_Site.Text + "','" + Second_slot.Text + "','" + second_endorser.Text + "','" + Test_system.Text + "'," +
            "'" + Filename(first_verif_link.Text )+ "','" + Filename(second_verif_link.Text )+ "','" + Area.Text + "','" + FirstTime.Text + "','" + SecondTime.Text + "')");
                    command.Parameters.Add("@FIRST_DATA", MySqlDbType.VarBinary).Value = SaveFile(first_verif_link.Text);
                    command.Parameters.Add("@SECOND_DATA", MySqlDbType.VarBinary).Value = SaveFile(second_verif_link.Text);
                    break;
                case 5:  //FOR THE TESTER PLATFORMS
                    command = new MySqlCommand("SELECT * FROM `boards_for_verification`.`tester platforms`", Connection.connect);
                    break;
                case 6:  // IF THE SECOND VERIFICATION CHANGES
                    command = new MySqlCommand("UPDATE `boards_for_verification`.`board details` " +
                        "SET `SECOND DATE` = '" + Date_second_verif.Text  + "',`SECOND TESTER` = '" + Second_tester.Text + "',`SECOND TIME` = '" + SecondTime.Text + "',`SECOND ENDORSER` = '" + second_endorser.Text + "'," +
                        "`STATUS` = 'FAILURE CHANGED',`REMARKS` = '" + Remarks.Text + "'" +
                        "WHERE (`SERIAL NUMBER` = '" + Serial_number.Text + "')ORDER BY `ENDORSEMENT NUMBER` DESC LIMIT 1");
                    break;
                case 7:  // IF THE SECOND VERIFICATION PASSED AND INSTALLED ALREADY TO THE TESTER
                    command = new MySqlCommand(string.Format("UPDATE `boards_for_verification`.`board details` " +
                        "SET `SECOND DATE` = '" + Date_second_verif.Text + "',`SECOND TESTER` = '" + Second_tester.Text + "',`SECOND TIME` = '" + SecondTime.Text + "'," +
                        "`SECOND ENDORSER` = '" + second_endorser.Text + "'," +
                        "`STATUS` = 'INSTALL TO {0}',`REMARKS` = '" + Remarks.Text + "'" +
                        "WHERE (`SERIAL NUMBER` = '" + Serial_number.Text + "')ORDER BY `ENDORSEMENT NUMBER` DESC LIMIT 1",Second_tester.Text));
                    break;
                case 8:
                    tester_platform = string.Format("SELECT * FROM `boards_for_verification`.`{0}`", Test_system.Text.ToLower());
                    command = new MySqlCommand(tester_platform, Connection.connect);
                    break;
                case 9:
                    command = new MySqlCommand("UPDATE `boards_for_verification`.`board details` " +
                        "SET `SECOND DATE` = '" + Date_second_verif.Text + "',`SECOND TESTER` = '" + Second_tester.Text + "',`SECOND SITE` = '" + Second_Site.Text + "'," +
                        "`SECOND SLOT` = '" +Second_slot.Text + "',`SECOND TIME` = '" + SecondTime.Text + "'," +
                        "`SECOND ENDORSER` = '" + second_endorser.Text + "'," +
                        "`STATUS` = 'FAILURE CHANGED',`REMARKS` = '" + Remarks.Text + "'" +
                        "WHERE (`SERIAL NUMBER` = '" + Serial_number.Text + "')ORDER BY `ENDORSEMENT NUMBER` DESC LIMIT 1");
                    break;
                case 10:
                    command = new MySqlCommand(string.Format("UPDATE `boards_for_verification`.`board details` " +
                        "SET `SECOND DATE` = '" + Date_second_verif.Text + "',`SECOND TESTER` = '" + Second_tester.Text + "',`SECOND SITE` = '" + Second_Site.Text + "'," +
                        "`SECOND SLOT` = '" + Second_slot.Text + "',`SECOND TIME` = '" + SecondTime.Text + "'," +
                        "`SECOND ENDORSER` = '" + second_endorser.Text + "'," +
                        "`STATUS` = 'INSTALL TO {0}',`REMARKS` = '" + Remarks.Text + "'" +
                        "WHERE (`SERIAL NUMBER` = '" + Serial_number.Text + "')ORDER BY `ENDORSEMENT NUMBER` DESC LIMIT 1", Second_tester.Text));
                    break;
            }
        }
        private void disable_control()
        {
            foreach (Control c in this.Controls)
            {
                if (c == Remarks || c == Save_btn || c == Update_Button || c == Exit_btn || c == Serial_number
                    || c == Second_box || c is RadioButton)
                {
                    continue;
                }
                else if (c == First_box)
                {
                    foreach (Control ctrl in First_box.Controls)
                    {
                        if (ctrl is LinkLabel)
                        {
                            continue;
                        }
                        else
                            ctrl.Enabled = false;
                    }
                }
                else if (c is Label)
                    continue;
                else
                {
                    c.Enabled = false;
                }    
            }
        }
        private void enable_control()
        {
            foreach (Control c in this.Controls)
            {
                if (c == First_box)
                {
                    foreach (Control ctrl in First_box.Controls)
                    {
                        ctrl.Enabled = true;
                    }
                }
                else
                    c.Enabled = true;
            }
        }
        private void all_controls()
        {
            foreach (Control c in this.Controls)
            {
                if (c == Update_Button || c == Second_box || c == Failed_during_others || c == Failure_mode_others)
                {
                    continue;
                }
                else
                {
                    c.Visible = true;
                }
            }
        }
        private void clear_all()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox == Serial_number)
                    {
                        continue;
                    }
                    else
                    {
                        textBox.Visible = false;
                        textBox.Clear();
                    }
                }
                else if (c is ComboBox)
                {
                    ComboBox comboBox = c as ComboBox;
                    comboBox.Visible = false;
                    comboBox.SelectedIndex = -1;
                }
                else if (c is GroupBox)
                {
                    GroupBox groupBox = c as GroupBox;
                    foreach (Control b in groupBox.Controls)
                    {
                        if (b is LinkLabel)
                        {
                            LinkLabel link = b as LinkLabel;
                            link.Text = null;
                        }
                        else if (b is ComboBox)
                        {
                            ComboBox comboBox = b as ComboBox;
                            comboBox.SelectedIndex = -1;
                        }
                        else if (b is DateTimePicker)
                        {
                            DateTimePicker dateTime = b as DateTimePicker;
                            dateTime.ResetText();
                        }
                        else if (b is TextBox)
                        {
                            TextBox textBox = b as TextBox;
                            textBox.Clear();
                        }
                        else continue;
                    }
                    groupBox.Visible = false;
                }
                else if (c is Label)
                {
                    Label label = c as Label;
                    if (label == label1)
                        label.Enabled = true;
                    else label.Visible = false;
                }
                else if (c is RadioButton)
                {
                    c.Visible = false;
                }
            }
            Test_system.Items.Clear();
            Boards.Items.Clear();
            ClearItemsInTesterBox();
        }
        private void Show_second_grpBox()
        {
            if (first_verif_link.Text.Equals(string.Empty) || First_tester.SelectedIndex == -1
                || string.IsNullOrWhiteSpace(First_board_slot.Text)
                || first_endorser.SelectedIndex == -1)
            {
                foreach(Control c in Second_box.Controls)
                {
                    if (c is LinkLabel)
                    {
                        LinkLabel link = c as LinkLabel;
                        link.Text = null;
                    }
                    else if (c is ComboBox)
                    {
                        ComboBox comboBox = c as ComboBox;
                        comboBox.SelectedIndex = -1;
                    }
                    else if (c is DateTimePicker)
                    {
                        DateTimePicker dateTime = c as DateTimePicker;
                        dateTime.ResetText();
                    }
                    else if (c is TextBox)
                    {
                        TextBox textBox = c as TextBox;
                        textBox.Clear();
                    }
                    else
                    {
                        continue;
                    }
                }
                Timer2.Stop();
                Second_box.Visible = false;
                return;
            }
            else
            {
                if (First_Site.Items.Count != 0)
                {
                    if (First_Site.SelectedIndex == -1)
                        return;
                    else
                    {
                        Timer2.Start();
                        Second_box.Visible = true;
                    }
                }
                else
                {
                    Timer2.Start();
                    Second_box.Visible = true;
                }
            }
        }
        private void slot_first(object sender, EventArgs e)
        {
            Show_second_grpBox();
        }
        private void first_verif_endorser(object sender, EventArgs e)
        {
            Show_second_grpBox();
        }
        private bool compare_date()
        {
            if (Date_second_verif.Value < Date_first_verif.Value)
            {
                MessageBox.Show("DATE MUST BE AHEAD TO THE FIRST VERIFICATION DATE");
                Date_second_verif.ResetText();
                return false;
            }
            else
                return true;
        }
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Failed_during_indexchanged(object sender, EventArgs e)
        {
            if (Failed_during.SelectedIndex == 2)
                Failed_during_others.Visible = true;          
            else
            {
                Failed_during_others.Visible = false;
                Failed_during_others.Clear();
            }
        }
        private void Failure_mode_indexchanged(object sender, EventArgs e)
        {
            if (Failure_mode.SelectedIndex == 9)
                Failure_mode_others.Visible = true;
            else
            {
                Failure_mode_others.Visible = false;
                Failure_mode_others.Clear();
            }
        }

        private void FirstDateCheck(object sender, EventArgs e)
        {
            if (Date_first_verif.Value > DateTime.Now)
            {
                MessageBox.Show("INVALID DATE");
                Date_first_verif.ResetText();
            }
        }

        private void SecondDateCheck(object sender, EventArgs e)
        {
            if (Date_second_verif.Value > DateTime.Now)
            {
                MessageBox.Show("INVALID DATE");
                Date_second_verif.ResetText();
            }
        }

        private void First_date(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void Second_date(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void FirstTimer_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            FirstTime.Text = time.ToString("h:mm:ss tt");
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            DateTime time2 = DateTime.Now;
            SecondTime.Text = time2.ToString("h:mm:ss tt");
        }

        private void First_tester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Test_system.Text.Contains("ASL4K"))
            {
                if (First_tester.Text.Contains("ASL4K"))
                {
                    First_Site.Items.Clear();
                    for (int site = 1; site <= 4; site++)
                    {
                        First_Site.Items.Add(site.ToString());
                    }
                    First_Site.Visible = true;
                }
                else First_Site.Visible = false;
            }
            else Show_second_grpBox();
        }
        private void Second_tester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Test_system.Text.Contains("ASL4K") || Test_system.Text.Contains("ASL1K"))
            {
                if (Second_tester.Text.Contains("ASL4K"))
                {
                    Second_Site.Items.Clear();
                    for (int site = 1; site <= 4; site++)
                    {
                        Second_Site.Items.Add(site.ToString());
                    }
                    Second_Site.Visible = true;
                }
                else
                {
                    Second_Site.Items.Clear();
                    Second_Site.Visible = false;
                }
            }
            else return;
        }
        private void ADD_Load(object sender, EventArgs e)
        {
            LoadTesterPlatforms();
        }

        private void LoadTesterPlatforms()
        {
            Boards.Items.Clear();
            Test_system.Items.Clear();
            commands(5);
            if (Connection.OpenConnection())
            {
                MySqlDataReader read_data = command.ExecuteReader();
                while (read_data.Read())
                {
                    Test_system.Items.Add(read_data.GetString("Tester platforms"));
                }
                Connection.CloseConnection();
            }
            else return;
        }
        private void Test_system_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ClearItemsInTesterBox();
            Testers();
            Show_second_grpBox();
            if (DoNotLoadBoard == 1)
            {
                return;
            }
            else
                LoadBoards();
        }
        private void ClearItemsInTesterBox()
        {
            First_Site.Items.Clear();
            Second_Site.Items.Clear();
            First_tester.Items.Clear();
            Second_tester.Items.Clear();
        }
        private void First_Site_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_second_grpBox();
        }
        private void Testers()
        {
            commands(8);
            if (Connection.OpenConnection())
            {
                MySqlDataReader read_data = command.ExecuteReader();
                while (read_data.Read())
                {
                    First_tester.Items.Add(read_data.GetString(Test_system.Text.ToUpper()));
                    Second_tester.Items.Add(read_data.GetString(Test_system.Text.ToUpper()));
                    sites = int.Parse(read_data["SITE"].ToString());
                }
                Connection.CloseConnection();
            }
            else return;
            if (Test_system.Text == "ASL4K")
            {
                command = new MySqlCommand("SELECT * FROM `boards_for_verification`.`asl1k`", Connection.connect);

                if (Connection.OpenConnection())
                {
                    MySqlDataReader readAsl1k = command.ExecuteReader();
                    while (readAsl1k.Read())
                    {
                        Second_tester.Items.Add(readAsl1k.GetString("ASL1K"));
                    }
                    Connection.CloseConnection();
                }

            }
            else if (Test_system.Text == "ASL1K")
            {
                First_Site.Visible = false;
                command = new MySqlCommand("SELECT * FROM `boards_for_verification`.`asl4k`", Connection.connect);
                if (Connection.OpenConnection())
                {
                    MySqlDataReader readAsl4k = command.ExecuteReader();
                    while (readAsl4k.Read())
                    {
                        Second_tester.Items.Add(readAsl4k.GetString("ASL4K"));
                    }
                    Connection.CloseConnection();
                }
            }
            else
            {
                if (sites != 0)
                {
                    for (int CountSite = 1; CountSite <= sites; CountSite++)
                    {
                        First_Site.Items.Add(CountSite.ToString());
                        Second_Site.Items.Add(CountSite.ToString());
                    }
                    Second_Site.Visible = true;
                    First_Site.Visible = true;
                }
                else
                {
                    First_Site.Visible = false;
                    First_Site.Items.Clear();
                    Second_Site.Visible = false;
                    Second_Site.Items.Clear();
                }
            }
        }
        private void LoadBoards()
        {
            Boards.Items.Clear();
            database = "boards_of_testers";
            if (Test_system.Text == "ASL1K" || Test_system.Text == "ASL4K")
                ForTmT = "tmt";
            else
                ForTmT = Test_system.Text;
            boardQuery = string.Format("SELECT * FROM `{0}`.`{1}`", database, ForTmT.ToLower());
            command = new MySqlCommand(boardQuery, Connection.ConnectBoards);

            if (Connection.OpenConnectionForBoards())
            {
                MySqlDataReader LoadBoards = command.ExecuteReader();
                while (LoadBoards.Read())
                {
                    Boards.Items.Add(LoadBoards.GetString(ForTmT.ToUpper()));
                }
                Connection.CloseConnectionForBoards();
            }
            else return;
        }
    }
}
