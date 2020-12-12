﻿namespace PROJECT
{
    partial class ADD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Save_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Serial_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Part_number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Board = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Test_program = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.First_board_slot = new System.Windows.Forms.TextBox();
            this.Add_first_verif = new System.Windows.Forms.Button();
            this.first_verif_link = new System.Windows.Forms.LinkLabel();
            this.Date_first_verif = new System.Windows.Forms.DateTimePicker();
            this.Date_second_verif = new System.Windows.Forms.DateTimePicker();
            this.second_verif_link = new System.Windows.Forms.LinkLabel();
            this.Add_second_verif = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Test_option = new System.Windows.Forms.ComboBox();
            this.first_endorser = new System.Windows.Forms.ComboBox();
            this.second_endorser = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Second_verif_text = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.Update_Button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Remarks = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.First_Site = new System.Windows.Forms.ComboBox();
            this.Second_Site = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Second_box = new System.Windows.Forms.GroupBox();
            this.Second_tester = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Second_slot = new System.Windows.Forms.TextBox();
            this.First_box = new System.Windows.Forms.GroupBox();
            this.First_tester = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Revision = new System.Windows.Forms.TextBox();
            this.Failed_during = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Failure_mode = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Failed_during_others = new System.Windows.Forms.TextBox();
            this.Failure_mode_others = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Test_system = new System.Windows.Forms.ComboBox();
            this.SPARES = new System.Windows.Forms.RadioButton();
            this.BRG = new System.Windows.Forms.RadioButton();
            this.FOR_SECOND_VERIF = new System.Windows.Forms.RadioButton();
            this.FAILURE_CHANGED = new System.Windows.Forms.RadioButton();
            this.INSTALL_TO_TESTER = new System.Windows.Forms.RadioButton();
            this.Second_box.SuspendLayout();
            this.First_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.Location = new System.Drawing.Point(388, 644);
            this.Save_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(141, 66);
            this.Save_btn.TabIndex = 0;
            this.Save_btn.Text = "SAVE";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Visible = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Location = new System.Drawing.Point(1043, 645);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(141, 66);
            this.Exit_btn.TabIndex = 1;
            this.Exit_btn.Text = "EXIT";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Serial_number
            // 
            this.Serial_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Serial_number.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serial_number.Location = new System.Drawing.Point(198, 23);
            this.Serial_number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Serial_number.Name = "Serial_number";
            this.Serial_number.Size = new System.Drawing.Size(140, 21);
            this.Serial_number.TabIndex = 2;
            this.Serial_number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "SERIAL NUMBER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(30, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "PART NUMBER";
            this.label2.Visible = false;
            // 
            // Part_number
            // 
            this.Part_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Part_number.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Part_number.Location = new System.Drawing.Point(198, 71);
            this.Part_number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Part_number.Name = "Part_number";
            this.Part_number.Size = new System.Drawing.Size(140, 21);
            this.Part_number.TabIndex = 4;
            this.Part_number.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(28, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "BOARD";
            this.label3.Visible = false;
            // 
            // Board
            // 
            this.Board.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Board.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Board.Location = new System.Drawing.Point(198, 169);
            this.Board.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(140, 21);
            this.Board.TabIndex = 6;
            this.Board.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "TESTER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label5.Location = new System.Drawing.Point(27, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "LAST TEST PROGRAM";
            this.label5.Visible = false;
            // 
            // Test_program
            // 
            this.Test_program.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Test_program.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test_program.Location = new System.Drawing.Point(198, 218);
            this.Test_program.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Test_program.Name = "Test_program";
            this.Test_program.Size = new System.Drawing.Size(140, 21);
            this.Test_program.TabIndex = 10;
            this.Test_program.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label6.Location = new System.Drawing.Point(26, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "TEST OPTION";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "SLOT";
            // 
            // First_board_slot
            // 
            this.First_board_slot.Location = new System.Drawing.Point(159, 245);
            this.First_board_slot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.First_board_slot.Name = "First_board_slot";
            this.First_board_slot.Size = new System.Drawing.Size(140, 20);
            this.First_board_slot.TabIndex = 14;
            this.First_board_slot.TextChanged += new System.EventHandler(this.slot_first);
            // 
            // Add_first_verif
            // 
            this.Add_first_verif.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Add_first_verif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_first_verif.Location = new System.Drawing.Point(21, 23);
            this.Add_first_verif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add_first_verif.Name = "Add_first_verif";
            this.Add_first_verif.Size = new System.Drawing.Size(167, 30);
            this.Add_first_verif.TabIndex = 16;
            this.Add_first_verif.Text = "ADD FIRST VERIF";
            this.Add_first_verif.UseVisualStyleBackColor = false;
            this.Add_first_verif.Click += new System.EventHandler(this.Add_first_verif_Click);
            // 
            // first_verif_link
            // 
            this.first_verif_link.AutoSize = true;
            this.first_verif_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.first_verif_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_verif_link.LinkColor = System.Drawing.Color.Black;
            this.first_verif_link.Location = new System.Drawing.Point(21, 74);
            this.first_verif_link.Name = "first_verif_link";
            this.first_verif_link.Size = new System.Drawing.Size(0, 13);
            this.first_verif_link.TabIndex = 17;
            this.first_verif_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.first_verif_link_LinkClicked);
            // 
            // Date_first_verif
            // 
            this.Date_first_verif.CustomFormat = "yyyy-MM-dd";
            this.Date_first_verif.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_first_verif.Location = new System.Drawing.Point(21, 112);
            this.Date_first_verif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Date_first_verif.Name = "Date_first_verif";
            this.Date_first_verif.Size = new System.Drawing.Size(166, 20);
            this.Date_first_verif.TabIndex = 18;
            // 
            // Date_second_verif
            // 
            this.Date_second_verif.CustomFormat = "yyyy-MM-dd";
            this.Date_second_verif.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_second_verif.Location = new System.Drawing.Point(22, 112);
            this.Date_second_verif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Date_second_verif.Name = "Date_second_verif";
            this.Date_second_verif.Size = new System.Drawing.Size(166, 20);
            this.Date_second_verif.TabIndex = 21;
            this.Date_second_verif.Visible = false;
            // 
            // second_verif_link
            // 
            this.second_verif_link.ActiveLinkColor = System.Drawing.Color.Red;
            this.second_verif_link.AutoSize = true;
            this.second_verif_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second_verif_link.LinkColor = System.Drawing.Color.Black;
            this.second_verif_link.Location = new System.Drawing.Point(22, 79);
            this.second_verif_link.Name = "second_verif_link";
            this.second_verif_link.Size = new System.Drawing.Size(0, 13);
            this.second_verif_link.TabIndex = 20;
            this.second_verif_link.Visible = false;
            this.second_verif_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.second_verif_link_LinkClicked);
            // 
            // Add_second_verif
            // 
            this.Add_second_verif.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Add_second_verif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_second_verif.Location = new System.Drawing.Point(22, 28);
            this.Add_second_verif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add_second_verif.Name = "Add_second_verif";
            this.Add_second_verif.Size = new System.Drawing.Size(167, 30);
            this.Add_second_verif.TabIndex = 19;
            this.Add_second_verif.Text = "ADD SECOND VERIF";
            this.Add_second_verif.UseVisualStyleBackColor = false;
            this.Add_second_verif.Click += new System.EventHandler(this.Add_second_verif_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label8.Location = new System.Drawing.Point(98, 535);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "CHOOSE STATUS";
            this.label8.Visible = false;
            // 
            // Test_option
            // 
            this.Test_option.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Test_option.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test_option.FormattingEnabled = true;
            this.Test_option.Items.AddRange(new object[] {
            "FT_HOT",
            "FT_ROOM",
            "FT_COLD",
            "QA_HOT",
            "QA_ROOM",
            "QA_COLD",
            "N/A"});
            this.Test_option.Location = new System.Drawing.Point(198, 473);
            this.Test_option.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Test_option.Name = "Test_option";
            this.Test_option.Size = new System.Drawing.Size(140, 23);
            this.Test_option.TabIndex = 24;
            this.Test_option.Visible = false;
            // 
            // first_endorser
            // 
            this.first_endorser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.first_endorser.FormattingEnabled = true;
            this.first_endorser.Items.AddRange(new object[] {
            "JOHN MICHAEL SO",
            "KINGSON VICTORIO",
            "RALPH ARVIN CANDA",
            "SUSANA SAN GABRIEL",
            "BABYLYN HILARIO",
            "JEFFERSON AMARO"});
            this.first_endorser.Location = new System.Drawing.Point(145, 286);
            this.first_endorser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.first_endorser.Name = "first_endorser";
            this.first_endorser.Size = new System.Drawing.Size(177, 21);
            this.first_endorser.TabIndex = 25;
            this.first_endorser.SelectedIndexChanged += new System.EventHandler(this.first_verif_endorser);
            // 
            // second_endorser
            // 
            this.second_endorser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.second_endorser.FormattingEnabled = true;
            this.second_endorser.Items.AddRange(new object[] {
            "JOHN MICHAEL SO",
            "KINGSON VICTORIO",
            "RALPH ARVIN CANDA",
            "SUSANA SAN GABRIEL",
            "BABYLYN HILARIO",
            "JEFFERSON AMARO"});
            this.second_endorser.Location = new System.Drawing.Point(141, 286);
            this.second_endorser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.second_endorser.Name = "second_endorser";
            this.second_endorser.Size = new System.Drawing.Size(177, 21);
            this.second_endorser.TabIndex = 26;
            this.second_endorser.SelectedIndexChanged += new System.EventHandler(this.second_verif_showdate);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "VERIFIED BY";
            // 
            // Second_verif_text
            // 
            this.Second_verif_text.AutoSize = true;
            this.Second_verif_text.Location = new System.Drawing.Point(19, 286);
            this.Second_verif_text.Name = "Second_verif_text";
            this.Second_verif_text.Size = new System.Drawing.Size(84, 13);
            this.Second_verif_text.TabIndex = 28;
            this.Second_verif_text.Text = "VERIFIED BY";
            // 
            // Update_Button
            // 
            this.Update_Button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Button.Location = new System.Drawing.Point(703, 645);
            this.Update_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(141, 66);
            this.Update_Button.TabIndex = 29;
            this.Update_Button.Text = "UPDATE";
            this.Update_Button.UseVisualStyleBackColor = false;
            this.Update_Button.Visible = false;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label10.Location = new System.Drawing.Point(385, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 21);
            this.label10.TabIndex = 30;
            this.label10.Text = "PROBLEM DESCRIPTION";
            this.label10.Visible = false;
            // 
            // Remarks
            // 
            this.Remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Remarks.Location = new System.Drawing.Point(388, 363);
            this.Remarks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Remarks.Multiline = true;
            this.Remarks.Name = "Remarks";
            this.Remarks.Size = new System.Drawing.Size(795, 232);
            this.Remarks.TabIndex = 31;
            this.Remarks.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "SITE/SECTOR";
            // 
            // First_Site
            // 
            this.First_Site.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.First_Site.FormattingEnabled = true;
            this.First_Site.Location = new System.Drawing.Point(159, 201);
            this.First_Site.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.First_Site.Name = "First_Site";
            this.First_Site.Size = new System.Drawing.Size(140, 21);
            this.First_Site.TabIndex = 33;
            this.First_Site.Visible = false;
            this.First_Site.SelectedIndexChanged += new System.EventHandler(this.First_Site_SelectedIndexChanged);
            // 
            // Second_Site
            // 
            this.Second_Site.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Second_Site.FormattingEnabled = true;
            this.Second_Site.Location = new System.Drawing.Point(160, 201);
            this.Second_Site.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Second_Site.Name = "Second_Site";
            this.Second_Site.Size = new System.Drawing.Size(140, 21);
            this.Second_Site.TabIndex = 37;
            this.Second_Site.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "SITE/SECTOR";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "TESTER";
            // 
            // Second_box
            // 
            this.Second_box.BackColor = System.Drawing.Color.Gray;
            this.Second_box.Controls.Add(this.Second_tester);
            this.Second_box.Controls.Add(this.label14);
            this.Second_box.Controls.Add(this.Date_second_verif);
            this.Second_box.Controls.Add(this.Second_slot);
            this.Second_box.Controls.Add(this.Add_second_verif);
            this.Second_box.Controls.Add(this.second_verif_link);
            this.Second_box.Controls.Add(this.Second_Site);
            this.Second_box.Controls.Add(this.second_endorser);
            this.Second_box.Controls.Add(this.label12);
            this.Second_box.Controls.Add(this.Second_verif_text);
            this.Second_box.Controls.Add(this.label13);
            this.Second_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Second_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Second_box.Location = new System.Drawing.Point(792, 6);
            this.Second_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Second_box.Name = "Second_box";
            this.Second_box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Second_box.Size = new System.Drawing.Size(392, 334);
            this.Second_box.TabIndex = 40;
            this.Second_box.TabStop = false;
            this.Second_box.Text = "SECOND VERIFICATION DETAILS";
            this.Second_box.Visible = false;
            // 
            // Second_tester
            // 
            this.Second_tester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Second_tester.FormattingEnabled = true;
            this.Second_tester.Location = new System.Drawing.Point(160, 160);
            this.Second_tester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Second_tester.Name = "Second_tester";
            this.Second_tester.Size = new System.Drawing.Size(140, 21);
            this.Second_tester.TabIndex = 35;
            this.Second_tester.SelectedIndexChanged += new System.EventHandler(this.Second_tester_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "SLOT";
            // 
            // Second_slot
            // 
            this.Second_slot.Location = new System.Drawing.Point(160, 246);
            this.Second_slot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Second_slot.Name = "Second_slot";
            this.Second_slot.Size = new System.Drawing.Size(140, 20);
            this.Second_slot.TabIndex = 34;
            // 
            // First_box
            // 
            this.First_box.BackColor = System.Drawing.Color.Gray;
            this.First_box.Controls.Add(this.First_tester);
            this.First_box.Controls.Add(this.first_endorser);
            this.First_box.Controls.Add(this.label9);
            this.First_box.Controls.Add(this.First_Site);
            this.First_box.Controls.Add(this.Add_first_verif);
            this.First_box.Controls.Add(this.label11);
            this.First_box.Controls.Add(this.label4);
            this.First_box.Controls.Add(this.first_verif_link);
            this.First_box.Controls.Add(this.label7);
            this.First_box.Controls.Add(this.Date_first_verif);
            this.First_box.Controls.Add(this.First_board_slot);
            this.First_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_box.Location = new System.Drawing.Point(388, 6);
            this.First_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.First_box.Name = "First_box";
            this.First_box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.First_box.Size = new System.Drawing.Size(370, 334);
            this.First_box.TabIndex = 41;
            this.First_box.TabStop = false;
            this.First_box.Text = "FIRST VERIFICATION DETAILS";
            this.First_box.Visible = false;
            // 
            // First_tester
            // 
            this.First_tester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.First_tester.FormattingEnabled = true;
            this.First_tester.Location = new System.Drawing.Point(159, 160);
            this.First_tester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.First_tester.Name = "First_tester";
            this.First_tester.Size = new System.Drawing.Size(140, 21);
            this.First_tester.TabIndex = 34;
            this.First_tester.SelectedIndexChanged += new System.EventHandler(this.First_tester_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label15.Location = new System.Drawing.Point(27, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 21);
            this.label15.TabIndex = 43;
            this.label15.Text = "REVISION";
            this.label15.Visible = false;
            // 
            // Revision
            // 
            this.Revision.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Revision.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Revision.Location = new System.Drawing.Point(198, 120);
            this.Revision.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Revision.Name = "Revision";
            this.Revision.Size = new System.Drawing.Size(140, 21);
            this.Revision.TabIndex = 42;
            this.Revision.Visible = false;
            // 
            // Failed_during
            // 
            this.Failed_during.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Failed_during.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Failed_during.FormattingEnabled = true;
            this.Failed_during.Items.AddRange(new object[] {
            "Gauge Study",
            "Low-Yield Verification",
            "OTHERS",
            "Scheduled Calibration",
            "Set-up Verification"});
            this.Failed_during.Location = new System.Drawing.Point(198, 319);
            this.Failed_during.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Failed_during.Name = "Failed_during";
            this.Failed_during.Size = new System.Drawing.Size(140, 23);
            this.Failed_during.TabIndex = 45;
            this.Failed_during.Visible = false;
            this.Failed_during.SelectedIndexChanged += new System.EventHandler(this.Failed_during_indexchanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label16.Location = new System.Drawing.Point(26, 322);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 21);
            this.label16.TabIndex = 44;
            this.label16.Text = "FAILED DURING";
            this.label16.Visible = false;
            // 
            // Failure_mode
            // 
            this.Failure_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Failure_mode.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Failure_mode.FormattingEnabled = true;
            this.Failure_mode.Items.AddRange(new object[] {
            "CALIBRATION",
            "CHECKER",
            "DETECTION PROBLEM",
            "DVI SPIKE CHECKER",
            "EXTERNAL DRIVER",
            "GAUGE",
            "N/A",
            "POST CALIBRATION",
            "VERIFY",
            "OTHERS"});
            this.Failure_mode.Location = new System.Drawing.Point(198, 396);
            this.Failure_mode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Failure_mode.Name = "Failure_mode";
            this.Failure_mode.Size = new System.Drawing.Size(140, 23);
            this.Failure_mode.TabIndex = 47;
            this.Failure_mode.Visible = false;
            this.Failure_mode.SelectedIndexChanged += new System.EventHandler(this.Failure_mode_indexchanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label17.Location = new System.Drawing.Point(30, 394);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 21);
            this.label17.TabIndex = 46;
            this.label17.Text = "FAILURE MODE";
            this.label17.Visible = false;
            // 
            // Failed_during_others
            // 
            this.Failed_during_others.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Failed_during_others.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Failed_during_others.Location = new System.Drawing.Point(177, 351);
            this.Failed_during_others.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Failed_during_others.Name = "Failed_during_others";
            this.Failed_during_others.Size = new System.Drawing.Size(161, 21);
            this.Failed_during_others.TabIndex = 48;
            this.Failed_during_others.Visible = false;
            // 
            // Failure_mode_others
            // 
            this.Failure_mode_others.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Failure_mode_others.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Failure_mode_others.Location = new System.Drawing.Point(177, 428);
            this.Failure_mode_others.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Failure_mode_others.Name = "Failure_mode_others";
            this.Failure_mode_others.Size = new System.Drawing.Size(161, 21);
            this.Failure_mode_others.TabIndex = 49;
            this.Failure_mode_others.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label18.Location = new System.Drawing.Point(30, 270);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 21);
            this.label18.TabIndex = 51;
            this.label18.Text = "TEST SYSTEM";
            this.label18.Visible = false;
            // 
            // Test_system
            // 
            this.Test_system.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Test_system.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test_system.FormattingEnabled = true;
            this.Test_system.Location = new System.Drawing.Point(198, 267);
            this.Test_system.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Test_system.Name = "Test_system";
            this.Test_system.Size = new System.Drawing.Size(140, 23);
            this.Test_system.TabIndex = 52;
            this.Test_system.Visible = false;
            this.Test_system.SelectionChangeCommitted += new System.EventHandler(this.Test_system_SelectionChangeCommitted);
            // 
            // SPARES
            // 
            this.SPARES.AutoSize = true;
            this.SPARES.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPARES.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.SPARES.Location = new System.Drawing.Point(37, 584);
            this.SPARES.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SPARES.Name = "SPARES";
            this.SPARES.Size = new System.Drawing.Size(85, 25);
            this.SPARES.TabIndex = 53;
            this.SPARES.TabStop = true;
            this.SPARES.Text = "SPARES";
            this.SPARES.UseVisualStyleBackColor = true;
            this.SPARES.Visible = false;
            // 
            // BRG
            // 
            this.BRG.AutoSize = true;
            this.BRG.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.BRG.Location = new System.Drawing.Point(37, 630);
            this.BRG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BRG.Name = "BRG";
            this.BRG.Size = new System.Drawing.Size(61, 25);
            this.BRG.TabIndex = 54;
            this.BRG.TabStop = true;
            this.BRG.Text = "BRG";
            this.BRG.UseVisualStyleBackColor = true;
            this.BRG.Visible = false;
            // 
            // FOR_SECOND_VERIF
            // 
            this.FOR_SECOND_VERIF.AutoSize = true;
            this.FOR_SECOND_VERIF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FOR_SECOND_VERIF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.FOR_SECOND_VERIF.Location = new System.Drawing.Point(37, 674);
            this.FOR_SECOND_VERIF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FOR_SECOND_VERIF.Name = "FOR_SECOND_VERIF";
            this.FOR_SECOND_VERIF.Size = new System.Drawing.Size(179, 25);
            this.FOR_SECOND_VERIF.TabIndex = 55;
            this.FOR_SECOND_VERIF.TabStop = true;
            this.FOR_SECOND_VERIF.Text = "FOR SECOND VERIF";
            this.FOR_SECOND_VERIF.UseVisualStyleBackColor = true;
            this.FOR_SECOND_VERIF.Visible = false;
            // 
            // FAILURE_CHANGED
            // 
            this.FAILURE_CHANGED.AutoSize = true;
            this.FAILURE_CHANGED.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FAILURE_CHANGED.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.FAILURE_CHANGED.Location = new System.Drawing.Point(177, 584);
            this.FAILURE_CHANGED.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FAILURE_CHANGED.Name = "FAILURE_CHANGED";
            this.FAILURE_CHANGED.Size = new System.Drawing.Size(167, 25);
            this.FAILURE_CHANGED.TabIndex = 56;
            this.FAILURE_CHANGED.TabStop = true;
            this.FAILURE_CHANGED.Text = "FAILURE CHANGE";
            this.FAILURE_CHANGED.UseVisualStyleBackColor = true;
            this.FAILURE_CHANGED.Visible = false;
            // 
            // INSTALL_TO_TESTER
            // 
            this.INSTALL_TO_TESTER.AutoSize = true;
            this.INSTALL_TO_TESTER.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSTALL_TO_TESTER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.INSTALL_TO_TESTER.Location = new System.Drawing.Point(177, 630);
            this.INSTALL_TO_TESTER.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.INSTALL_TO_TESTER.Name = "INSTALL_TO_TESTER";
            this.INSTALL_TO_TESTER.Size = new System.Drawing.Size(170, 25);
            this.INSTALL_TO_TESTER.TabIndex = 57;
            this.INSTALL_TO_TESTER.TabStop = true;
            this.INSTALL_TO_TESTER.Text = "INSTALL TO TESTER";
            this.INSTALL_TO_TESTER.UseVisualStyleBackColor = true;
            this.INSTALL_TO_TESTER.Visible = false;
            // 
            // ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1217, 757);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.INSTALL_TO_TESTER);
            this.Controls.Add(this.Test_system);
            this.Controls.Add(this.SPARES);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.FAILURE_CHANGED);
            this.Controls.Add(this.BRG);
            this.Controls.Add(this.Failure_mode_others);
            this.Controls.Add(this.FOR_SECOND_VERIF);
            this.Controls.Add(this.Failed_during_others);
            this.Controls.Add(this.Failure_mode);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Failed_during);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Revision);
            this.Controls.Add(this.First_box);
            this.Controls.Add(this.Second_box);
            this.Controls.Add(this.Remarks);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Test_option);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Test_program);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Board);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Part_number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Serial_number);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Save_btn);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ADD";
            this.Text = " ADD BOARD DETAILS";
            this.Load += new System.EventHandler(this.ADD_Load);
            this.Second_box.ResumeLayout(false);
            this.Second_box.PerformLayout();
            this.First_box.ResumeLayout(false);
            this.First_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Part_number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Board;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Test_program;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox First_board_slot;
        private System.Windows.Forms.Button Add_first_verif;
        private System.Windows.Forms.LinkLabel first_verif_link;
        private System.Windows.Forms.DateTimePicker Date_first_verif;
        private System.Windows.Forms.DateTimePicker Date_second_verif;
        private System.Windows.Forms.LinkLabel second_verif_link;
        private System.Windows.Forms.Button Add_second_verif;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Test_option;
        private System.Windows.Forms.ComboBox first_endorser;
        private System.Windows.Forms.ComboBox second_endorser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Second_verif_text;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Remarks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox First_Site;
        private System.Windows.Forms.ComboBox Second_Site;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox Second_box;
        private System.Windows.Forms.GroupBox First_box;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Second_slot;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Revision;
        private System.Windows.Forms.ComboBox Failed_during;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox Failure_mode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Failed_during_others;
        private System.Windows.Forms.TextBox Failure_mode_others;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox Test_system;
        private System.Windows.Forms.ComboBox Second_tester;
        private System.Windows.Forms.ComboBox First_tester;
        public System.Windows.Forms.TextBox Serial_number;
        private System.Windows.Forms.RadioButton SPARES;
        private System.Windows.Forms.RadioButton BRG;
        private System.Windows.Forms.RadioButton FOR_SECOND_VERIF;
        private System.Windows.Forms.RadioButton FAILURE_CHANGED;
        private System.Windows.Forms.RadioButton INSTALL_TO_TESTER;
    }
}