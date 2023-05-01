namespace RCISystem.Views
{
    partial class frmCheckIssuedList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckIssuedList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCAccO = new System.Windows.Forms.Panel();
            this.btnGenerateAdvise = new System.Windows.Forms.Button();
            this.btnVerified = new System.Windows.Forms.Button();
            this.btnUnverified = new System.Windows.Forms.Button();
            this.pnlCTO = new System.Windows.Forms.Panel();
            this.btnNewCheckIssued = new System.Windows.Forms.Button();
            this.dgvCheckIssuedList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtVoucherNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCheckNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboView = new System.Windows.Forms.ComboBox();
            this.ColCheckIssuedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDATEENCODED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBANKCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBANKACCOUNTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCHECKID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCHECKNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHECKDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHECKPAYEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHECKAMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VOUCHERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VOUCHERDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VOUCHERAMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENCODEDBY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VERIFIEDBY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEVERIFIED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCAccO.SuspendLayout();
            this.pnlCTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIssuedList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 35);
            this.panel2.TabIndex = 22;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(807, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(49, 35);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.Text = "-";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.btnExit.Location = new System.Drawing.Point(856, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(905, 119);
            this.panel4.TabIndex = 25;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::RCISystem.Properties.Resources.listOfCheques;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(780, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 119);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "List of checked issued ...";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(144, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check and Voucher";
            // 
            // pnlCAccO
            // 
            this.pnlCAccO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCAccO.BackColor = System.Drawing.Color.Transparent;
            this.pnlCAccO.Controls.Add(this.btnGenerateAdvise);
            this.pnlCAccO.Controls.Add(this.btnVerified);
            this.pnlCAccO.Controls.Add(this.btnUnverified);
            this.pnlCAccO.Location = new System.Drawing.Point(154, 490);
            this.pnlCAccO.Name = "pnlCAccO";
            this.pnlCAccO.Size = new System.Drawing.Size(720, 59);
            this.pnlCAccO.TabIndex = 27;
            // 
            // btnGenerateAdvise
            // 
            this.btnGenerateAdvise.BackColor = System.Drawing.Color.Teal;
            this.btnGenerateAdvise.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGenerateAdvise.FlatAppearance.BorderSize = 0;
            this.btnGenerateAdvise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateAdvise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateAdvise.ForeColor = System.Drawing.Color.White;
            this.btnGenerateAdvise.Location = new System.Drawing.Point(524, 0);
            this.btnGenerateAdvise.Name = "btnGenerateAdvise";
            this.btnGenerateAdvise.Size = new System.Drawing.Size(196, 59);
            this.btnGenerateAdvise.TabIndex = 3;
            this.btnGenerateAdvise.Text = "ACCOUNTANT\'S ADVISE";
            this.btnGenerateAdvise.UseVisualStyleBackColor = false;
            this.btnGenerateAdvise.Click += new System.EventHandler(this.btnGenerateAdvise_Click);
            // 
            // btnVerified
            // 
            this.btnVerified.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerified.BackColor = System.Drawing.Color.SeaGreen;
            this.btnVerified.Enabled = false;
            this.btnVerified.FlatAppearance.BorderSize = 0;
            this.btnVerified.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerified.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerified.ForeColor = System.Drawing.Color.White;
            this.btnVerified.Location = new System.Drawing.Point(321, 0);
            this.btnVerified.Name = "btnVerified";
            this.btnVerified.Size = new System.Drawing.Size(196, 59);
            this.btnVerified.TabIndex = 1;
            this.btnVerified.Text = "VERIFY";
            this.btnVerified.UseVisualStyleBackColor = false;
            this.btnVerified.Click += new System.EventHandler(this.btnVerified_Click);
            // 
            // btnUnverified
            // 
            this.btnUnverified.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnverified.BackColor = System.Drawing.Color.Crimson;
            this.btnUnverified.Enabled = false;
            this.btnUnverified.FlatAppearance.BorderSize = 0;
            this.btnUnverified.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnverified.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnverified.ForeColor = System.Drawing.Color.White;
            this.btnUnverified.Location = new System.Drawing.Point(118, 0);
            this.btnUnverified.Name = "btnUnverified";
            this.btnUnverified.Size = new System.Drawing.Size(196, 59);
            this.btnUnverified.TabIndex = 2;
            this.btnUnverified.Text = "UNVERIFY";
            this.btnUnverified.UseVisualStyleBackColor = false;
            this.btnUnverified.Click += new System.EventHandler(this.btnUnverified_Click);
            // 
            // pnlCTO
            // 
            this.pnlCTO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCTO.BackColor = System.Drawing.Color.Transparent;
            this.pnlCTO.Controls.Add(this.btnNewCheckIssued);
            this.pnlCTO.Location = new System.Drawing.Point(588, 490);
            this.pnlCTO.Name = "pnlCTO";
            this.pnlCTO.Size = new System.Drawing.Size(286, 59);
            this.pnlCTO.TabIndex = 26;
            // 
            // btnNewCheckIssued
            // 
            this.btnNewCheckIssued.BackColor = System.Drawing.Color.Teal;
            this.btnNewCheckIssued.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewCheckIssued.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNewCheckIssued.FlatAppearance.BorderSize = 0;
            this.btnNewCheckIssued.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCheckIssued.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCheckIssued.ForeColor = System.Drawing.Color.White;
            this.btnNewCheckIssued.Location = new System.Drawing.Point(63, 0);
            this.btnNewCheckIssued.Name = "btnNewCheckIssued";
            this.btnNewCheckIssued.Size = new System.Drawing.Size(223, 59);
            this.btnNewCheckIssued.TabIndex = 0;
            this.btnNewCheckIssued.Text = "NEW CHECK ISSUED";
            this.btnNewCheckIssued.UseVisualStyleBackColor = false;
            this.btnNewCheckIssued.Click += new System.EventHandler(this.btnNewCheckIssued_Click);
            // 
            // dgvCheckIssuedList
            // 
            this.dgvCheckIssuedList.AllowUserToAddRows = false;
            this.dgvCheckIssuedList.AllowUserToDeleteRows = false;
            this.dgvCheckIssuedList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckIssuedList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheckIssuedList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCheckIssuedList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheckIssuedList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckIssuedList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheckIssuedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckIssuedList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCheckIssuedID,
            this.ColStatus,
            this.ColDATEENCODED,
            this.ColBANKCODE,
            this.ColBANKACCOUNTNO,
            this.Column1,
            this.colCHECKID,
            this.colCHECKNO,
            this.CHECKDATE,
            this.CHECKPAYEE,
            this.CHECKAMOUNT,
            this.VOUCHERNO,
            this.VOUCHERDATE,
            this.VOUCHERAMOUNT,
            this.ENCODEDBY,
            this.VERIFIEDBY,
            this.DATEVERIFIED,
            this.AdviceID});
            this.dgvCheckIssuedList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckIssuedList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCheckIssuedList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCheckIssuedList.GridColor = System.Drawing.Color.Teal;
            this.dgvCheckIssuedList.Location = new System.Drawing.Point(30, 250);
            this.dgvCheckIssuedList.MultiSelect = false;
            this.dgvCheckIssuedList.Name = "dgvCheckIssuedList";
            this.dgvCheckIssuedList.ReadOnly = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCheckIssuedList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCheckIssuedList.RowHeadersVisible = false;
            this.dgvCheckIssuedList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckIssuedList.Size = new System.Drawing.Size(844, 225);
            this.dgvCheckIssuedList.TabIndex = 28;
            this.dgvCheckIssuedList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckIssuedList_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtVoucherNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCheckNumber);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 78);
            this.panel1.TabIndex = 43;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(780, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 27);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtVoucherNumber
            // 
            this.txtVoucherNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucherNumber.Location = new System.Drawing.Point(540, 42);
            this.txtVoucherNumber.Name = "txtVoucherNumber";
            this.txtVoucherNumber.Size = new System.Drawing.Size(229, 26);
            this.txtVoucherNumber.TabIndex = 48;
            this.txtVoucherNumber.TextChanged += new System.EventHandler(this.txtVoucherNumber_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(537, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Voucher Number";
            // 
            // txtCheckNumber
            // 
            this.txtCheckNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckNumber.Location = new System.Drawing.Point(272, 43);
            this.txtCheckNumber.Name = "txtCheckNumber";
            this.txtCheckNumber.Size = new System.Drawing.Size(229, 26);
            this.txtCheckNumber.TabIndex = 46;
            this.txtCheckNumber.TextChanged += new System.EventHandler(this.txtCheckNumber_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(269, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 45;
            this.label4.Text = "Check Number:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(27, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Status:";
            // 
            // cboView
            // 
            this.cboView.BackColor = System.Drawing.Color.Teal;
            this.cboView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboView.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboView.ForeColor = System.Drawing.Color.White;
            this.cboView.FormattingEnabled = true;
            this.cboView.Location = new System.Drawing.Point(30, 42);
            this.cboView.Name = "cboView";
            this.cboView.Size = new System.Drawing.Size(196, 26);
            this.cboView.TabIndex = 43;
            this.cboView.SelectedIndexChanged += new System.EventHandler(this.cboView_SelectedIndexChanged);
            // 
            // ColCheckIssuedID
            // 
            this.ColCheckIssuedID.HeaderText = "CheckIssuedID";
            this.ColCheckIssuedID.Name = "ColCheckIssuedID";
            this.ColCheckIssuedID.ReadOnly = true;
            this.ColCheckIssuedID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCheckIssuedID.Visible = false;
            // 
            // ColStatus
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.ColStatus.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColStatus.HeaderText = "STATUS";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            this.ColStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColDATEENCODED
            // 
            this.ColDATEENCODED.HeaderText = "DATE ENCODED";
            this.ColDATEENCODED.Name = "ColDATEENCODED";
            this.ColDATEENCODED.ReadOnly = true;
            this.ColDATEENCODED.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColBANKCODE
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ColBANKCODE.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColBANKCODE.HeaderText = "BANK CODE";
            this.ColBANKCODE.Name = "ColBANKCODE";
            this.ColBANKCODE.ReadOnly = true;
            this.ColBANKCODE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColBANKACCOUNTNO
            // 
            this.ColBANKACCOUNTNO.HeaderText = "BANK ACCOUNT NO";
            this.ColBANKACCOUNTNO.Name = "ColBANKACCOUNTNO";
            this.ColBANKACCOUNTNO.ReadOnly = true;
            this.ColBANKACCOUNTNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "BANK ACCOUNT DESCRIPTION";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCHECKID
            // 
            this.colCHECKID.HeaderText = "CHECK ID";
            this.colCHECKID.Name = "colCHECKID";
            this.colCHECKID.ReadOnly = true;
            this.colCHECKID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCHECKID.Visible = false;
            // 
            // colCHECKNO
            // 
            this.colCHECKNO.HeaderText = "CHECK NO";
            this.colCHECKNO.Name = "colCHECKNO";
            this.colCHECKNO.ReadOnly = true;
            this.colCHECKNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CHECKDATE
            // 
            this.CHECKDATE.HeaderText = "CHECK DATE";
            this.CHECKDATE.Name = "CHECKDATE";
            this.CHECKDATE.ReadOnly = true;
            this.CHECKDATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CHECKPAYEE
            // 
            this.CHECKPAYEE.HeaderText = "CHECK PAYEE";
            this.CHECKPAYEE.Name = "CHECKPAYEE";
            this.CHECKPAYEE.ReadOnly = true;
            this.CHECKPAYEE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CHECKAMOUNT
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CHECKAMOUNT.DefaultCellStyle = dataGridViewCellStyle5;
            this.CHECKAMOUNT.HeaderText = "CHECK AMOUNT";
            this.CHECKAMOUNT.Name = "CHECKAMOUNT";
            this.CHECKAMOUNT.ReadOnly = true;
            this.CHECKAMOUNT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VOUCHERNO
            // 
            this.VOUCHERNO.HeaderText = "VOUCHER NO";
            this.VOUCHERNO.Name = "VOUCHERNO";
            this.VOUCHERNO.ReadOnly = true;
            this.VOUCHERNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VOUCHERDATE
            // 
            this.VOUCHERDATE.HeaderText = "VOUCHER DATE";
            this.VOUCHERDATE.Name = "VOUCHERDATE";
            this.VOUCHERDATE.ReadOnly = true;
            this.VOUCHERDATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VOUCHERAMOUNT
            // 
            this.VOUCHERAMOUNT.HeaderText = "VOUCHER AMOUNT";
            this.VOUCHERAMOUNT.Name = "VOUCHERAMOUNT";
            this.VOUCHERAMOUNT.ReadOnly = true;
            this.VOUCHERAMOUNT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ENCODEDBY
            // 
            this.ENCODEDBY.HeaderText = "ENCODED BY";
            this.ENCODEDBY.Name = "ENCODEDBY";
            this.ENCODEDBY.ReadOnly = true;
            this.ENCODEDBY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VERIFIEDBY
            // 
            this.VERIFIEDBY.HeaderText = "VERIFIED BY";
            this.VERIFIEDBY.Name = "VERIFIEDBY";
            this.VERIFIEDBY.ReadOnly = true;
            this.VERIFIEDBY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DATEVERIFIED
            // 
            this.DATEVERIFIED.HeaderText = "DATE VERIFIED";
            this.DATEVERIFIED.Name = "DATEVERIFIED";
            this.DATEVERIFIED.ReadOnly = true;
            this.DATEVERIFIED.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AdviceID
            // 
            this.AdviceID.HeaderText = "AdviceID";
            this.AdviceID.Name = "AdviceID";
            this.AdviceID.ReadOnly = true;
            this.AdviceID.Visible = false;
            // 
            // frmCheckIssuedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(905, 571);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCheckIssuedList);
            this.Controls.Add(this.pnlCTO);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlCAccO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCheckIssuedList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCheckIssuedList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCheckIssuedList_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCAccO.ResumeLayout(false);
            this.pnlCTO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIssuedList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCAccO;
        private System.Windows.Forms.Button btnGenerateAdvise;
        private System.Windows.Forms.Button btnVerified;
        private System.Windows.Forms.Button btnUnverified;
        private System.Windows.Forms.Panel pnlCTO;
        private System.Windows.Forms.Button btnNewCheckIssued;
        private System.Windows.Forms.DataGridView dgvCheckIssuedList;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVoucherNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCheckNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCheckIssuedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDATEENCODED;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBANKCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBANKACCOUNTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCHECKID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCHECKNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHECKDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHECKPAYEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHECKAMOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn VOUCHERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VOUCHERDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VOUCHERAMOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENCODEDBY;
        private System.Windows.Forms.DataGridViewTextBoxColumn VERIFIEDBY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEVERIFIED;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdviceID;
    }
}