namespace PROJECT
{
    partial class CHOOSE
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
            this.System_Limit = new System.Windows.Forms.Button();
            this.Boards_for_Verif = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.EDIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // System_Limit
            // 
            this.System_Limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.System_Limit.Location = new System.Drawing.Point(50, 38);
            this.System_Limit.Name = "System_Limit";
            this.System_Limit.Size = new System.Drawing.Size(175, 59);
            this.System_Limit.TabIndex = 0;
            this.System_Limit.Text = "SYSTEM LIMITATIONS";
            this.System_Limit.UseVisualStyleBackColor = true;
            // 
            // Boards_for_Verif
            // 
            this.Boards_for_Verif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boards_for_Verif.Location = new System.Drawing.Point(273, 38);
            this.Boards_for_Verif.Name = "Boards_for_Verif";
            this.Boards_for_Verif.Size = new System.Drawing.Size(175, 59);
            this.Boards_for_Verif.TabIndex = 1;
            this.Boards_for_Verif.Text = "BOARDS FOR VERIFICATION";
            this.Boards_for_Verif.UseVisualStyleBackColor = true;
            this.Boards_for_Verif.Click += new System.EventHandler(this.Boards_for_Verif_Click);
            // 
            // EXIT
            // 
            this.EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.Location = new System.Drawing.Point(50, 127);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(175, 52);
            this.EXIT.TabIndex = 2;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // EDIT
            // 
            this.EDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDIT.Location = new System.Drawing.Point(273, 127);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(175, 52);
            this.EDIT.TabIndex = 3;
            this.EDIT.Text = "EDIT";
            this.EDIT.UseVisualStyleBackColor = true;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // CHOOSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(479, 245);
            this.Controls.Add(this.EDIT);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.Boards_for_Verif);
            this.Controls.Add(this.System_Limit);
            this.Name = "CHOOSE";
            this.Text = "CHOOSE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button System_Limit;
        private System.Windows.Forms.Button Boards_for_Verif;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button EDIT;
    }
}