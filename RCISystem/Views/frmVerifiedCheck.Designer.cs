namespace RCISystem.Views
{
    partial class frmVerifiedCheck
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtVoucherNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCheckNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboView = new System.Windows.Forms.ComboBox();
            this.btnPrintAdvice = new System.Windows.Forms.Button();
            this.dgvCheckIssuedList = new System.Windows.Forms.DataGridView();
            this.ColSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCheckIssuedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountantsAdviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateVerified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankAcountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankAccountDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckPayee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucherDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucherAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEncodeBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateEncoded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVerifiedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankAcountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSignatory = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGenerateAdvised = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIssuedList)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnPrintAdvice);
            this.panel1.Controls.Add(this.dgvCheckIssuedList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboSignatory);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnGenerateAdvised);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 507);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtVoucherNumber);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCheckNumber);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cboView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 78);
            this.panel2.TabIndex = 42;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(829, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 27);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtVoucherNumber
            // 
            this.txtVoucherNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucherNumber.Location = new System.Drawing.Point(593, 37);
            this.txtVoucherNumber.Name = "txtVoucherNumber";
            this.txtVoucherNumber.Size = new System.Drawing.Size(229, 26);
            this.txtVoucherNumber.TabIndex = 53;
            this.txtVoucherNumber.TextChanged += new System.EventHandler(this.txtVoucherNumber_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(592, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "Voucher Number";
            // 
            // txtCheckNumber
            // 
            this.txtCheckNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckNumber.Location = new System.Drawing.Point(343, 37);
            this.txtCheckNumber.Name = "txtCheckNumber";
            this.txtCheckNumber.Size = new System.Drawing.Size(229, 26);
            this.txtCheckNumber.TabIndex = 51;
            this.txtCheckNumber.TextChanged += new System.EventHandler(this.txtCheckNumber_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(339, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = "Check Number:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(26, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Status:";
            // 
            // cboView
            // 
            this.cboView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboView.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboView.FormattingEnabled = true;
            this.cboView.Location = new System.Drawing.Point(29, 37);
            this.cboView.Name = "cboView";
            this.cboView.Size = new System.Drawing.Size(296, 26);
            this.cboView.TabIndex = 41;
            this.cboView.SelectedIndexChanged += new System.EventHandler(this.cboView_SelectedIndexChanged);
            // 
            // btnPrintAdvice
            // 
            this.btnPrintAdvice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintAdvice.BackColor = System.Drawing.Color.Teal;
            this.btnPrintAdvice.FlatAppearance.BorderSize = 0;
            this.btnPrintAdvice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintAdvice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAdvice.ForeColor = System.Drawing.Color.White;
            this.btnPrintAdvice.Location = new System.Drawing.Point(503, 446);
            this.btnPrintAdvice.Name = "btnPrintAdvice";
            this.btnPrintAdvice.Size = new System.Drawing.Size(207, 45);
            this.btnPrintAdvice.TabIndex = 41;
            this.btnPrintAdvice.Text = "PRINT ADVICE";
            this.btnPrintAdvice.UseVisualStyleBackColor = false;
            this.btnPrintAdvice.Click += new System.EventHandler(this.btnPrintAdvice_Click);
            // 
            // dgvCheckIssuedList
            // 
            this.dgvCheckIssuedList.AllowUserToAddRows = false;
            this.dgvCheckIssuedList.AllowUserToDeleteRows = false;
            this.dgvCheckIssuedList.AllowUserToResizeColumns = false;
            this.dgvCheckIssuedList.AllowUserToResizeRows = false;
            this.dgvCheckIssuedList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCheckIssuedList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckIssuedList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheckIssuedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckIssuedList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSelect,
            this.colCheckIssuedID,
            this.colStatus,
            this.AccountantsAdviceID,
            this.colDateVerified,
            this.colBankCode,
            this.colBankAcountNumber,
            this.colBankAccountDescription,
            this.colCheckID,
            this.colCheckNo,
            this.colCheckDate,
            this.colCheckPayee,
            this.colCheckAmount,
            this.colVoucherNo,
            this.colVoucherDate,
            this.colVoucherAmount,
            this.colEncodeBy,
            this.colDateEncoded,
            this.colVerifiedBy,
            this.colBankAcountID,
            this.colVoucherID});
            this.dgvCheckIssuedList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheckIssuedList.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCheckIssuedList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCheckIssuedList.Location = new System.Drawing.Point(29, 184);
            this.dgvCheckIssuedList.MultiSelect = false;
            this.dgvCheckIssuedList.Name = "dgvCheckIssuedList";
            this.dgvCheckIssuedList.ReadOnly = true;
            this.dgvCheckIssuedList.RowHeadersVisible = false;
            this.dgvCheckIssuedList.RowHeadersWidth = 4;
            this.dgvCheckIssuedList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckIssuedList.Size = new System.Drawing.Size(894, 178);
            this.dgvCheckIssuedList.TabIndex = 38;
            this.dgvCheckIssuedList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckIssuedList_CellClick);
            // 
            // ColSelect
            // 
            this.ColSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = false;
            this.ColSelect.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColSelect.Frozen = true;
            this.ColSelect.HeaderText = "SELECT";
            this.ColSelect.Name = "ColSelect";
            this.ColSelect.ReadOnly = true;
            this.ColSelect.Width = 60;
            // 
            // colCheckIssuedID
            // 
            this.colCheckIssuedID.HeaderText = "CHECK ISSUED ID";
            this.colCheckIssuedID.Name = "colCheckIssuedID";
            this.colCheckIssuedID.ReadOnly = true;
            this.colCheckIssuedID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCheckIssuedID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCheckIssuedID.Visible = false;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStatus.HeaderText = "STATUS";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colStatus.Width = 62;
            // 
            // AccountantsAdviceID
            // 
            this.AccountantsAdviceID.HeaderText = "ADVICE ID";
            this.AccountantsAdviceID.Name = "AccountantsAdviceID";
            this.AccountantsAdviceID.ReadOnly = true;
            this.AccountantsAdviceID.Visible = false;
            // 
            // colDateVerified
            // 
            this.colDateVerified.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDateVerified.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDateVerified.HeaderText = "DATE VERIFIED";
            this.colDateVerified.Name = "colDateVerified";
            this.colDateVerified.ReadOnly = true;
            this.colDateVerified.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDateVerified.Width = 96;
            // 
            // colBankCode
            // 
            this.colBankCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBankCode.HeaderText = "BANK CODE";
            this.colBankCode.Name = "colBankCode";
            this.colBankCode.ReadOnly = true;
            this.colBankCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colBankCode.Width = 76;
            // 
            // colBankAcountNumber
            // 
            this.colBankAcountNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colBankAcountNumber.DefaultCellStyle = dataGridViewCellStyle4;
            this.colBankAcountNumber.HeaderText = "BANK ACCOUNT NO";
            this.colBankAcountNumber.Name = "colBankAcountNumber";
            this.colBankAcountNumber.ReadOnly = true;
            this.colBankAcountNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colBankAcountNumber.Width = 102;
            // 
            // colBankAccountDescription
            // 
            this.colBankAccountDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colBankAccountDescription.DefaultCellStyle = dataGridViewCellStyle5;
            this.colBankAccountDescription.HeaderText = "BANK ACCOUNT DESCRIPTION";
            this.colBankAccountDescription.Name = "colBankAccountDescription";
            this.colBankAccountDescription.ReadOnly = true;
            this.colBankAccountDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colBankAccountDescription.Width = 177;
            // 
            // colCheckID
            // 
            this.colCheckID.HeaderText = "CHECK ID";
            this.colCheckID.Name = "colCheckID";
            this.colCheckID.ReadOnly = true;
            this.colCheckID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCheckID.Visible = false;
            // 
            // colCheckNo
            // 
            this.colCheckNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCheckNo.DefaultCellStyle = dataGridViewCellStyle6;
            this.colCheckNo.HeaderText = "CHECK NO";
            this.colCheckNo.Name = "colCheckNo";
            this.colCheckNo.ReadOnly = true;
            this.colCheckNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCheckNo.Width = 68;
            // 
            // colCheckDate
            // 
            this.colCheckDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCheckDate.DefaultCellStyle = dataGridViewCellStyle7;
            this.colCheckDate.HeaderText = "CHECK DATE";
            this.colCheckDate.Name = "colCheckDate";
            this.colCheckDate.ReadOnly = true;
            this.colCheckDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCheckDate.Width = 82;
            // 
            // colCheckPayee
            // 
            this.colCheckPayee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCheckPayee.HeaderText = "CHECK PAYEE";
            this.colCheckPayee.Name = "colCheckPayee";
            this.colCheckPayee.ReadOnly = true;
            this.colCheckPayee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCheckPayee.Width = 88;
            // 
            // colCheckAmount
            // 
            this.colCheckAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colCheckAmount.DefaultCellStyle = dataGridViewCellStyle8;
            this.colCheckAmount.HeaderText = "CHECK AMOUNT";
            this.colCheckAmount.Name = "colCheckAmount";
            this.colCheckAmount.ReadOnly = true;
            this.colCheckAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colVoucherNo
            // 
            this.colVoucherNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colVoucherNo.DefaultCellStyle = dataGridViewCellStyle9;
            this.colVoucherNo.HeaderText = "VOUCHER NO";
            this.colVoucherNo.Name = "colVoucherNo";
            this.colVoucherNo.ReadOnly = true;
            this.colVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colVoucherNo.Width = 86;
            // 
            // colVoucherDate
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colVoucherDate.DefaultCellStyle = dataGridViewCellStyle10;
            this.colVoucherDate.HeaderText = "VOUCHER DATE";
            this.colVoucherDate.Name = "colVoucherDate";
            this.colVoucherDate.ReadOnly = true;
            this.colVoucherDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colVoucherDate.Visible = false;
            // 
            // colVoucherAmount
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colVoucherAmount.DefaultCellStyle = dataGridViewCellStyle11;
            this.colVoucherAmount.HeaderText = "VOUCHER AMOUNT";
            this.colVoucherAmount.Name = "colVoucherAmount";
            this.colVoucherAmount.ReadOnly = true;
            this.colVoucherAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colVoucherAmount.Visible = false;
            // 
            // colEncodeBy
            // 
            this.colEncodeBy.HeaderText = "ENCODED BY";
            this.colEncodeBy.Name = "colEncodeBy";
            this.colEncodeBy.ReadOnly = true;
            this.colEncodeBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colEncodeBy.Visible = false;
            // 
            // colDateEncoded
            // 
            this.colDateEncoded.HeaderText = "DATE ENCODE";
            this.colDateEncoded.Name = "colDateEncoded";
            this.colDateEncoded.ReadOnly = true;
            this.colDateEncoded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDateEncoded.Visible = false;
            // 
            // colVerifiedBy
            // 
            this.colVerifiedBy.HeaderText = "VERIFIED BY";
            this.colVerifiedBy.Name = "colVerifiedBy";
            this.colVerifiedBy.ReadOnly = true;
            this.colVerifiedBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colVerifiedBy.Visible = false;
            // 
            // colBankAcountID
            // 
            this.colBankAcountID.HeaderText = "BANK ACCOUNT id";
            this.colBankAcountID.Name = "colBankAcountID";
            this.colBankAcountID.ReadOnly = true;
            this.colBankAcountID.Visible = false;
            // 
            // colVoucherID
            // 
            this.colVoucherID.HeaderText = "VOUCHER ID";
            this.colVoucherID.Name = "colVoucherID";
            this.colVoucherID.ReadOnly = true;
            this.colVoucherID.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(619, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "City Accountant/Representative";
            // 
            // cboSignatory
            // 
            this.cboSignatory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSignatory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSignatory.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSignatory.FormattingEnabled = true;
            this.cboSignatory.Location = new System.Drawing.Point(622, 397);
            this.cboSignatory.Name = "cboSignatory";
            this.cboSignatory.Size = new System.Drawing.Size(301, 26);
            this.cboSignatory.TabIndex = 36;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(955, 65);
            this.panel4.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::RCISystem.Properties.Resources.verifiedchekcs;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(854, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 65);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(23, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(656, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Generating Accountant\'s Advice on Check Issued";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(955, 35);
            this.panel3.TabIndex = 34;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(906, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGenerateAdvised
            // 
            this.btnGenerateAdvised.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateAdvised.BackColor = System.Drawing.Color.Teal;
            this.btnGenerateAdvised.FlatAppearance.BorderSize = 0;
            this.btnGenerateAdvised.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateAdvised.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateAdvised.ForeColor = System.Drawing.Color.White;
            this.btnGenerateAdvised.Location = new System.Drawing.Point(716, 445);
            this.btnGenerateAdvised.Name = "btnGenerateAdvised";
            this.btnGenerateAdvised.Size = new System.Drawing.Size(207, 45);
            this.btnGenerateAdvised.TabIndex = 4;
            this.btnGenerateAdvised.Text = "GENERATE ADVICE";
            this.btnGenerateAdvised.UseVisualStyleBackColor = false;
            this.btnGenerateAdvised.Click += new System.EventHandler(this.btnGenerateAdvised_Click);
            // 
            // frmVerifiedCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(965, 512);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerifiedCheck";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVerifiedCheck_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIssuedList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGenerateAdvised;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSignatory;
        private System.Windows.Forms.DataGridView dgvCheckIssuedList;
        private System.Windows.Forms.Button btnPrintAdvice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckIssuedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountantsAdviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateVerified;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankAcountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankAccountDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckPayee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucherDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucherAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEncodeBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateEncoded;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVerifiedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankAcountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucherID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtVoucherNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCheckNumber;
        private System.Windows.Forms.Label label4;
    }
}