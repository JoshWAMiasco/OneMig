
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
            this.Option = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddOrDelete
            // 
            this.AddOrDelete.FormattingEnabled = true;
            this.AddOrDelete.Location = new System.Drawing.Point(15, 133);
            this.AddOrDelete.Name = "AddOrDelete";
            this.AddOrDelete.Size = new System.Drawing.Size(205, 238);
            this.AddOrDelete.TabIndex = 0;
            // 
            // Current_List
            // 
            this.Current_List.FormattingEnabled = true;
            this.Current_List.Location = new System.Drawing.Point(255, 136);
            this.Current_List.Name = "Current_List";
            this.Current_List.Size = new System.Drawing.Size(205, 238);
            this.Current_List.TabIndex = 1;
            // 
            // ADD
            // 
            this.ADD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ADD.Location = new System.Drawing.Point(61, 94);
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
            this.label3.Location = new System.Drawing.Point(15, 95);
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
            this.Tester_platforms.Location = new System.Drawing.Point(172, 33);
            this.Tester_platforms.Name = "Tester_platforms";
            this.Tester_platforms.Size = new System.Drawing.Size(130, 21);
            this.Tester_platforms.TabIndex = 4;
            this.Tester_platforms.SelectedIndexChanged += new System.EventHandler(this.Tester_platfrom);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
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
            this.Save_btn.Location = new System.Drawing.Point(15, 397);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(117, 41);
            this.Save_btn.TabIndex = 6;
            this.Save_btn.Text = "SAVE";
            this.Save_btn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "CURRENT";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(345, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Option
            // 
            this.Option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Option.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Option.FormattingEnabled = true;
            this.Option.Items.AddRange(new object[] {
            "ADD",
            "DELETE"});
            this.Option.Location = new System.Drawing.Point(172, 6);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(130, 21);
            this.Option.TabIndex = 10;
            this.Option.SelectedIndexChanged += new System.EventHandler(this.Option_selection);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "OPTION";
            // 
            // EDIT_TESTERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Option);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tester_platforms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.Current_List);
            this.Controls.Add(this.AddOrDelete);
            this.Name = "EDIT_TESTERS";
            this.Text = "ADD/DELETE";
            this.Load += new System.EventHandler(this.EDIT_TESTERS_Load);
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
        private System.Windows.Forms.ComboBox Option;
        private System.Windows.Forms.Label label4;
    }
}