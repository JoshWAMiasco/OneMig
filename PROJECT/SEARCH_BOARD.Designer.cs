namespace PROJECT
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
            this.Exit_btn = new System.Windows.Forms.Button();
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
            this.Log_in = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Log_out = new System.Windows.Forms.LinkLabel();
            this.EDIT = new System.Windows.Forms.Button();
            this.DUE_DATE = new System.Windows.Forms.LinkLabel();
            this.Date_search = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.UPDATE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.Log_in.SuspendLayout();
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
            this.Search_button.Size = new System.Drawing.Size(111, 21);
            this.Search_button.TabIndex = 0;
            this.Search_button.Text = "SEARCH";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // search_text
            // 
            this.search_text.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.search_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_text.Location = new System.Drawing.Point(124, 7);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(147, 20);
            this.search_text.TabIndex = 1;
            this.search_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_Enter);
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.Add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Add_btn.Location = new System.Drawing.Point(389, 5);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(162, 22);
            this.Add_btn.TabIndex = 2;
            this.Add_btn.Text = "ADD/UPDATE BOARD";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Visible = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Location = new System.Drawing.Point(982, 30);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(164, 23);
            this.Exit_btn.TabIndex = 3;
            this.Exit_btn.Text = "EXIT";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Visible = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
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
            this.dataGridViewList.Location = new System.Drawing.Point(7, 74);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            this.dataGridViewList.RowHeadersVisible = false;
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.Size = new System.Drawing.Size(1140, 500);
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
            this.REFRESH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.REFRESH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.REFRESH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REFRESH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.REFRESH.Location = new System.Drawing.Point(7, 30);
            this.REFRESH.Name = "REFRESH";
            this.REFRESH.Size = new System.Drawing.Size(111, 22);
            this.REFRESH.TabIndex = 5;
            this.REFRESH.Text = "REFRESH";
            this.REFRESH.UseVisualStyleBackColor = false;
            this.REFRESH.Click += new System.EventHandler(this.REFRESH_Click);
            // 
            // Log_in
            // 
            this.Log_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Log_in.Controls.Add(this.label7);
            this.Log_in.Controls.Add(this.label6);
            this.Log_in.Controls.Add(this.Password);
            this.Log_in.Controls.Add(this.Username);
            this.Log_in.Location = new System.Drawing.Point(875, 5);
            this.Log_in.Name = "Log_in";
            this.Log_in.Size = new System.Drawing.Size(272, 50);
            this.Log_in.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label7.Location = new System.Drawing.Point(15, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "PASSWORD";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label6.Location = new System.Drawing.Point(15, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "USERNAME";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(108, 27);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(163, 20);
            this.Password.TabIndex = 18;
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pass);
            // 
            // Username
            // 
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.Location = new System.Drawing.Point(108, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(163, 20);
            this.Username.TabIndex = 17;
            this.Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.User);
            // 
            // Log_out
            // 
            this.Log_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Log_out.AutoSize = true;
            this.Log_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Log_out.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.Log_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.Log_out.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.Log_out.Location = new System.Drawing.Point(1072, 5);
            this.Log_out.Name = "Log_out";
            this.Log_out.Size = new System.Drawing.Size(74, 16);
            this.Log_out.TabIndex = 23;
            this.Log_out.TabStop = true;
            this.Log_out.Text = "LOG OUT";
            this.Log_out.Visible = false;
            this.Log_out.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Log_out_LinkClicked);
            // 
            // EDIT
            // 
            this.EDIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.EDIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDIT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EDIT.Location = new System.Drawing.Point(557, 5);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(162, 22);
            this.EDIT.TabIndex = 24;
            this.EDIT.Text = "EDIT";
            this.EDIT.UseVisualStyleBackColor = false;
            this.EDIT.Visible = false;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // DUE_DATE
            // 
            this.DUE_DATE.AutoSize = true;
            this.DUE_DATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DUE_DATE.LinkColor = System.Drawing.Color.Yellow;
            this.DUE_DATE.Location = new System.Drawing.Point(127, 35);
            this.DUE_DATE.Name = "DUE_DATE";
            this.DUE_DATE.Size = new System.Drawing.Size(0, 16);
            this.DUE_DATE.TabIndex = 25;
            this.DUE_DATE.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DUE_DATE_LinkClicked);
            // 
            // Date_search
            // 
            this.Date_search.CustomFormat = "yyyy-MM-dd";
            this.Date_search.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Date_search.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_search.Location = new System.Drawing.Point(277, 8);
            this.Date_search.Name = "Date_search";
            this.Date_search.Size = new System.Drawing.Size(106, 20);
            this.Date_search.TabIndex = 26;
            this.Date_search.CloseUp += new System.EventHandler(this.selectDate);
            this.Date_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Date);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "VERSION 1.0.1";
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.UPDATE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE.Location = new System.Drawing.Point(722, 5);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(147, 23);
            this.UPDATE.TabIndex = 28;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = false;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // SEARCH_BOARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1154, 575);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date_search);
            this.Controls.Add(this.DUE_DATE);
            this.Controls.Add(this.EDIT);
            this.Controls.Add(this.Log_out);
            this.Controls.Add(this.Log_in);
            this.Controls.Add(this.REFRESH);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.Exit_btn);
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
            this.Log_in.ResumeLayout(false);
            this.Log_in.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button REFRESH;
        private System.Windows.Forms.Panel Log_in;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.LinkLabel Log_out;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.LinkLabel DUE_DATE;
        private System.Windows.Forms.DateTimePicker Date_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UPDATE;
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