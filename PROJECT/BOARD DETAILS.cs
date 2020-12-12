﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace PROJECT
{
    public partial class BOARD_DETAILS : Form
    {
        MySqlCommand command;
        byte[] Data1,Data2;
        public string FileName1, Filename2;
        public int Endorsement_number { get; set; }
        public string other_failure_mode, other_failed_during;

        public BOARD_DETAILS(string number)
        {
            InitializeComponent();
            Endorsement_number = Convert.ToInt32(number);
        }

        private void Load_Boards(object sender, EventArgs e)
        {
            command = new MySqlCommand("SELECT `SERIAL NUMBER`,`PART NUMBER`,REVISION,BOARD,`TEST PROGRAM`,`FAILED DURING`,`FAILED DURING OTHERS`,`FAILURE MODE`,`FAILURE MODE OTHERS`," +
            "`TEST OPTION`,STATUS,REMARKS,`FIRST DATALOG`,`FIRST DATE`,`FIRST TESTER`,`FIRST SITE`,`FIRST SLOT`,`FIRST ENDORSER`,`SECOND DATALOG`,`SECOND DATE`," +
            "`SECOND TESTER`,`SECOND SITE`,`SECOND SLOT`,`SECOND ENDORSER`,`FILENAME 1`,`FILENAME 2` FROM `boards_for_verification`.`board details` " +
            "WHERE (`ENDORSEMENT NUMBER` = '" + Endorsement_number + "')");

            command.Connection = Connection.connect;

            if (Connection.OpenConnection())
            {
                MySqlDataReader read_data = command.ExecuteReader();
                read_data.Read();

                Serial_number.Text = read_data["SERIAL NUMBER"].ToString();
                Part_number.Text = read_data["PART NUMBER"].ToString();
                Board.Text = read_data["BOARD"].ToString();
                Revision.Text = read_data["REVISION"].ToString();
                Board.Text = read_data["BOARD"].ToString();
                Test_program.Text = read_data["TEST PROGRAM"].ToString();
                Failed_during.Text = read_data["FAILED DURING"].ToString();
                other_failed_during = read_data["FAILED DURING OTHERS"].ToString();
                Failure_mode.Text = read_data["FAILURE MODE"].ToString();
                other_failure_mode = read_data["FAILURE MODE OTHERS"].ToString();
                Test_option.Text = read_data["TEST OPTION"].ToString();
                Remarks.Text = read_data["REMARKS"].ToString();
                Status.Text = read_data["STATUS"].ToString();
                Data1 = (byte[])read_data["FIRST DATALOG"];
                First_date.Text = read_data["FIRST DATE"].ToString();
                First_tester.Text = read_data["FIRST TESTER"].ToString();
                First_site.Text = read_data["FIRST SITE"].ToString();
                First_slot.Text = read_data["FIRST SLOT"].ToString();
                First_endorser.Text = read_data["FIRST ENDORSER"].ToString();
                Second_verif_link.Text = read_data["SECOND DATALOG"].ToString();
                if (Second_verif_link.Text != String.Empty)
                    Data2 = (byte[])read_data["SECOND DATALOG"];
                Second_date.Text = read_data["SECOND DATE"].ToString();
                Second_tester.Text = read_data["SECOND TESTER"].ToString();
                Second_site.Text = read_data["SECOND SITE"].ToString();
                Second_slot.Text = read_data["SECOND SLOT"].ToString();
                Second_endorser.Text = read_data["SECOND ENDORSER"].ToString();
                FileName1 = read_data["FILENAME 1"].ToString();
                Filename2 = read_data["FILENAME 2"].ToString();
                Connection.CloseConnection();
                First_verif_link.Text = FileName1;
                Second_verif_link.Text = Filename2;
                if (Failed_during.Text.ToUpper() == "OTHERS")
                {
                    Failed_during.Text = other_failed_during;
                }
                if (Failure_mode.Text == "OTHERS")
                {
                    Failure_mode.Text = other_failure_mode;
                }
            }
            else return;

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void First_verif_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            File.WriteAllBytes(FileName1, Data1);
            System.Diagnostics.Process.Start(FileName1);
        }

        private void Second_verif_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            File.WriteAllBytes(Filename2, Data2);
            System.Diagnostics.Process.Start(Filename2);
        }
    }
}