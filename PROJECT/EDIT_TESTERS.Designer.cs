
namespace PROJECT
{
    partial class EDIT_TESTERS
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
            this.AddOrDelete = new System.Windows.Forms.ListBox();
            this.Current_List = new System.Windows.Forms.ListBox();
            this.ADD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tester_platforms = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Mode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.REMOVE = new System.Windows.Forms.Button();
            this.AddOrRemoveText = new System.Windows.Forms.Label();
            this.Editor_panel = new System.Windows.Forms.Panel();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Log_in = new System.Windows.Forms.Panel();
            this.Log_out = new System.Windows.Forms.LinkLabel();
            this.Board = new System.Windows.Forms.RadioButton();
            this.Tester = new System.Windows.Forms.RadioButton();
            this.SearchBoard = new System.Windows.Forms.LinkLabel();
            this.Save_progress = new System.Windows.Forms.ProgressBar();
            this.saveText = new System.Windows.Forms.Label();
            this.Editor_panel.SuspendLayout();
            this.Log_in.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddOrDelete
            // 
            this.AddOrDelete.FormattingEnabled = true;
            this.AddOrDelete.Location = new System.Drawing.Point(5, 190);
            this.AddOrDelete.Name = "AddOrDelete";
            this.AddOrDelete.Size = new System.Drawing.Size(205, 238);
            this.AddOrDelete.TabIndex = 0;
            // 
            // Current_List
            // 
            this.Current_List.FormattingEnabled = true;
            this.Current_List.Location = new System.Drawing.Point(245, 189);
            this.Current_List.Name = "Current_List";
            this.Current_List.Size = new System.Drawing.Size(205, 238);
            this.Current_List.TabIndex = 1;
            // 
            // ADD
            // 
            this.ADD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ADD.Location = new System.Drawing.Point(51, 151);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(159, 20);
            this.ADD.TabIndex = 2;
            this.ADD.Visible = false;
            this.ADD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Add_Tester);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ADD";
            this.label3.Visible = false;
            // 
            // Tester_platforms
            // 
            this.Tester_platforms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tester_platforms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tester_platforms.FormattingEnabled = true;
            this.Tester_platforms.Location = new System.Drawing.Point(162, 52);
            this.Tester_platforms.Name = "Tester_platforms";
            this.Tester_platforms.Size = new System.Drawing.Size(130, 21);
            this.Tester_platforms.TabIndex = 4;
            this.Tester_platforms.SelectedIndexChanged += new System.EventHandler(this.Tester_platforms_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "TESTER PLATFORM";
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.Location = new System.Drawing.Point(5, 454);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(117, 41);
            this.Save_btn.TabIndex = 6;
            this.Save_btn.Text = "SAVE";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "CURRENT";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(335, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mode
            // 
            this.Mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Mode.FormattingEnabled = true;
            this.Mode.Items.AddRange(new object[] {
            "ADD",
            "DELETE"});
            this.Mode.Location = new System.Drawing.Point(162, 29);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(130, 21);
            this.Mode.TabIndex = 10;
            this.Mode.SelectedIndexChanged += new System.EventHandler(this.Option_selection);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "CHOOSE MODE";
            // 
            // REMOVE
            // 
            this.REMOVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.REMOVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.REMOVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REMOVE.Location = new System.Drawing.Point(170, 455);
            this.REMOVE.Name = "REMOVE";
            this.REMOVE.Size = new System.Drawing.Size(115, 40);
            this.REMOVE.TabIndex = 12;
            this.REMOVE.Text = "REMOVE";
            this.REMOVE.UseVisualStyleBackColor = false;
            this.REMOVE.Click += new System.EventHandler(this.REMOVE_Click);
            // 
            // AddOrRemoveText
            // 
            this.AddOrRemoveText.AutoSize = true;
            this.AddOrRemoveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrRemoveText.Location = new System.Drawing.Point(292, 81);
            this.AddOrRemoveText.Name = "AddOrRemoveText";
            this.AddOrRemoveText.Size = new System.Drawing.Size(0, 16);
            this.AddOrRemoveText.TabIndex = 13;
            // 
            // Editor_panel
            // 
            this.Editor_panel.Controls.Add(this.Tester);
            this.Editor_panel.Controls.Add(this.Board);
            this.Editor_panel.Controls.Add(this.Current_List);
            this.Editor_panel.Controls.Add(this.AddOrDelete);
            this.Editor_panel.Controls.Add(this.button1);
            this.Editor_panel.Controls.Add(this.ADD);
            this.Editor_panel.Controls.Add(this.AddOrRemoveText);
            this.Editor_panel.Controls.Add(this.label3);
            this.Editor_panel.Controls.Add(this.REMOVE);
            this.Editor_panel.Controls.Add(this.Tester_platforms);
            this.Editor_panel.Controls.Add(this.label4);
            this.Editor_panel.Controls.Add(this.label1);
            this.Editor_panel.Controls.Add(this.Mode);
            this.Editor_panel.Controls.Add(this.Save_btn);
            this.Editor_panel.Controls.Add(this.label2);
            this.Editor_panel.Location = new System.Drawing.Point(12, 83);
            this.Editor_panel.Name = "Editor_panel";
            this.Editor_panel.Size = new System.Drawing.Size(455, 498);
            this.Editor_panel.TabIndex = 16;
            this.Editor_panel.Visible = false;
            // 
            // Username
            // 
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.Location = new System.Drawing.Point(85, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(140, 20);
            this.Username.TabIndex = 17;
            this.Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.User);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(85, 27);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(140, 20);
            this.Password.TabIndex = 18;
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pass);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "USERNAME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "PASSWORD";
            // 
            // Log_in
            // 
            this.Log_in.Controls.Add(this.label7);
            this.Log_in.Controls.Add(this.label6);
            this.Log_in.Controls.Add(this.Password);
            this.Log_in.Controls.Add(this.Username);
            this.Log_in.Location = new System.Drawing.Point(234, 10);
            this.Log_in.Name = "Log_in";
            this.Log_in.Size = new System.Drawing.Size(233, 67);
            this.Log_in.TabIndex = 21;
            // 
            // Log_out
            // 
            this.Log_out.AutoSize = true;
            this.Log_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Log_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_out.LinkColor = System.Drawing.Color.Black;
            this.Log_out.Location = new System.Drawing.Point(393, 9);
            this.Log_out.Name = "Log_out";
            this.Log_out.Size = new System.Drawing.Size(74, 16);
            this.Log_out.TabIndex = 22;
            this.Log_out.TabStop = true;
            this.Log_out.Text = "LOG OUT";
            this.Log_out.Visible = false;
            this.Log_out.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Board
            // 
            this.Board.AutoSize = true;
            this.Board.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Board.Location = new System.Drawing.Point(8, 79);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(89, 20);
            this.Board.TabIndex = 14;
            this.Board.TabStop = true;
            this.Board.Text = "BOARDS";
            this.Board.UseVisualStyleBackColor = true;
            this.Board.Click += new System.EventHandler(this.Boards_mode);
            // 
            // Tester
            // 
            this.Tester.AutoSize = true;
            this.Tester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tester.Location = new System.Drawing.Point(8, 106);
            this.Tester.Name = "Tester";
            this.Tester.Size = new System.Drawing.Size(87, 20);
            this.Tester.TabIndex = 15;
            this.Tester.TabStop = true;
            this.Tester.Text = "TESTER";
            this.Tester.UseVisualStyleBackColor = true;
            this.Tester.Click += new System.EventHandler(this.Tester_mode);
            // 
            // SearchBoard
            // 
            this.SearchBoard.AutoSize = true;
            this.SearchBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBoard.LinkColor = System.Drawing.Color.Black;
            this.SearchBoard.Location = new System.Drawing.Point(17, 16);
            this.SearchBoard.Name = "SearchBoard";
            this.SearchBoard.Size = new System.Drawing.Size(192, 16);
            this.SearchBoard.TabIndex = 23;
            this.SearchBoard.TabStop = true;
            this.SearchBoard.Text = "BOARD ENDORSEMENTS";
            this.SearchBoard.Visible = false;
            this.SearchBoard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // Save_progress
            // 
            this.Save_progress.Location = new System.Drawing.Point(12, 58);
            this.Save_progress.Name = "Save_progress";
            this.Save_progress.Size = new System.Drawing.Size(100, 18);
            this.Save_progress.TabIndex = 24;
            this.Save_progress.Visible = false;
            // 
            // saveText
            // 
            this.saveText.AutoSize = true;
            this.saveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveText.Location = new System.Drawing.Point(111, 60);
            this.saveText.Name = "saveText";
            this.saveText.Size = new System.Drawing.Size(84, 16);
            this.saveText.TabIndex = 25;
            this.saveText.Text = "SAVING.....";
            this.saveText.Visible = false;
            // 
            // EDIT_TESTERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(480, 593);
            this.Controls.Add(this.saveText);
            this.Controls.Add(this.Save_progress);
            this.Controls.Add(this.SearchBoard);
            this.Controls.Add(this.Log_out);
            this.Controls.Add(this.Log_in);
            this.Controls.Add(this.Editor_panel);
            this.Name = "EDIT_TESTERS";
            this.Text = "ADD/DELETE";
            this.Load += new System.EventHandler(this.EDIT_TESTERS_Load);
            this.Editor_panel.ResumeLayout(false);
            this.Editor_panel.PerformLayout();
            this.Log_in.ResumeLayout(false);
            this.Log_in.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AddOrDelete;
        private System.Windows.Forms.ListBox Current_List;
        private System.Windows.Forms.TextBox ADD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Tester_platforms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Mode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button REMOVE;
        private System.Windows.Forms.Label AddOrRemoveText;
        private System.Windows.Forms.Panel Editor_panel;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Log_in;
        private System.Windows.Forms.LinkLabel Log_out;
        private System.Windows.Forms.RadioButton Tester;
        private System.Windows.Forms.RadioButton Board;
        private System.Windows.Forms.LinkLabel SearchBoard;
        private System.Windows.Forms.ProgressBar Save_progress;
        private System.Windows.Forms.Label saveText;
    }
}