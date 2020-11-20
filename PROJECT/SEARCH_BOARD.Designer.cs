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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Search_button = new System.Windows.Forms.Button();
            this.search_text = new System.Windows.Forms.TextBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.sERIALNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARTNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOARDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tESTERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sITEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIETYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tESTOPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLOTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTVERIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dATEFIRSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTVERIFIEDBYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECONDVERIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dATESECONDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDVERIFIEDBYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEMARKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boardDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boards_for_verificationDataSet2 = new PROJECT.boards_for_verificationDataSet2();
            this.board_detailsTableAdapter = new PROJECT.boards_for_verificationDataSet2TableAdapters.board_detailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boards_for_verificationDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(13, 13);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(117, 22);
            this.Search_button.TabIndex = 0;
            this.Search_button.Text = "SEARCH";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // search_text
            // 
            this.search_text.Location = new System.Drawing.Point(136, 15);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(139, 20);
            this.search_text.TabIndex = 1;
            this.search_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_Enter);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(281, 15);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(152, 22);
            this.Add_btn.TabIndex = 2;
            this.Add_btn.Text = "ADD/UPDATE BOARD";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(647, 12);
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
            this.dataGridViewList.AutoGenerateColumns = false;
            this.dataGridViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sERIALNUMBERDataGridViewTextBoxColumn,
            this.pARTNUMBERDataGridViewTextBoxColumn,
            this.bOARDDataGridViewTextBoxColumn,
            this.tESTERDataGridViewTextBoxColumn,
            this.sITEDataGridViewTextBoxColumn,
            this.dIETYPEDataGridViewTextBoxColumn,
            this.tESTOPTIONDataGridViewTextBoxColumn,
            this.sLOTDataGridViewTextBoxColumn,
            this.fIRSTVERIFDataGridViewTextBoxColumn,
            this.dATEFIRSTDataGridViewTextBoxColumn,
            this.sTVERIFIEDBYDataGridViewTextBoxColumn,
            this.sECONDVERIFDataGridViewTextBoxColumn,
            this.dATESECONDDataGridViewTextBoxColumn,
            this.nDVERIFIEDBYDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn,
            this.rEMARKSDataGridViewTextBoxColumn});
            this.dataGridViewList.DataSource = this.boardDetailsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewList.Location = new System.Drawing.Point(13, 54);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewList.RowHeadersVisible = false;
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.Size = new System.Drawing.Size(775, 384);
            this.dataGridViewList.TabIndex = 4;
            this.dataGridViewList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Click_data);
            // 
            // sERIALNUMBERDataGridViewTextBoxColumn
            // 
            this.sERIALNUMBERDataGridViewTextBoxColumn.DataPropertyName = "SERIAL NUMBER";
            this.sERIALNUMBERDataGridViewTextBoxColumn.HeaderText = "SERIAL NUMBER";
            this.sERIALNUMBERDataGridViewTextBoxColumn.Name = "sERIALNUMBERDataGridViewTextBoxColumn";
            this.sERIALNUMBERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pARTNUMBERDataGridViewTextBoxColumn
            // 
            this.pARTNUMBERDataGridViewTextBoxColumn.DataPropertyName = "PART NUMBER";
            this.pARTNUMBERDataGridViewTextBoxColumn.HeaderText = "PART NUMBER";
            this.pARTNUMBERDataGridViewTextBoxColumn.Name = "pARTNUMBERDataGridViewTextBoxColumn";
            this.pARTNUMBERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bOARDDataGridViewTextBoxColumn
            // 
            this.bOARDDataGridViewTextBoxColumn.DataPropertyName = "BOARD";
            this.bOARDDataGridViewTextBoxColumn.HeaderText = "BOARD";
            this.bOARDDataGridViewTextBoxColumn.Name = "bOARDDataGridViewTextBoxColumn";
            this.bOARDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tESTERDataGridViewTextBoxColumn
            // 
            this.tESTERDataGridViewTextBoxColumn.DataPropertyName = "TESTER";
            this.tESTERDataGridViewTextBoxColumn.HeaderText = "TESTER";
            this.tESTERDataGridViewTextBoxColumn.Name = "tESTERDataGridViewTextBoxColumn";
            this.tESTERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sITEDataGridViewTextBoxColumn
            // 
            this.sITEDataGridViewTextBoxColumn.DataPropertyName = "SITE";
            this.sITEDataGridViewTextBoxColumn.HeaderText = "SITE";
            this.sITEDataGridViewTextBoxColumn.Name = "sITEDataGridViewTextBoxColumn";
            this.sITEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIETYPEDataGridViewTextBoxColumn
            // 
            this.dIETYPEDataGridViewTextBoxColumn.DataPropertyName = "DIE TYPE";
            this.dIETYPEDataGridViewTextBoxColumn.HeaderText = "DIE TYPE";
            this.dIETYPEDataGridViewTextBoxColumn.Name = "dIETYPEDataGridViewTextBoxColumn";
            this.dIETYPEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tESTOPTIONDataGridViewTextBoxColumn
            // 
            this.tESTOPTIONDataGridViewTextBoxColumn.DataPropertyName = "TEST OPTION";
            this.tESTOPTIONDataGridViewTextBoxColumn.HeaderText = "TEST OPTION";
            this.tESTOPTIONDataGridViewTextBoxColumn.Name = "tESTOPTIONDataGridViewTextBoxColumn";
            this.tESTOPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sLOTDataGridViewTextBoxColumn
            // 
            this.sLOTDataGridViewTextBoxColumn.DataPropertyName = "SLOT";
            this.sLOTDataGridViewTextBoxColumn.HeaderText = "SLOT";
            this.sLOTDataGridViewTextBoxColumn.Name = "sLOTDataGridViewTextBoxColumn";
            this.sLOTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIRSTVERIFDataGridViewTextBoxColumn
            // 
            this.fIRSTVERIFDataGridViewTextBoxColumn.DataPropertyName = "FIRST VERIF";
            this.fIRSTVERIFDataGridViewTextBoxColumn.HeaderText = "FIRST VERIF";
            this.fIRSTVERIFDataGridViewTextBoxColumn.Name = "fIRSTVERIFDataGridViewTextBoxColumn";
            this.fIRSTVERIFDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIRSTVERIFDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fIRSTVERIFDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fIRSTVERIFDataGridViewTextBoxColumn.ToolTipText = "hello";
            // 
            // dATEFIRSTDataGridViewTextBoxColumn
            // 
            this.dATEFIRSTDataGridViewTextBoxColumn.DataPropertyName = "DATE FIRST";
            this.dATEFIRSTDataGridViewTextBoxColumn.HeaderText = "DATE FIRST";
            this.dATEFIRSTDataGridViewTextBoxColumn.Name = "dATEFIRSTDataGridViewTextBoxColumn";
            this.dATEFIRSTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTVERIFIEDBYDataGridViewTextBoxColumn
            // 
            this.sTVERIFIEDBYDataGridViewTextBoxColumn.DataPropertyName = "1ST VERIFIED BY";
            this.sTVERIFIEDBYDataGridViewTextBoxColumn.HeaderText = "1ST VERIFIED BY";
            this.sTVERIFIEDBYDataGridViewTextBoxColumn.Name = "sTVERIFIEDBYDataGridViewTextBoxColumn";
            this.sTVERIFIEDBYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sECONDVERIFDataGridViewTextBoxColumn
            // 
            this.sECONDVERIFDataGridViewTextBoxColumn.DataPropertyName = "SECOND VERIF";
            this.sECONDVERIFDataGridViewTextBoxColumn.HeaderText = "SECOND VERIF";
            this.sECONDVERIFDataGridViewTextBoxColumn.Name = "sECONDVERIFDataGridViewTextBoxColumn";
            this.sECONDVERIFDataGridViewTextBoxColumn.ReadOnly = true;
            this.sECONDVERIFDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sECONDVERIFDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sECONDVERIFDataGridViewTextBoxColumn.ToolTipText = "hello";
            // 
            // dATESECONDDataGridViewTextBoxColumn
            // 
            this.dATESECONDDataGridViewTextBoxColumn.DataPropertyName = "DATE SECOND";
            this.dATESECONDDataGridViewTextBoxColumn.HeaderText = "DATE SECOND";
            this.dATESECONDDataGridViewTextBoxColumn.Name = "dATESECONDDataGridViewTextBoxColumn";
            this.dATESECONDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nDVERIFIEDBYDataGridViewTextBoxColumn
            // 
            this.nDVERIFIEDBYDataGridViewTextBoxColumn.DataPropertyName = "2ND VERIFIED BY";
            this.nDVERIFIEDBYDataGridViewTextBoxColumn.HeaderText = "2ND VERIFIED BY";
            this.nDVERIFIEDBYDataGridViewTextBoxColumn.Name = "nDVERIFIEDBYDataGridViewTextBoxColumn";
            this.nDVERIFIEDBYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            this.sTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEMARKSDataGridViewTextBoxColumn
            // 
            this.rEMARKSDataGridViewTextBoxColumn.DataPropertyName = "REMARKS";
            this.rEMARKSDataGridViewTextBoxColumn.HeaderText = "REMARKS";
            this.rEMARKSDataGridViewTextBoxColumn.Name = "rEMARKSDataGridViewTextBoxColumn";
            this.rEMARKSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boardDetailsBindingSource
            // 
            this.boardDetailsBindingSource.DataMember = "board details";
            this.boardDetailsBindingSource.DataSource = this.boards_for_verificationDataSet2;
            // 
            // boards_for_verificationDataSet2
            // 
            this.boards_for_verificationDataSet2.DataSetName = "boards_for_verificationDataSet2";
            this.boards_for_verificationDataSet2.EnforceConstraints = false;
            this.boards_for_verificationDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // board_detailsTableAdapter
            // 
            this.board_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // SEARCH_BOARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.boardDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boards_for_verificationDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private boards_for_verificationDataSet2 boards_for_verificationDataSet2;
        private System.Windows.Forms.BindingSource boardDetailsBindingSource;
        private boards_for_verificationDataSet2TableAdapters.board_detailsTableAdapter board_detailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sERIALNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARTNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOARDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tESTERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sITEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIETYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tESTOPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLOTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn fIRSTVERIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEFIRSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTVERIFIEDBYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn sECONDVERIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATESECONDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDVERIFIEDBYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEMARKSDataGridViewTextBoxColumn;
    }
}