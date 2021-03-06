﻿namespace PROJECT
{
    partial class SEARCH_BOARD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SEARCH_BOARD));
            this.Search_button = new System.Windows.Forms.Button();
            this.search_text = new System.Windows.Forms.TextBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.SERIAL_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PART_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOARD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TESTER_PLATFORMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEST_PROGRAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIRST_DATE_VERIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDORSEMENT_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFRESH = new System.Windows.Forms.Button();
            this.EDIT = new System.Windows.Forms.Button();
            this.Date_search = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.UPDATE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Stats = new System.Windows.Forms.ComboBox();
            this.AREA = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Boards = new System.Windows.Forms.ComboBox();
            this.Tester_platform = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OVERDUE = new System.Windows.Forms.Label();
            this.Count_search = new System.Windows.Forms.Label();
            this.FORWARD = new System.Windows.Forms.Label();
            this.BACK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.Search_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Search_button.Location = new System.Drawing.Point(7, 5);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(150, 21);
            this.Search_button.TabIndex = 0;
            this.Search_button.Text = "SEARCH";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // search_text
            // 
            this.search_text.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.search_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_text.Location = new System.Drawing.Point(163, 5);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(147, 20);
            this.search_text.TabIndex = 1;
            // 
            // Add_btn
            // 
            this.Add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.Add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Add_btn.Location = new System.Drawing.Point(351, 513);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(130, 51);
            this.Add_btn.TabIndex = 2;
            this.Add_btn.Text = "ADD/UPDATE BOARD";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewList.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SERIAL_NUMBER,
            this.PART_NUMBER,
            this.BOARD,
            this.TESTER_PLATFORMS,
            this.TEST_PROGRAM,
            this.FIRST_DATE_VERIF,
            this.STATUS,
            this.ENDORSEMENT_NUMBER});
            this.dataGridViewList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewList.Location = new System.Drawing.Point(7, 75);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            this.dataGridViewList.RowHeadersVisible = false;
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.Size = new System.Drawing.Size(1137, 432);
            this.dataGridViewList.TabIndex = 4;
            this.dataGridViewList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Click_data);
            // 
            // SERIAL_NUMBER
            // 
            this.SERIAL_NUMBER.DataPropertyName = "SERIAL NUMBER";
            this.SERIAL_NUMBER.HeaderText = "SERIAL NUMBER";
            this.SERIAL_NUMBER.Name = "SERIAL_NUMBER";
            this.SERIAL_NUMBER.ReadOnly = true;
            // 
            // PART_NUMBER
            // 
            this.PART_NUMBER.DataPropertyName = "PART NUMBER";
            this.PART_NUMBER.HeaderText = "PART NUMBER";
            this.PART_NUMBER.Name = "PART_NUMBER";
            this.PART_NUMBER.ReadOnly = true;
            // 
            // BOARD
            // 
            this.BOARD.DataPropertyName = "BOARD";
            this.BOARD.HeaderText = "BOARD";
            this.BOARD.Name = "BOARD";
            this.BOARD.ReadOnly = true;
            // 
            // TESTER_PLATFORMS
            // 
            this.TESTER_PLATFORMS.DataPropertyName = "TESTER PLATFORM";
            this.TESTER_PLATFORMS.HeaderText = "TESTER PLATFORM";
            this.TESTER_PLATFORMS.Name = "TESTER_PLATFORMS";
            this.TESTER_PLATFORMS.ReadOnly = true;
            // 
            // TEST_PROGRAM
            // 
            this.TEST_PROGRAM.DataPropertyName = "TEST PROGRAM";
            this.TEST_PROGRAM.HeaderText = "TEST PROGRAM";
            this.TEST_PROGRAM.Name = "TEST_PROGRAM";
            this.TEST_PROGRAM.ReadOnly = true;
            // 
            // FIRST_DATE_VERIF
            // 
            this.FIRST_DATE_VERIF.DataPropertyName = "date_format(`FIRST DATE`,\'%Y-%m-%d\')";
            this.FIRST_DATE_VERIF.HeaderText = "FIRST DATE VERIFIED";
            this.FIRST_DATE_VERIF.Name = "FIRST_DATE_VERIF";
            this.FIRST_DATE_VERIF.ReadOnly = true;
            this.FIRST_DATE_VERIF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FIRST_DATE_VERIF.ToolTipText = "FIRST";
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // ENDORSEMENT_NUMBER
            // 
            this.ENDORSEMENT_NUMBER.DataPropertyName = "ENDORSEMENT NUMBER";
            this.ENDORSEMENT_NUMBER.HeaderText = "ENDORSEMENT NUMBER";
            this.ENDORSEMENT_NUMBER.Name = "ENDORSEMENT_NUMBER";
            this.ENDORSEMENT_NUMBER.ReadOnly = true;
            this.ENDORSEMENT_NUMBER.Visible = false;
            // 
            // REFRESH
            // 
            this.REFRESH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.REFRESH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.REFRESH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.REFRESH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REFRESH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.REFRESH.Location = new System.Drawing.Point(994, 5);
            this.REFRESH.Name = "REFRESH";
            this.REFRESH.Size = new System.Drawing.Size(150, 22);
            this.REFRESH.TabIndex = 5;
            this.REFRESH.Text = "REFRESH ALL";
            this.REFRESH.UseVisualStyleBackColor = false;
            this.REFRESH.Click += new System.EventHandler(this.REFRESH_Click);
            // 
            // EDIT
            // 
            this.EDIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EDIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.EDIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDIT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EDIT.Location = new System.Drawing.Point(662, 513);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(130, 50);
            this.EDIT.TabIndex = 24;
            this.EDIT.Text = "EDIT";
            this.EDIT.UseVisualStyleBackColor = false;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // Date_search
            // 
            this.Date_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Date_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Date_search.CustomFormat = "yyyy-MM-dd";
            this.Date_search.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Date_search.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_search.Location = new System.Drawing.Point(1037, 43);
            this.Date_search.Name = "Date_search";
            this.Date_search.Size = new System.Drawing.Size(106, 20);
            this.Date_search.TabIndex = 26;
            this.Date_search.CloseUp += new System.EventHandler(this.Select_date);
            this.Date_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Date);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(487, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "VERSION 1.0.0.5";
            // 
            // UPDATE
            // 
            this.UPDATE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UPDATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.UPDATE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE.Location = new System.Drawing.Point(7, 514);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(130, 50);
            this.UPDATE.TabIndex = 28;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = false;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(1013, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 30;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(721, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "STATUS:";
            // 
            // Stats
            // 
            this.Stats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Stats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Stats.FormattingEnabled = true;
            this.Stats.Items.AddRange(new object[] {
            "",
            "SPARES",
            "BRG",
            "INSTALL TO A TESTER",
            "FOR SECOND VERIF",
            "FAILURE CHANGED",
            "OVERDUE"});
            this.Stats.Location = new System.Drawing.Point(795, 42);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(177, 21);
            this.Stats.TabIndex = 32;
            this.Stats.SelectionChangeCommitted += new System.EventHandler(this.statusIndexChanged);
            // 
            // AREA
            // 
            this.AREA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AREA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AREA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AREA.FormattingEnabled = true;
            this.AREA.Items.AddRange(new object[] {
            "",
            "A2",
            "A1",
            "B2"});
            this.AREA.Location = new System.Drawing.Point(651, 44);
            this.AREA.Name = "AREA";
            this.AREA.Size = new System.Drawing.Size(64, 21);
            this.AREA.TabIndex = 34;
            this.AREA.SelectionChangeCommitted += new System.EventHandler(this.AreaIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(592, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "AREA:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label4.Location = new System.Drawing.Point(405, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "BOARD:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label5.Location = new System.Drawing.Point(142, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "TESTER PLATFORM:";
            // 
            // Boards
            // 
            this.Boards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Boards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Boards.FormattingEnabled = true;
            this.Boards.Items.AddRange(new object[] {
            ""});
            this.Boards.Location = new System.Drawing.Point(465, 44);
            this.Boards.Name = "Boards";
            this.Boards.Size = new System.Drawing.Size(121, 21);
            this.Boards.TabIndex = 37;
            this.Boards.SelectionChangeCommitted += new System.EventHandler(this.Boardsindexchanged);
            // 
            // Tester_platform
            // 
            this.Tester_platform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tester_platform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tester_platform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tester_platform.FormattingEnabled = true;
            this.Tester_platform.Items.AddRange(new object[] {
            ""});
            this.Tester_platform.Location = new System.Drawing.Point(278, 44);
            this.Tester_platform.Name = "Tester_platform";
            this.Tester_platform.Size = new System.Drawing.Size(121, 21);
            this.Tester_platform.TabIndex = 38;
            this.Tester_platform.SelectionChangeCommitted += new System.EventHandler(this.ShowBoards);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label6.Location = new System.Drawing.Point(978, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "DATE:";
            // 
            // OVERDUE
            // 
            this.OVERDUE.AutoSize = true;
            this.OVERDUE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OVERDUE.ForeColor = System.Drawing.Color.Lime;
            this.OVERDUE.Location = new System.Drawing.Point(13, 48);
            this.OVERDUE.Name = "OVERDUE";
            this.OVERDUE.Size = new System.Drawing.Size(0, 16);
            this.OVERDUE.TabIndex = 40;
            // 
            // Count_search
            // 
            this.Count_search.AutoSize = true;
            this.Count_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.Count_search.Location = new System.Drawing.Point(639, 9);
            this.Count_search.Name = "Count_search";
            this.Count_search.Size = new System.Drawing.Size(0, 16);
            this.Count_search.TabIndex = 41;
            // 
            // FORWARD
            // 
            this.FORWARD.AutoSize = true;
            this.FORWARD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FORWARD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FORWARD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.FORWARD.Location = new System.Drawing.Point(599, 5);
            this.FORWARD.Name = "FORWARD";
            this.FORWARD.Size = new System.Drawing.Size(34, 24);
            this.FORWARD.TabIndex = 42;
            this.FORWARD.Text = ">>";
            this.FORWARD.Click += new System.EventHandler(this.ForwardClick);
            // 
            // BACK
            // 
            this.BACK.AutoSize = true;
            this.BACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.BACK.Location = new System.Drawing.Point(559, 5);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(34, 24);
            this.BACK.TabIndex = 43;
            this.BACK.Text = "<<";
            this.BACK.Click += new System.EventHandler(this.BackClick);
            // 
            // SEARCH_BOARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1151, 575);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.FORWARD);
            this.Controls.Add(this.Count_search);
            this.Controls.Add(this.OVERDUE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tester_platform);
            this.Controls.Add(this.Boards);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AREA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date_search);
            this.Controls.Add(this.EDIT);
            this.Controls.Add(this.REFRESH);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.search_text);
            this.Controls.Add(this.Search_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1167, 614);
            this.Name = "SEARCH_BOARD";
            this.Text = "WELCOME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SEARCH_BOARD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button REFRESH;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.DateTimePicker Date_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Stats;
        private System.Windows.Forms.ComboBox AREA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Boards;
        private System.Windows.Forms.ComboBox Tester_platform;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label OVERDUE;
        private System.Windows.Forms.Label Count_search;
        private System.Windows.Forms.Label FORWARD;
        private System.Windows.Forms.Label BACK;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIAL_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PART_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOARD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TESTER_PLATFORMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEST_PROGRAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIRST_DATE_VERIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDORSEMENT_NUMBER;
    }
}