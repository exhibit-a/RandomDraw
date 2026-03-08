namespace RandomDraw
{
    partial class frmDraw
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnPick = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entity_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmplNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contract_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgWinners = new System.Windows.Forms.DataGridView();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSurnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emplNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawDataSet1 = new RandomDraw.drawDataSet();
            this.dgDraw = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emplNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transEffDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawTableAdapter1 = new RandomDraw.drawDataSetTableAdapters.DrawTableAdapter();
            this.winnersTableAdapter1 = new RandomDraw.drawDataSetTableAdapters.WinnersTableAdapter();
            this.regionTableAdapter = new RandomDraw.drawDataSetTableAdapters.WinnersTableAdapter();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgWinners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "WINNERS";
            // 
            // btnAssign
            // 
            this.btnAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssign.AutoSize = true;
            this.btnAssign.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.Location = new System.Drawing.Point(628, 474);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(242, 23);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "ASSIGN RANDOM NUMBERS";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnPick
            // 
            this.btnPick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPick.AutoSize = true;
            this.btnPick.BackColor = System.Drawing.Color.Yellow;
            this.btnPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPick.Location = new System.Drawing.Point(876, 475);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(120, 23);
            this.btnPick.TabIndex = 4;
            this.btnPick.Text = "PICK WINNER";
            this.btnPick.UseVisualStyleBackColor = false;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.AutoSize = true;
            this.btnPrint.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(876, 503);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "PRINT WINNERS";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(178, 474);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProgress.Location = new System.Drawing.Point(12, 479);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(160, 14);
            this.lblProgress.TabIndex = 7;
            this.lblProgress.Text = "PROGRESS";
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRandomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomNumber.Location = new System.Drawing.Point(12, 506);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(55, 20);
            this.lblRandomNumber.TabIndex = 8;
            this.lblRandomNumber.Text = "RND";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.AutoSize = true;
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(628, 503);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(242, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "START NUMBER GENERATOR";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // Entity_Id
            // 
            this.Entity_Id.DataPropertyName = "Entity_Id";
            this.Entity_Id.HeaderText = "Entity_Id";
            this.Entity_Id.Name = "Entity_Id";
            // 
            // NameSurname
            // 
            this.NameSurname.DataPropertyName = "NameSurname";
            this.NameSurname.HeaderText = "NameSurname";
            this.NameSurname.Name = "NameSurname";
            // 
            // EmplNo
            // 
            this.EmplNo.DataPropertyName = "EmplNo";
            this.EmplNo.HeaderText = "EmplNo";
            this.EmplNo.Name = "EmplNo";
            // 
            // Contract_No
            // 
            this.Contract_No.DataPropertyName = "Contract_No";
            this.Contract_No.HeaderText = "Contract_No";
            this.Contract_No.Name = "Contract_No";
            // 
            // Employer_Name
            // 
            this.Employer_Name.DataPropertyName = "Employer_Name";
            this.Employer_Name.HeaderText = "Employer_Name";
            this.Employer_Name.Name = "Employer_Name";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Entity_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Entity_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NameSurname";
            this.dataGridViewTextBoxColumn2.HeaderText = "NameSurname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EmplNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "EmplNo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Contract_No";
            this.dataGridViewTextBoxColumn4.HeaderText = "Contract_No";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Employer_Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Employer_Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Contract_No";
            this.dataGridViewTextBoxColumn7.HeaderText = "Contract_No";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Employer_Name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Employer_Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Entity_Id";
            this.dataGridViewTextBoxColumn9.HeaderText = "Entity_Id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NameSurname";
            this.dataGridViewTextBoxColumn10.HeaderText = "NameSurname";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "EmplNo";
            this.dataGridViewTextBoxColumn11.HeaderText = "EmplNo";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Contract_No";
            this.dataGridViewTextBoxColumn12.HeaderText = "Contract_No";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Employer_Name";
            this.dataGridViewTextBoxColumn13.HeaderText = "Employer_Name";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // cbRegion
            // 
            this.cbRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(476, 477);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(146, 21);
            this.cbRegion.TabIndex = 10;
            this.cbRegion.SelectedIndexChanged += new System.EventHandler(this.cbRegion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "REGION";
            // 
            // dgWinners
            // 
            this.dgWinners.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgWinners.AutoGenerateColumns = false;
            this.dgWinners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWinners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Region,
            this.iDDataGridViewTextBoxColumn3,
            this.nameSurnameDataGridViewTextBoxColumn1,
            this.emplNoDataGridViewTextBoxColumn1});
            this.dgWinners.DataMember = "Winners";
            this.dgWinners.DataSource = this.drawDataSet1;
            this.dgWinners.Location = new System.Drawing.Point(12, 311);
            this.dgWinners.Name = "dgWinners";
            this.dgWinners.Size = new System.Drawing.Size(984, 156);
            this.dgWinners.TabIndex = 3;
            // 
            // Region
            // 
            this.Region.DataPropertyName = "Region";
            this.Region.HeaderText = "Region";
            this.Region.Name = "Region";
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            // 
            // nameSurnameDataGridViewTextBoxColumn1
            // 
            this.nameSurnameDataGridViewTextBoxColumn1.DataPropertyName = "NameSurname";
            this.nameSurnameDataGridViewTextBoxColumn1.HeaderText = "NameSurname";
            this.nameSurnameDataGridViewTextBoxColumn1.Name = "nameSurnameDataGridViewTextBoxColumn1";
            // 
            // emplNoDataGridViewTextBoxColumn1
            // 
            this.emplNoDataGridViewTextBoxColumn1.DataPropertyName = "EmplNo";
            this.emplNoDataGridViewTextBoxColumn1.HeaderText = "EmplNo";
            this.emplNoDataGridViewTextBoxColumn1.Name = "emplNoDataGridViewTextBoxColumn1";
            // 
            // drawDataSet1
            // 
            this.drawDataSet1.DataSetName = "drawDataSet";
            this.drawDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgDraw
            // 
            this.dgDraw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDraw.AutoGenerateColumns = false;
            this.dgDraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDraw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.RandomID,
            this.entityIdDataGridViewTextBoxColumn,
            this.nameSurnameDataGridViewTextBoxColumn,
            this.emplNoDataGridViewTextBoxColumn,
            this.contractNoDataGridViewTextBoxColumn,
            this.employerNameDataGridViewTextBoxColumn,
            this.branchNoDataGridViewTextBoxColumn,
            this.branchDataGridViewTextBoxColumn,
            this.subTypeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.subStatusDataGridViewTextBoxColumn,
            this.transTypeDataGridViewTextBoxColumn,
            this.transEffDateDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.transAmountDataGridViewTextBoxColumn,
            this.transCommentDataGridViewTextBoxColumn,
            this.periodMaxDataGridViewTextBoxColumn,
            this.fixedRateDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn});
            this.dgDraw.DataMember = "Draw";
            this.dgDraw.DataSource = this.drawDataSet1;
            this.dgDraw.Location = new System.Drawing.Point(13, 13);
            this.dgDraw.Name = "dgDraw";
            this.dgDraw.Size = new System.Drawing.Size(983, 262);
            this.dgDraw.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            // 
            // RandomID
            // 
            this.RandomID.DataPropertyName = "RandomID";
            this.RandomID.HeaderText = "RandomID";
            this.RandomID.Name = "RandomID";
            // 
            // entityIdDataGridViewTextBoxColumn
            // 
            this.entityIdDataGridViewTextBoxColumn.DataPropertyName = "Entity_Id";
            this.entityIdDataGridViewTextBoxColumn.HeaderText = "Entity_Id";
            this.entityIdDataGridViewTextBoxColumn.Name = "entityIdDataGridViewTextBoxColumn";
            // 
            // nameSurnameDataGridViewTextBoxColumn
            // 
            this.nameSurnameDataGridViewTextBoxColumn.DataPropertyName = "NameSurname";
            this.nameSurnameDataGridViewTextBoxColumn.HeaderText = "NameSurname";
            this.nameSurnameDataGridViewTextBoxColumn.Name = "nameSurnameDataGridViewTextBoxColumn";
            // 
            // emplNoDataGridViewTextBoxColumn
            // 
            this.emplNoDataGridViewTextBoxColumn.DataPropertyName = "EmplNo";
            this.emplNoDataGridViewTextBoxColumn.HeaderText = "EmplNo";
            this.emplNoDataGridViewTextBoxColumn.Name = "emplNoDataGridViewTextBoxColumn";
            // 
            // contractNoDataGridViewTextBoxColumn
            // 
            this.contractNoDataGridViewTextBoxColumn.DataPropertyName = "Contract_No";
            this.contractNoDataGridViewTextBoxColumn.HeaderText = "Contract_No";
            this.contractNoDataGridViewTextBoxColumn.Name = "contractNoDataGridViewTextBoxColumn";
            // 
            // employerNameDataGridViewTextBoxColumn
            // 
            this.employerNameDataGridViewTextBoxColumn.DataPropertyName = "Employer_Name";
            this.employerNameDataGridViewTextBoxColumn.HeaderText = "Employer_Name";
            this.employerNameDataGridViewTextBoxColumn.Name = "employerNameDataGridViewTextBoxColumn";
            // 
            // branchNoDataGridViewTextBoxColumn
            // 
            this.branchNoDataGridViewTextBoxColumn.DataPropertyName = "Branch No";
            this.branchNoDataGridViewTextBoxColumn.HeaderText = "Branch No";
            this.branchNoDataGridViewTextBoxColumn.Name = "branchNoDataGridViewTextBoxColumn";
            // 
            // branchDataGridViewTextBoxColumn
            // 
            this.branchDataGridViewTextBoxColumn.DataPropertyName = "Branch";
            this.branchDataGridViewTextBoxColumn.HeaderText = "Branch";
            this.branchDataGridViewTextBoxColumn.Name = "branchDataGridViewTextBoxColumn";
            // 
            // subTypeDataGridViewTextBoxColumn
            // 
            this.subTypeDataGridViewTextBoxColumn.DataPropertyName = "Sub_Type";
            this.subTypeDataGridViewTextBoxColumn.HeaderText = "Sub_Type";
            this.subTypeDataGridViewTextBoxColumn.Name = "subTypeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // subStatusDataGridViewTextBoxColumn
            // 
            this.subStatusDataGridViewTextBoxColumn.DataPropertyName = "SubStatus";
            this.subStatusDataGridViewTextBoxColumn.HeaderText = "SubStatus";
            this.subStatusDataGridViewTextBoxColumn.Name = "subStatusDataGridViewTextBoxColumn";
            // 
            // transTypeDataGridViewTextBoxColumn
            // 
            this.transTypeDataGridViewTextBoxColumn.DataPropertyName = "Trans_Type";
            this.transTypeDataGridViewTextBoxColumn.HeaderText = "Trans_Type";
            this.transTypeDataGridViewTextBoxColumn.Name = "transTypeDataGridViewTextBoxColumn";
            // 
            // transEffDateDataGridViewTextBoxColumn
            // 
            this.transEffDateDataGridViewTextBoxColumn.DataPropertyName = "Trans_Eff_Date";
            this.transEffDateDataGridViewTextBoxColumn.HeaderText = "Trans_Eff_Date";
            this.transEffDateDataGridViewTextBoxColumn.Name = "transEffDateDataGridViewTextBoxColumn";
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            // 
            // transAmountDataGridViewTextBoxColumn
            // 
            this.transAmountDataGridViewTextBoxColumn.DataPropertyName = "Trans_Amount";
            this.transAmountDataGridViewTextBoxColumn.HeaderText = "Trans_Amount";
            this.transAmountDataGridViewTextBoxColumn.Name = "transAmountDataGridViewTextBoxColumn";
            // 
            // transCommentDataGridViewTextBoxColumn
            // 
            this.transCommentDataGridViewTextBoxColumn.DataPropertyName = "Trans_Comment";
            this.transCommentDataGridViewTextBoxColumn.HeaderText = "Trans_Comment";
            this.transCommentDataGridViewTextBoxColumn.Name = "transCommentDataGridViewTextBoxColumn";
            // 
            // periodMaxDataGridViewTextBoxColumn
            // 
            this.periodMaxDataGridViewTextBoxColumn.DataPropertyName = "Period_Max";
            this.periodMaxDataGridViewTextBoxColumn.HeaderText = "Period_Max";
            this.periodMaxDataGridViewTextBoxColumn.Name = "periodMaxDataGridViewTextBoxColumn";
            // 
            // fixedRateDataGridViewTextBoxColumn
            // 
            this.fixedRateDataGridViewTextBoxColumn.DataPropertyName = "Fixed_Rate";
            this.fixedRateDataGridViewTextBoxColumn.HeaderText = "Fixed_Rate";
            this.fixedRateDataGridViewTextBoxColumn.Name = "fixedRateDataGridViewTextBoxColumn";
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            // 
            // drawTableAdapter1
            // 
            this.drawTableAdapter1.ClearBeforeFill = true;
            // 
            // winnersTableAdapter1
            // 
            this.winnersTableAdapter1.ClearBeforeFill = true;
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.Color.LimeGreen;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(284, 475);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "CLEAR WINNERS";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 542);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblRandomNumber);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.dgWinners);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDraw);
            this.Name = "frmDraw";
            this.Text = "Random Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgWinners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.DataGridView dgWinners;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.Button btnPrint;
        private drawDataSet drawDataSet1;
        private drawDataSetTableAdapters.DrawTableAdapter drawTableAdapter1;
        private drawDataSetTableAdapters.WinnersTableAdapter winnersTableAdapter1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblRandomNumber;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entity_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmplNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contract_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Label label2;
        private drawDataSetTableAdapters.WinnersTableAdapter regionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emplNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transEffDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transCommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixedRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSurnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emplNoDataGridViewTextBoxColumn1;
    }
}

