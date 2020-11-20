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
using Renci.SshNet.Security;
using Ubiety.Dns.Core.Records.NotUsed;
using MySqlX.XDevAPI;


namespace PROJECT
{
    public partial class ADD : Form
    {
        //public MySqlConnection connect = new MySqlConnection("server=mpoctsgdb.maxim-ic.com;user id=a2_utilities;password = a2_utilities;database=a2_utitilies");
        public MySqlConnection connect = new MySqlConnection("server=localhost;user id=root;password=onemigso101996;database=boards_for_verification;persistsecurityinfo=True");
        public MySqlCommand command;
        string get_status;
        string incomplete = "INCOMPLETE DETAILS!";
        
        public ADD()
        {
            InitializeComponent();
        }
        private void error()
        {
            MessageBox.Show(incomplete);
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (Status.Text == "FOR SECOND VERIF")
            {
                MessageBox.Show("INVALID STATUS");
                return;
            }
            else
            {
                if (second_endorser.Text == string.Empty || second_verif_link.Text == string.Empty)
                {
                    error();
                    return;
                }
            }
            DialogResult yes_no = MessageBox.Show("THIS WILL BE SAVE PERMANENTLY, CONTINUE?", "ATTENTION", MessageBoxButtons.YesNo);
            switch (yes_no)
            {
                case DialogResult.Yes:
                    commands(3);
                    command.Connection = connect;
                    open_connection();
                    command.ExecuteNonQuery();
                    Close_connection();
                    MessageBox.Show("FILE UPDATED SUCCESSFULLY");
                    clear_all();
                    Serial_number.Visible = true;
                    Serial_number.Clear();
                    enable_control();
                    break;
                case DialogResult.No:
                    return;
            }
            
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox text = c as TextBox;
                    if (text == Failed_during_others || text == Failure_mode_others)
                        continue;
                    else if (string.IsNullOrWhiteSpace(text.Text))
                    {
                        error();
                        return;
                    }
                }
                else if (c is ComboBox)
                {
                    ComboBox combo = c as ComboBox;
                    if (combo == Failed_during)
                    {
                        if (Failed_during.SelectedIndex == 2)
                        {
                            if (string.IsNullOrWhiteSpace(Failed_during_others.Text))
                            {
                                error();
                                return;
                            }
                        }
                    }
                    else if (combo == Failure_mode)
                    {
                        if (Failure_mode.SelectedIndex == 9)
                        {
                            if (string.IsNullOrWhiteSpace(Failure_mode_others.Text))
                            {
                                error();
                                return;
                            }
                        }
                    }
                    else if (combo == Status)
                        continue;
                    else
                    {
                        if (combo.SelectedIndex == -1)
                        {
                            error();
                            return;
                        }    
                    }
                }
                else if (c is GroupBox)
                {
                    GroupBox groupBox = c as GroupBox;
                    {
                        if (groupBox == First_box)
                        {
                            foreach (Control ctrlBox in First_box.Controls)
                            {
                                continue;
                            }
                        }
                    }
                }
            }
            if (Status.Text == "SPARE")
            {
                MessageBox.Show("INVALID STATUS");
                return;
            }
            else if (string.IsNullOrEmpty(second_endorser.Text) && string.IsNullOrEmpty(second_verif_link.Text))  //CONDITION IF THERE'S NO SECOND VERIFICATION DETAILS
            {
                if ( Status.Text == "BRG" )
                {
                    MessageBox.Show("INVALID STATUS");
                    return;
                }
                DialogResult yes_no = MessageBox.Show("NO SECOND VERIFICATION DETIALS, DO YOU WANT TO SAVE IT?", "ATTENTION!", MessageBoxButtons.YesNo);
                switch (yes_no)
                {
                    case DialogResult.Yes:
                        commands(2);
                        command.Connection = connect;
                        open_connection();
                        command.ExecuteNonQuery();
                        Close_connection();
                        MessageBox.Show("FILE SAVED SUCCESSFULLY");
                        clear_all();
                        Serial_number.Visible = true;
                        Serial_number.Clear();
                        break;
                    case DialogResult.No:
                        break;


                }
            }
            else   //KAPAG KUMPLETO DETAILS, FIRST AND SECOND VERIF.
            {
                if ( Status.Text == "FOR SECOND VERIF")
                {
                    MessageBox.Show("INVALID STATUS");
                    return;
                }
                DialogResult yes_no = MessageBox.Show("THIS WILL BE SAVE PERMANENTLY, CONTINUE?", "ATTENTION", MessageBoxButtons.YesNo);
                switch (yes_no)
                {
                    case DialogResult.Yes:
                        commands(2);
                        command.Connection = connect;
                        open_connection();
                        command.ExecuteNonQuery();
                        Close_connection();
                        MessageBox.Show("FILE SAVED SUCCESSFULLY");
                        clear_all();
                        Serial_number.Visible = true;
                        Serial_number.Clear();
                        break;
                    case DialogResult.No:
                        break;
                }
                
            }
        }
        public bool open_connection()
        {
            try
            {
                connect.Open();
                return true;
            }
            catch (MySqlException me)
            {
                switch(me.Number)
                {
                    case 0:
                        MessageBox.Show("CANNOT CONNECT TO THE SERVER, CHECK THE NETWORK OR CONTACT ADMINISTRATOR");
                        break;
                    default:
                        MessageBox.Show(me.ToString());
                        break;
                }
                return false;
            }
        }
        public bool Close_connection()
        {
            try
            {
                connect.Close();
                return true;
            }
            catch (MySqlException me)
            {
                MessageBox.Show(me.ToString());
                return false;
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
                if (second_verif_link.Visible == true && second_endorser.SelectedIndex >= 0)
                {
                    Date_second_verif.Visible = true;
                }
            }
        }

        private void first_verif_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void Key_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                commands(1);

                command.Connection = connect;

                open_connection();
                MySqlDataReader read_data = command.ExecuteReader();
                read_data.Read();
                try
                {
                    get_status = read_data["STATUS"].ToString();
                    if (get_status == "SPARE" || get_status == "BRG")
                    {
                        DialogResult yes_no = MessageBox.Show("LAST TRANSACTION WAS ENDORSED TO " + get_status + ", ADD A NEW?", "ATTENTION!",
                            MessageBoxButtons.YesNo);
                        switch (yes_no)
                        {
                            case DialogResult.Yes:
                                clear_all();
                                enable_control();
                                all_controls();
                                Part_number.Text = read_data["PART NUMBER"].ToString();
                                Board.Text = read_data["BOARD"].ToString();
                                Close_connection();
                                return;
                            case DialogResult.No:
                                clear_all();
                                enable_control();
                                Serial_number.Clear();
                                clear_all();
                                Close_connection();
                                return;
                        }
                    }
                    else
                    {
                        all_controls();
                        Save_btn.Visible = false;
                        Update_Button.Visible = true;
                        Part_number.Text = read_data["PART NUMBER"].ToString();
                        Board.Text = read_data["BOARD"].ToString();
                        First_tester.Text = read_data["TESTER"].ToString();
                        Die_type.Text = read_data["DIE TYPE"].ToString();
                        Test_option.Text = read_data["TEST OPTION"].ToString();
                        First_board_slot.Text = read_data["SLOT"].ToString();
                        Date_first_verif.Text = read_data["DATE FIRST"].ToString();
                        first_endorser.Text = read_data["1ST VERIFIED BY"].ToString();
                        first_verif_link.Text = read_data["FIRST VERIF"].ToString();
                        First_Site.Text = read_data["SITE"].ToString();
                        Status.Text = read_data["STATUS"].ToString();
                        Remarks.Text = read_data["REMARKS"].ToString();
                        disable_control();
                        Close_connection();
                        return;
                    }
                }
                catch (Exception me)
                {
                    DialogResult yes_no = MessageBox.Show("NO DATA, ADD NEW?", "ATTENTION!", MessageBoxButtons.YesNo);
                    switch (yes_no)
                    {
                        case DialogResult.Yes:
                            enable_control();
                            clear_all();
                            all_controls();
                            Close_connection();
                            return;
                        case DialogResult.No:
                            Serial_number.Clear();
                            clear_all();
                            Close_connection();
                            return;                          
                    }
                }
                
                                        
            }
        }


        private void commands(int Pick)
        {
            switch (Pick)
            {
                case 1:  // FOR EDITING LAST TRANSACTION
                    command = new MySqlCommand("SELECT * FROM `boards_for_verification`.`board details`" +
                    "WHERE `SERIAL NUMBER` = '" + Serial_number.Text + "' LIMIT 1");
                    break;

                case 2:  // FOR ADDING A NEW TRANSACTION
                    command = new MySqlCommand("INSERT INTO `boards_for_verification`." +
            "`board details`(`SERIAL NUMBER`,`PART NUMBER`,BOARD,TESTER,`SITE`,`DIE TYPE`,`TEST OPTION`,`SLOT`,`FIRST VERIF`," +
            "`DATE FIRST`,`1ST VERIFIED BY`,`SECOND VERIF`,`DATE SECOND`,`2ND VERIFIED BY`,`STATUS`,`REMARKS`) VALUES('" + Serial_number.Text + "'," +
            "'" + Part_number.Text + "','" + Board.Text + "','" + First_tester.Text + "','" + First_Site.Text + "','" + Die_type.Text + "','" + Test_option.Text + "'," +
            "'" + First_board_slot.Text + "','" + MySqlHelper.EscapeString(first_verif_link.Text) + "','" + Date_first_verif.Text + "'," +
            "'" + first_endorser.Text + "','" + MySqlHelper.EscapeString(second_verif_link.Text) + "','" + Date_second_verif.Text + "'," +
            "'" + second_endorser.Text + "','" + Status.Text + "','" + Remarks.Text + "')");
                    break;

                case 3:  // FOR UPDATING THE LAST TRANSACTION
                    command = new MySqlCommand("UPDATE `boards_for_verification`.`board details` SET `SECOND VERIF` = '" + MySqlHelper.EscapeString(second_verif_link.Text) + "'," +
                        "`DATE SECOND` = '" + Date_second_verif.Text + "',`2ND VERIFIED BY` = '" + second_endorser.Text + "',`STATUS` = '" + Status.Text + "'," +
                        "`REMARKS` = '" + Remarks.Text + "'" +
                        "WHERE (`SERIAL NUMBER` = '" + Serial_number.Text + "') LIMIT 1");
                    break;
            }
        }
        private void disable_control()
        {
            foreach (Control c in this.Controls)
            {
                if (c == second_endorser || c == second_verif_link || c == Date_second_verif || c == Add_second_verif || c == Remarks ||
                    c == Save_btn || c == Update_Button || c == Exit_btn || c == Serial_number || c == Status || c == first_verif_link)
                {
                    continue;
                }
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
                c.Enabled = true;
            }
        }
        private void all_controls()
        {
            foreach (Control c in this.Controls)
            {
                if ( c == second_endorser || c == second_verif_link || c == Date_second_verif || c == First_Site ||
                    c == Add_second_verif || c == Update_Button || c == Second_box || c == Failed_during_others || c == Failure_mode_others)
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
            }
        }

        private void Tester_TextChanged(object sender, EventArgs e)
        {
            if (First_tester.Text == "ASL4K017" || First_tester.Text == "ASL4K030" || First_tester.Text == "ASL4K029" || First_tester.Text == "ASL4K023" || First_tester.Text == "ASL4K012" || First_tester.Text == "ASL4K002" || First_tester.Text == "ASL4K035")
            {
                First_Site.Visible = true;
            }
            else if (First_tester.Text != string.Empty)
            {
                First_Site.Visible = false;
                First_Site.SelectedIndex = -1;
                Show_second_grpBox();
            }
            else
            {
                Second_box.Visible = false;
                return;
            }
        }

        private void Show_second_grpBox()
        {
            if (string.IsNullOrWhiteSpace(first_verif_link.Text) || string.IsNullOrWhiteSpace(first_endorser.Text) || string.IsNullOrWhiteSpace(First_board_slot.Text)
                || string.IsNullOrWhiteSpace(first_endorser.Text))
                return;
            else
                Second_box.Visible = true;
        }
        
        private void slot_first(object sender, EventArgs e)
        {
            if (First_board_slot.Text == string.Empty)
            {
                Second_box.Visible = false;
                return;
            }
            else
                Show_second_grpBox();
        }

        private void first_verif_endorser(object sender, EventArgs e)
        {
            if (first_endorser.SelectedIndex > -1)
                Show_second_grpBox();
        }
        private void compare_date(object sender, EventArgs e)
        {
            if (Date_second_verif.Value < Date_first_verif.Value)
            {
                MessageBox.Show("DATE MUST BE AHEAD TO THE FIRST VERIFICATION DATE");
                Date_second_verif.ResetText();
                return;
            }
        }
        private void second_verif_showdate(object sender, EventArgs e)
        {
            if (second_verif_link.Text == string.Empty || second_endorser.Text == string.Empty)
            {
                Date_second_verif.Visible = false;
            }
            else
            {
                Date_second_verif.Visible = true;
            }
        }
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SEARCH_BOARD back = new SEARCH_BOARD();
            back.ShowDialog();
        }

        private void Failed_during_indexchanged(object sender, EventArgs e)
        {
            if (Failed_during.SelectedIndex == 2)
                Failed_during_others.Visible = true;          
            else
            {
                Failed_during_others.Visible = false;
                Failed_during_others = null;
            }
        }

        private void Failure_mode_indexchanged(object sender, EventArgs e)
        {
            if (Failure_mode.SelectedIndex == 12)
                Failure_mode_others.Visible = true;
            else
            {
                Failure_mode_others.Visible = false;
                Failure_mode_others = null;
            }
        }
    }
}
