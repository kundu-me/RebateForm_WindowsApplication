namespace Asg2_nxk161830
{
    partial class frmRebate
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
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxMiddleInitial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtBxAddressLine2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxState = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioBtnGenderMale = new System.Windows.Forms.RadioButton();
            this.radioBtnGenderFemale = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.radioBtnProofNo = new System.Windows.Forms.RadioButton();
            this.radioBtnProofYes = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnSaveExit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.groupBoxProofPurchase = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.maskedTxtBxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBxDate = new System.Windows.Forms.MaskedTextBox();
            this.txtBxTimeStarted = new System.Windows.Forms.TextBox();
            this.txtBxTimeSaved = new System.Windows.Forms.TextBox();
            this.txtBxCountBackSpaceKey = new System.Windows.Forms.TextBox();
            this.txtBxEditUniqueId = new System.Windows.Forms.TextBox();
            this.maskedTxtBxZipCode = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxError = new System.Windows.Forms.GroupBox();
            this.labelErrorHeader = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelInsLeft = new System.Windows.Forms.Label();
            this.labelInsRight = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelInsMiddle = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxProofPurchase.SuspendLayout();
            this.groupBoxError.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.AllowUserToDeleteRows = false;
            this.dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFullName,
            this.colPhoneNumber});
            this.dataGridViewCustomer.Location = new System.Drawing.Point(21, 21);
            this.dataGridViewCustomer.MultiSelect = false;
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.ReadOnly = true;
            this.dataGridViewCustomer.RowHeadersWidth = 60;
            this.dataGridViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomer.ShowEditingIcon = false;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(279, 544);
            this.dataGridViewCustomer.TabIndex = 100;
            this.dataGridViewCustomer.TabStop = false;
            this.dataGridViewCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewCustomerData);
            this.dataGridViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewCustomerData);
            this.dataGridViewCustomer.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewCustomerData);
            this.dataGridViewCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewCustomerData);
            this.dataGridViewCustomer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.viewCustomerData);
            this.dataGridViewCustomer.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.viewCustomerData);
            this.dataGridViewCustomer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.viewCustomerData);
            // 
            // colFullName
            // 
            this.colFullName.HeaderText = "Full Name";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.HeaderText = "Phone Number";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.ReadOnly = true;
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(481, 30);
            this.txtBxFirstName.MaxLength = 40;
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(172, 20);
            this.txtBxFirstName.TabIndex = 1;
            this.txtBxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startFormFillUp);
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(481, 67);
            this.txtBxLastName.MaxLength = 40;
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(172, 20);
            this.txtBxLastName.TabIndex = 2;
            this.txtBxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startFormFillUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Last Name*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Middle Initial";
            // 
            // txtBxMiddleInitial
            // 
            this.txtBxMiddleInitial.Location = new System.Drawing.Point(481, 106);
            this.txtBxMiddleInitial.MaxLength = 1;
            this.txtBxMiddleInitial.Name = "txtBxMiddleInitial";
            this.txtBxMiddleInitial.Size = new System.Drawing.Size(34, 20);
            this.txtBxMiddleInitial.TabIndex = 3;
            this.txtBxMiddleInitial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startFormFillUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Address Line 1*";
            // 
            // txtBxAddressLine1
            // 
            this.txtBxAddressLine1.Location = new System.Drawing.Point(481, 149);
            this.txtBxAddressLine1.MaxLength = 100;
            this.txtBxAddressLine1.Name = "txtBxAddressLine1";
            this.txtBxAddressLine1.Size = new System.Drawing.Size(336, 20);
            this.txtBxAddressLine1.TabIndex = 4;
            this.txtBxAddressLine1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startFormFillUp);
            // 
            // txtBxAddressLine2
            // 
            this.txtBxAddressLine2.Location = new System.Drawing.Point(481, 191);
            this.txtBxAddressLine2.MaxLength = 100;
            this.txtBxAddressLine2.Name = "txtBxAddressLine2";
            this.txtBxAddressLine2.Size = new System.Drawing.Size(336, 20);
            this.txtBxAddressLine2.TabIndex = 5;
            this.txtBxAddressLine2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startFormFillUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Address Line 2";
            // 
            // txtBxCity
            // 
            this.txtBxCity.Location = new System.Drawing.Point(481, 237);
            this.txtBxCity.MaxLength = 50;
            this.txtBxCity.Name = "txtBxCity";
            this.txtBxCity.Size = new System.Drawing.Size(128, 20);
            this.txtBxCity.TabIndex = 6;
            this.txtBxCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startFormFillUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "City*";
            // 
            // txtBxState
            // 
            this.txtBxState.Location = new System.Drawing.Point(481, 276);
            this.txtBxState.MaxLength = 50;
            this.txtBxState.Name = "txtBxState";
            this.txtBxState.Size = new System.Drawing.Size(128, 20);
            this.txtBxState.TabIndex = 7;
            this.txtBxState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startFormFillUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(326, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "State*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 57;
            this.label8.Text = "Zip Code*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 58;
            this.label9.Text = "Gender*";
            // 
            // radioBtnGenderMale
            // 
            this.radioBtnGenderMale.AutoSize = true;
            this.radioBtnGenderMale.Location = new System.Drawing.Point(6, 12);
            this.radioBtnGenderMale.Name = "radioBtnGenderMale";
            this.radioBtnGenderMale.Size = new System.Drawing.Size(48, 17);
            this.radioBtnGenderMale.TabIndex = 9;
            this.radioBtnGenderMale.TabStop = true;
            this.radioBtnGenderMale.Text = "Male";
            this.radioBtnGenderMale.UseVisualStyleBackColor = true;
            // 
            // radioBtnGenderFemale
            // 
            this.radioBtnGenderFemale.AutoSize = true;
            this.radioBtnGenderFemale.Location = new System.Drawing.Point(66, 12);
            this.radioBtnGenderFemale.Name = "radioBtnGenderFemale";
            this.radioBtnGenderFemale.Size = new System.Drawing.Size(59, 17);
            this.radioBtnGenderFemale.TabIndex = 9;
            this.radioBtnGenderFemale.TabStop = true;
            this.radioBtnGenderFemale.Text = "Female";
            this.radioBtnGenderFemale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(326, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 17);
            this.label10.TabIndex = 59;
            this.label10.Text = "Phone Number*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(326, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 17);
            this.label11.TabIndex = 60;
            this.label11.Text = "E-mail Address*";
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(481, 421);
            this.txtBxEmail.MaxLength = 50;
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(251, 20);
            this.txtBxEmail.TabIndex = 12;
            this.txtBxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startFormFillUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(326, 495);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 17);
            this.label12.TabIndex = 62;
            this.label12.Text = "Date received*";
            // 
            // radioBtnProofNo
            // 
            this.radioBtnProofNo.AutoSize = true;
            this.radioBtnProofNo.Location = new System.Drawing.Point(63, 10);
            this.radioBtnProofNo.Name = "radioBtnProofNo";
            this.radioBtnProofNo.Size = new System.Drawing.Size(39, 17);
            this.radioBtnProofNo.TabIndex = 14;
            this.radioBtnProofNo.TabStop = true;
            this.radioBtnProofNo.Text = "No";
            this.radioBtnProofNo.UseVisualStyleBackColor = true;
            // 
            // radioBtnProofYes
            // 
            this.radioBtnProofYes.AutoSize = true;
            this.radioBtnProofYes.Location = new System.Drawing.Point(6, 10);
            this.radioBtnProofYes.Name = "radioBtnProofYes";
            this.radioBtnProofYes.Size = new System.Drawing.Size(43, 17);
            this.radioBtnProofYes.TabIndex = 14;
            this.radioBtnProofYes.TabStop = true;
            this.radioBtnProofYes.Text = "Yes";
            this.radioBtnProofYes.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(326, 457);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(212, 17);
            this.label13.TabIndex = 61;
            this.label13.Text = "Proof of purchase attached*";
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(329, 527);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(106, 23);
            this.btnSaveNew.TabIndex = 16;
            this.btnSaveNew.Text = "Save && New";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.Location = new System.Drawing.Point(441, 527);
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(106, 23);
            this.btnSaveExit.TabIndex = 17;
            this.btnSaveExit.Text = "Save && Exit";
            this.btnSaveExit.UseVisualStyleBackColor = true;
            this.btnSaveExit.Click += new System.EventHandler(this.btnSaveExit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(738, 527);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 23);
            this.btnNew.TabIndex = 20;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(644, 527);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioBtnGenderMale);
            this.groupBoxGender.Controls.Add(this.radioBtnGenderFemale);
            this.groupBoxGender.Location = new System.Drawing.Point(481, 341);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(128, 39);
            this.groupBoxGender.TabIndex = 9;
            this.groupBoxGender.TabStop = false;
            // 
            // groupBoxProofPurchase
            // 
            this.groupBoxProofPurchase.Controls.Add(this.radioBtnProofYes);
            this.groupBoxProofPurchase.Controls.Add(this.radioBtnProofNo);
            this.groupBoxProofPurchase.Location = new System.Drawing.Point(541, 449);
            this.groupBoxProofPurchase.Name = "groupBoxProofPurchase";
            this.groupBoxProofPurchase.Size = new System.Drawing.Size(112, 32);
            this.groupBoxProofPurchase.TabIndex = 14;
            this.groupBoxProofPurchase.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(555, 527);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 23);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // maskedTxtBxPhoneNumber
            // 
            this.maskedTxtBxPhoneNumber.Location = new System.Drawing.Point(481, 386);
            this.maskedTxtBxPhoneNumber.Mask = "(999) 000-0000";
            this.maskedTxtBxPhoneNumber.Name = "maskedTxtBxPhoneNumber";
            this.maskedTxtBxPhoneNumber.Size = new System.Drawing.Size(128, 20);
            this.maskedTxtBxPhoneNumber.TabIndex = 11;
            this.maskedTxtBxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startFormFillUp);
            // 
            // maskedTxtBxDate
            // 
            this.maskedTxtBxDate.Location = new System.Drawing.Point(481, 495);
            this.maskedTxtBxDate.Mask = "00/00/0000";
            this.maskedTxtBxDate.Name = "maskedTxtBxDate";
            this.maskedTxtBxDate.Size = new System.Drawing.Size(128, 20);
            this.maskedTxtBxDate.TabIndex = 15;
            this.maskedTxtBxDate.ValidatingType = typeof(System.DateTime);
            this.maskedTxtBxDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startFormFillUp);
            // 
            // txtBxTimeStarted
            // 
            this.txtBxTimeStarted.Location = new System.Drawing.Point(791, 501);
            this.txtBxTimeStarted.Name = "txtBxTimeStarted";
            this.txtBxTimeStarted.Size = new System.Drawing.Size(14, 20);
            this.txtBxTimeStarted.TabIndex = 40;
            this.txtBxTimeStarted.Visible = false;
            // 
            // txtBxTimeSaved
            // 
            this.txtBxTimeSaved.Location = new System.Drawing.Point(811, 501);
            this.txtBxTimeSaved.Name = "txtBxTimeSaved";
            this.txtBxTimeSaved.Size = new System.Drawing.Size(14, 20);
            this.txtBxTimeSaved.TabIndex = 41;
            this.txtBxTimeSaved.Visible = false;
            // 
            // txtBxCountBackSpaceKey
            // 
            this.txtBxCountBackSpaceKey.Location = new System.Drawing.Point(769, 501);
            this.txtBxCountBackSpaceKey.Name = "txtBxCountBackSpaceKey";
            this.txtBxCountBackSpaceKey.Size = new System.Drawing.Size(16, 20);
            this.txtBxCountBackSpaceKey.TabIndex = 42;
            this.txtBxCountBackSpaceKey.Visible = false;
            // 
            // txtBxEditUniqueId
            // 
            this.txtBxEditUniqueId.Location = new System.Drawing.Point(747, 501);
            this.txtBxEditUniqueId.Name = "txtBxEditUniqueId";
            this.txtBxEditUniqueId.Size = new System.Drawing.Size(16, 20);
            this.txtBxEditUniqueId.TabIndex = 43;
            this.txtBxEditUniqueId.Visible = false;
            // 
            // maskedTxtBxZipCode
            // 
            this.maskedTxtBxZipCode.Location = new System.Drawing.Point(481, 315);
            this.maskedTxtBxZipCode.Mask = "00000";
            this.maskedTxtBxZipCode.Name = "maskedTxtBxZipCode";
            this.maskedTxtBxZipCode.Size = new System.Drawing.Size(128, 20);
            this.maskedTxtBxZipCode.TabIndex = 8;
            // 
            // groupBoxError
            // 
            this.groupBoxError.Controls.Add(this.label14);
            this.groupBoxError.Controls.Add(this.labelErrorHeader);
            this.groupBoxError.Location = new System.Drawing.Point(313, 218);
            this.groupBoxError.Name = "groupBoxError";
            this.groupBoxError.Size = new System.Drawing.Size(188, 175);
            this.groupBoxError.TabIndex = 45;
            this.groupBoxError.TabStop = false;
            // 
            // labelErrorHeader
            // 
            this.labelErrorHeader.AutoSize = true;
            this.labelErrorHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorHeader.ForeColor = System.Drawing.Color.Red;
            this.labelErrorHeader.Location = new System.Drawing.Point(12, 46);
            this.labelErrorHeader.MaximumSize = new System.Drawing.Size(0, 500);
            this.labelErrorHeader.Name = "labelErrorHeader";
            this.labelErrorHeader.Size = new System.Drawing.Size(45, 17);
            this.labelErrorHeader.TabIndex = 46;
            this.labelErrorHeader.Text = "Error";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxError);
            this.groupBox1.Location = new System.Drawing.Point(316, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 552);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "First Name*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelInsLeft);
            this.groupBox2.Location = new System.Drawing.Point(21, 571);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 83);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelInsRight);
            this.groupBox3.Location = new System.Drawing.Point(547, 571);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 83);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            // 
            // labelInsLeft
            // 
            this.labelInsLeft.AutoSize = true;
            this.labelInsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInsLeft.Location = new System.Drawing.Point(6, 18);
            this.labelInsLeft.Name = "labelInsLeft";
            this.labelInsLeft.Size = new System.Drawing.Size(76, 16);
            this.labelInsLeft.TabIndex = 0;
            this.labelInsLeft.Text = "labelInsLeft";
            // 
            // labelInsRight
            // 
            this.labelInsRight.AutoSize = true;
            this.labelInsRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInsRight.Location = new System.Drawing.Point(6, 18);
            this.labelInsRight.Name = "labelInsRight";
            this.labelInsRight.Size = new System.Drawing.Size(86, 16);
            this.labelInsRight.TabIndex = 1;
            this.labelInsRight.Text = "labelInsRight";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelInsMiddle);
            this.groupBox4.Location = new System.Drawing.Point(316, 571);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 83);
            this.groupBox4.TabIndex = 65;
            this.groupBox4.TabStop = false;
            // 
            // labelInsMiddle
            // 
            this.labelInsMiddle.AutoSize = true;
            this.labelInsMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInsMiddle.Location = new System.Drawing.Point(6, 18);
            this.labelInsMiddle.Name = "labelInsMiddle";
            this.labelInsMiddle.Size = new System.Drawing.Size(96, 16);
            this.labelInsMiddle.TabIndex = 1;
            this.labelInsMiddle.Text = "labelInsMiddle";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(1, 16);
            this.label14.MaximumSize = new System.Drawing.Size(0, 500);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 15);
            this.label14.TabIndex = 47;
            this.label14.Text = "Fields marked (*) are Mandatory";
            // 
            // frmRebate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 666);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.maskedTxtBxZipCode);
            this.Controls.Add(this.txtBxEditUniqueId);
            this.Controls.Add(this.txtBxCountBackSpaceKey);
            this.Controls.Add(this.txtBxTimeSaved);
            this.Controls.Add(this.txtBxTimeStarted);
            this.Controls.Add(this.maskedTxtBxDate);
            this.Controls.Add(this.maskedTxtBxPhoneNumber);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBoxProofPurchase);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSaveExit);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBxState);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBxCity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBxAddressLine2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBxAddressLine1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxMiddleInitial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRebate";
            this.Text = "RebateForm";
            this.Load += new System.EventHandler(this.frmRebate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.groupBoxProofPurchase.ResumeLayout(false);
            this.groupBoxProofPurchase.PerformLayout();
            this.groupBoxError.ResumeLayout(false);
            this.groupBoxError.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxMiddleInitial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxAddressLine1;
        private System.Windows.Forms.TextBox txtBxAddressLine2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioBtnGenderMale;
        private System.Windows.Forms.RadioButton radioBtnGenderFemale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioBtnProofNo;
        private System.Windows.Forms.RadioButton radioBtnProofYes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnSaveExit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.GroupBox groupBoxProofPurchase;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.MaskedTextBox maskedTxtBxPhoneNumber;
        private System.Windows.Forms.MaskedTextBox maskedTxtBxDate;
        private System.Windows.Forms.TextBox txtBxTimeStarted;
        private System.Windows.Forms.TextBox txtBxTimeSaved;
        private System.Windows.Forms.TextBox txtBxCountBackSpaceKey;
        private System.Windows.Forms.TextBox txtBxEditUniqueId;
        private System.Windows.Forms.MaskedTextBox maskedTxtBxZipCode;
        private System.Windows.Forms.GroupBox groupBoxError;
        private System.Windows.Forms.Label labelErrorHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelInsLeft;
        private System.Windows.Forms.Label labelInsRight;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelInsMiddle;
        private System.Windows.Forms.Label label14;
    }
}

