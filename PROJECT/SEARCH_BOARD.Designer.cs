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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Search_button = new System.Windows.Forms.Button();
            this.search_text = new System.Windows.Forms.TextBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.REFRESH = new System.Windows.Forms.Button();
            this.SERIAL_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PART_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOARD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TESTER_PLATFORMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEST_PROGRAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIRST_DATE_VERIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDORSEMENT_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(30, 12);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(152, 21);
            this.Search_button.TabIndex = 0;
            this.Search_button.Text = "SEARCH";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // search_text
            // 
            this.search_text.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.search_text.Location = new System.Drawing.Point(188, 13);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(139, 20);
            this.search_text.TabIndex = 1;
            this.search_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_Enter);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(354, 12);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(152, 22);
            this.Add_btn.TabIndex = 2;
            this.Add_btn.Text = "ADD/UPDATE BOARD";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(882, 14);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(141, 23);
            this.Exit_btn.TabIndex = 3;
            this.Exit_btn.Text = "EXIT";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewList.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewList.Location = new System.Drawing.Point(12, 43);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewList.RowHeadersVisible = false;
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.Size = new System.Drawing.Size(1011, 467);
            this.dataGridViewList.TabIndex = 4;
            this.dataGridViewList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Click_data);
            // 
            // REFRESH
            // 
            this.REFRESH.Location = new System.Drawing.Point(526, 12);
            this.REFRESH.Name = "REFRESH";
            this.REFRESH.Size = new System.Drawing.Size(139, 22);
            this.REFRESH.TabIndex = 5;
            this.REFRESH.Text = "REFRESH";
            this.REFRESH.UseVisualStyleBackColor = true;
            this.REFRESH.Click += new System.EventHandler(this.REFRESH_Click);
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
            this.FIRST_DATE_VERIF.DataPropertyName = "FIRST DATE";
            this.FIRST_DATE_VERIF.HeaderText = "FIRST DATE VERIF";
            this.FIRST_DATE_VERIF.Name = "FIRST_DATE_VERIF";
            this.FIRST_DATE_VERIF.ReadOnly = true;
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
            // SEARCH_BOARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1036, 535);
            this.Controls.Add(this.REFRESH);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.search_text);
            this.Controls.Add(this.Search_button);
            this.Name = "SEARCH_BOARD";
            this.Text = "SEARCH OR ADD";
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
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button REFRESH;
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