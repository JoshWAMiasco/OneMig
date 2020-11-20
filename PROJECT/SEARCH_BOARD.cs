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
using PROJECT.boards_for_verificationDataSet2TableAdapters;
using System.Runtime.InteropServices;
using Ubiety.Dns.Core.Records.NotUsed;

namespace PROJECT
{
    public partial class SEARCH_BOARD : Form
    {
        //MySqlConnection Connect = new MySqlConnection("server=mpoctsgdb.maxim-ic.com;user id = a2_utilities;password = a2_utilities;database=a2_utitilies");
        MySqlConnection Connect = new MySqlConnection("server=localhost;user id=root;password=onemigso101996;database=boards_for_verification;persistsecurityinfo=True");
        MySqlCommand command;
        public SEARCH_BOARD()
        {
            InitializeComponent();
        }

        private void SEARCH_BOARD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'boards_for_verificationDataSet2.board_details' table. You can move, or remove it, as needed.
            try
            {
                this.board_detailsTableAdapter.Fill(this.boards_for_verificationDataSet2.board_details);
            }
            catch (Exception me)
            {
                MessageBox.Show(me.ToString());
            }
        }
        private void Click_data(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewList.Columns[e.ColumnIndex].ToolTipText == "hello")
            {
                try
                {
                    dataGridViewList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    try
                    {
                        System.Diagnostics.Process.Start(dataGridViewList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    }
                    catch (Exception me)
                    {
                        MessageBox.Show("SYSTEM CANNOT LOCATE THE FILE SPECIFIED");
                    }
                }
                catch (Exception me)
                {
                    return;
                }
            }
            else if (dataGridViewList.Columns[e.ColumnIndex].HeaderText == "REMARKS")
            {
                try
                {
                    MessageBox.Show(dataGridViewList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                }
                catch (Exception me)
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }
        private void commands(int cmd)
        {
            switch(cmd)
            {
                case 0:
                    command = new MySqlCommand("SELECT COUNT(*) FROM `boards_for_verification`.`board details` WHERE (`SERIAL NUMBER` = '" + search_text.Text + "' OR `PART NUMBER` = '" + search_text.Text + "' OR " +
                   "`BOARD` = '" + search_text.Text + "' OR `TESTER` = '" + search_text.Text + "' OR `DIE TYPE` = '" + search_text.Text + "' OR `TEST OPTION` = '" + search_text.Text + "'" +
                  "OR `DATE FIRST` = '" + search_text.Text + "' OR `1ST VERIFIED BY` = '" + search_text.Text + "' OR `DATE SECOND` = '" + search_text.Text + "' OR `2ND VERIFIED BY` = '" + search_text.Text + "'" +
                  "OR `STATUS` = '" + search_text.Text + "') ORDER BY `DATE FIRST` DESC LIMIT 30");
                    break;
                case 1:
                    command = new MySqlCommand("SELECT * FROM `boards_for_verification`.`board details` WHERE (`SERIAL NUMBER` = '" + search_text.Text + "' OR `PART NUMBER` = '" + search_text.Text + "' OR " +
                   "`BOARD` = '" + search_text.Text + "' OR `TESTER` = '" + search_text.Text + "' OR `DIE TYPE` = '" + search_text.Text + "' OR `TEST OPTION` = '" + search_text.Text + "'" +
                  "OR `DATE FIRST` = '" + search_text.Text + "' OR `1ST VERIFIED BY` = '" + search_text.Text + "' OR `2ND VERIFIED BY` = '" + search_text.Text + "'" +
                  "OR `STATUS` = '" + search_text.Text + "') ORDER BY `DATE FIRST` DESC LIMIT 30");
                    break;

            }
        }
        private DataTable table()
        {
            commands(1);
            command.Connection = Connect;
            Connect.Open();
            MySqlDataAdapter read = new MySqlDataAdapter(command);
            DataTable new_data = new DataTable();
            read.Fill(new_data);
            Connect.Close();
            return new_data;
        }
        private void load_data()
        {
            if (search_text.Text == string.Empty)
            {
                MessageBox.Show("NO INPUT");
            }
            else
            {
                commands(0);
                command.Connection = Connect;
                Connect.Open();
                string check = command.ExecuteScalar().ToString();
                Connect.Close();
                if (check == "0")
                {
                    MessageBox.Show("NO DATA");
                    return;
                }
                else
                {
                    Connect.Close();
                    dataGridViewList.DataSource = table();
                }
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            //yes
            load_data();
        }

        private void key_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                load_data();
            }
        }
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CHOOSE next = new CHOOSE();
            next.ShowDialog();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADD next = new ADD();
            next.ShowDialog();
        }

    }
}
