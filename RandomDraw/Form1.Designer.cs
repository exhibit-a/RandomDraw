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
            components = new System.ComponentModel.Container();
            label1 = new System.Windows.Forms.Label();
            btnAssign = new System.Windows.Forms.Button();
            btnPick = new System.Windows.Forms.Button();
            btnPrint = new System.Windows.Forms.Button();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            lblProgress = new System.Windows.Forms.Label();
            lblRandomNumber = new System.Windows.Forms.Label();
            btnStart = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Entity_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NameSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EmplNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Contract_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Employer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cbRegion = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            dgWinners = new System.Windows.Forms.DataGridView();
            Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameSurnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            emplNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            drawDataSet1 = new drawDataSet();
            dgDraw = new System.Windows.Forms.DataGridView();
            iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RandomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            entityIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            emplNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            contractNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            employerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            branchNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            branchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            subTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            subStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            transTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            transEffDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            transAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            transCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            periodMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fixedRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            drawTableAdapter1 = new RandomDraw.drawDataSetTableAdapters.DrawTableAdapter();
            winnersTableAdapter1 = new RandomDraw.drawDataSetTableAdapters.WinnersTableAdapter();
            regionTableAdapter = new RandomDraw.drawDataSetTableAdapters.WinnersTableAdapter();
            btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgWinners).BeginInit();
            ((System.ComponentModel.ISupportInitialize)drawDataSet1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgDraw).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(14, 330);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 13);
            label1.TabIndex = 1;
            label1.Text = "WINNERS";
            // 
            // btnAssign
            // 
            btnAssign.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnAssign.AutoSize = true;
            btnAssign.BackColor = System.Drawing.Color.LimeGreen;
            btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAssign.Location = new System.Drawing.Point(734, 512);
            btnAssign.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new System.Drawing.Size(282, 27);
            btnAssign.TabIndex = 2;
            btnAssign.Text = "2. ASSIGN RANDOM NUMBERS";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += btnAssign_Click;
            // 
            // btnPick
            // 
            btnPick.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnPick.AutoSize = true;
            btnPick.BackColor = System.Drawing.Color.Yellow;
            btnPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnPick.Location = new System.Drawing.Point(1023, 513);
            btnPick.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPick.Name = "btnPick";
            btnPick.Size = new System.Drawing.Size(140, 27);
            btnPick.TabIndex = 4;
            btnPick.Text = "4. PICK WINNER";
            btnPick.UseVisualStyleBackColor = false;
            btnPick.Click += btnPick_Click;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnPrint.AutoSize = true;
            btnPrint.BackColor = System.Drawing.Color.DarkOrange;
            btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnPrint.Location = new System.Drawing.Point(1023, 545);
            btnPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(140, 27);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "5. PRINT WINNERS";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            progressBar1.Location = new System.Drawing.Point(209, 512);
            progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(117, 27);
            progressBar1.TabIndex = 6;
            // 
            // lblProgress
            // 
            lblProgress.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblProgress.Location = new System.Drawing.Point(15, 518);
            lblProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new System.Drawing.Size(187, 16);
            lblProgress.TabIndex = 7;
            lblProgress.Text = "PROGRESS";
            // 
            // lblRandomNumber
            // 
            lblRandomNumber.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblRandomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblRandomNumber.Location = new System.Drawing.Point(14, 584);
            lblRandomNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRandomNumber.Name = "lblRandomNumber";
            lblRandomNumber.Size = new System.Drawing.Size(64, 23);
            lblRandomNumber.TabIndex = 8;
            lblRandomNumber.Text = "RND";
            // 
            // btnStart
            // 
            btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnStart.AutoSize = true;
            btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnStart.Location = new System.Drawing.Point(734, 545);
            btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(282, 27);
            btnStart.TabIndex = 9;
            btnStart.Text = "3. START NUMBER GENERATOR";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // Entity_Id
            // 
            Entity_Id.DataPropertyName = "Entity_Id";
            Entity_Id.HeaderText = "Entity_Id";
            Entity_Id.Name = "Entity_Id";
            // 
            // NameSurname
            // 
            NameSurname.DataPropertyName = "NameSurname";
            NameSurname.HeaderText = "NameSurname";
            NameSurname.Name = "NameSurname";
            // 
            // EmplNo
            // 
            EmplNo.DataPropertyName = "EmplNo";
            EmplNo.HeaderText = "EmplNo";
            EmplNo.Name = "EmplNo";
            // 
            // Contract_No
            // 
            Contract_No.DataPropertyName = "Contract_No";
            Contract_No.HeaderText = "Contract_No";
            Contract_No.Name = "Contract_No";
            // 
            // Employer_Name
            // 
            Employer_Name.DataPropertyName = "Employer_Name";
            Employer_Name.HeaderText = "Employer_Name";
            Employer_Name.Name = "Employer_Name";
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Entity_Id";
            dataGridViewTextBoxColumn1.HeaderText = "Entity_Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "NameSurname";
            dataGridViewTextBoxColumn2.HeaderText = "NameSurname";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "EmplNo";
            dataGridViewTextBoxColumn3.HeaderText = "EmplNo";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Contract_No";
            dataGridViewTextBoxColumn4.HeaderText = "Contract_No";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Employer_Name";
            dataGridViewTextBoxColumn5.HeaderText = "Employer_Name";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "ID";
            dataGridViewTextBoxColumn6.HeaderText = "ID";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Contract_No";
            dataGridViewTextBoxColumn7.HeaderText = "Contract_No";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Employer_Name";
            dataGridViewTextBoxColumn8.HeaderText = "Employer_Name";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "Entity_Id";
            dataGridViewTextBoxColumn9.HeaderText = "Entity_Id";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "NameSurname";
            dataGridViewTextBoxColumn10.HeaderText = "NameSurname";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "EmplNo";
            dataGridViewTextBoxColumn11.HeaderText = "EmplNo";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "Contract_No";
            dataGridViewTextBoxColumn12.HeaderText = "Contract_No";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "Employer_Name";
            dataGridViewTextBoxColumn13.HeaderText = "Employer_Name";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // cbRegion
            // 
            cbRegion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            cbRegion.FormattingEnabled = true;
            cbRegion.Location = new System.Drawing.Point(556, 515);
            cbRegion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbRegion.Name = "cbRegion";
            cbRegion.Size = new System.Drawing.Size(170, 23);
            cbRegion.TabIndex = 10;
            cbRegion.SelectedIndexChanged += cbRegion_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(492, 519);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 15);
            label2.TabIndex = 11;
            label2.Text = "REGION";
            // 
            // dgWinners
            // 
            dgWinners.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgWinners.AutoGenerateColumns = false;
            dgWinners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgWinners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Region, iDDataGridViewTextBoxColumn3, nameSurnameDataGridViewTextBoxColumn1, emplNoDataGridViewTextBoxColumn1 });
            dgWinners.DataMember = "Winners";
            dgWinners.DataSource = drawDataSet1;
            dgWinners.Location = new System.Drawing.Point(14, 359);
            dgWinners.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgWinners.Name = "dgWinners";
            dgWinners.Size = new System.Drawing.Size(1148, 147);
            dgWinners.TabIndex = 3;
            // 
            // Region
            // 
            Region.DataPropertyName = "Region";
            Region.HeaderText = "Region";
            Region.Name = "Region";
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            // 
            // nameSurnameDataGridViewTextBoxColumn1
            // 
            nameSurnameDataGridViewTextBoxColumn1.DataPropertyName = "NameSurname";
            nameSurnameDataGridViewTextBoxColumn1.HeaderText = "NameSurname";
            nameSurnameDataGridViewTextBoxColumn1.Name = "nameSurnameDataGridViewTextBoxColumn1";
            // 
            // emplNoDataGridViewTextBoxColumn1
            // 
            emplNoDataGridViewTextBoxColumn1.DataPropertyName = "EmplNo";
            emplNoDataGridViewTextBoxColumn1.HeaderText = "EmplNo";
            emplNoDataGridViewTextBoxColumn1.Name = "emplNoDataGridViewTextBoxColumn1";
            // 
            // drawDataSet1
            // 
            drawDataSet1.DataSetName = "drawDataSet";
            drawDataSet1.Namespace = "http://tempuri.org/drawDataSet.xsd";
            drawDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgDraw
            // 
            dgDraw.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgDraw.AutoGenerateColumns = false;
            dgDraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDraw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { iDDataGridViewTextBoxColumn2, RandomID, entityIdDataGridViewTextBoxColumn, nameSurnameDataGridViewTextBoxColumn, emplNoDataGridViewTextBoxColumn, contractNoDataGridViewTextBoxColumn, employerNameDataGridViewTextBoxColumn, branchNoDataGridViewTextBoxColumn, branchDataGridViewTextBoxColumn, subTypeDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, subStatusDataGridViewTextBoxColumn, transTypeDataGridViewTextBoxColumn, transEffDateDataGridViewTextBoxColumn, monthDataGridViewTextBoxColumn, transAmountDataGridViewTextBoxColumn, transCommentDataGridViewTextBoxColumn, periodMaxDataGridViewTextBoxColumn, fixedRateDataGridViewTextBoxColumn, regionDataGridViewTextBoxColumn });
            dgDraw.DataMember = "Draw";
            dgDraw.DataSource = drawDataSet1;
            dgDraw.Location = new System.Drawing.Point(15, 15);
            dgDraw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgDraw.Name = "dgDraw";
            dgDraw.Size = new System.Drawing.Size(1147, 302);
            dgDraw.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            // 
            // RandomID
            // 
            RandomID.DataPropertyName = "RandomID";
            RandomID.HeaderText = "RandomID";
            RandomID.Name = "RandomID";
            // 
            // entityIdDataGridViewTextBoxColumn
            // 
            entityIdDataGridViewTextBoxColumn.DataPropertyName = "Entity_Id";
            entityIdDataGridViewTextBoxColumn.HeaderText = "Entity_Id";
            entityIdDataGridViewTextBoxColumn.Name = "entityIdDataGridViewTextBoxColumn";
            // 
            // nameSurnameDataGridViewTextBoxColumn
            // 
            nameSurnameDataGridViewTextBoxColumn.DataPropertyName = "NameSurname";
            nameSurnameDataGridViewTextBoxColumn.HeaderText = "NameSurname";
            nameSurnameDataGridViewTextBoxColumn.Name = "nameSurnameDataGridViewTextBoxColumn";
            // 
            // emplNoDataGridViewTextBoxColumn
            // 
            emplNoDataGridViewTextBoxColumn.DataPropertyName = "EmplNo";
            emplNoDataGridViewTextBoxColumn.HeaderText = "EmplNo";
            emplNoDataGridViewTextBoxColumn.Name = "emplNoDataGridViewTextBoxColumn";
            // 
            // contractNoDataGridViewTextBoxColumn
            // 
            contractNoDataGridViewTextBoxColumn.DataPropertyName = "Contract_No";
            contractNoDataGridViewTextBoxColumn.HeaderText = "Contract_No";
            contractNoDataGridViewTextBoxColumn.Name = "contractNoDataGridViewTextBoxColumn";
            // 
            // employerNameDataGridViewTextBoxColumn
            // 
            employerNameDataGridViewTextBoxColumn.DataPropertyName = "Employer_Name";
            employerNameDataGridViewTextBoxColumn.HeaderText = "Employer_Name";
            employerNameDataGridViewTextBoxColumn.Name = "employerNameDataGridViewTextBoxColumn";
            // 
            // branchNoDataGridViewTextBoxColumn
            // 
            branchNoDataGridViewTextBoxColumn.DataPropertyName = "Branch No";
            branchNoDataGridViewTextBoxColumn.HeaderText = "Branch No";
            branchNoDataGridViewTextBoxColumn.Name = "branchNoDataGridViewTextBoxColumn";
            // 
            // branchDataGridViewTextBoxColumn
            // 
            branchDataGridViewTextBoxColumn.DataPropertyName = "Branch";
            branchDataGridViewTextBoxColumn.HeaderText = "Branch";
            branchDataGridViewTextBoxColumn.Name = "branchDataGridViewTextBoxColumn";
            // 
            // subTypeDataGridViewTextBoxColumn
            // 
            subTypeDataGridViewTextBoxColumn.DataPropertyName = "Sub_Type";
            subTypeDataGridViewTextBoxColumn.HeaderText = "Sub_Type";
            subTypeDataGridViewTextBoxColumn.Name = "subTypeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // subStatusDataGridViewTextBoxColumn
            // 
            subStatusDataGridViewTextBoxColumn.DataPropertyName = "SubStatus";
            subStatusDataGridViewTextBoxColumn.HeaderText = "SubStatus";
            subStatusDataGridViewTextBoxColumn.Name = "subStatusDataGridViewTextBoxColumn";
            // 
            // transTypeDataGridViewTextBoxColumn
            // 
            transTypeDataGridViewTextBoxColumn.DataPropertyName = "Trans_Type";
            transTypeDataGridViewTextBoxColumn.HeaderText = "Trans_Type";
            transTypeDataGridViewTextBoxColumn.Name = "transTypeDataGridViewTextBoxColumn";
            // 
            // transEffDateDataGridViewTextBoxColumn
            // 
            transEffDateDataGridViewTextBoxColumn.DataPropertyName = "Trans_Eff_Date";
            transEffDateDataGridViewTextBoxColumn.HeaderText = "Trans_Eff_Date";
            transEffDateDataGridViewTextBoxColumn.Name = "transEffDateDataGridViewTextBoxColumn";
            // 
            // monthDataGridViewTextBoxColumn
            // 
            monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            monthDataGridViewTextBoxColumn.HeaderText = "Month";
            monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            // 
            // transAmountDataGridViewTextBoxColumn
            // 
            transAmountDataGridViewTextBoxColumn.DataPropertyName = "Trans_Amount";
            transAmountDataGridViewTextBoxColumn.HeaderText = "Trans_Amount";
            transAmountDataGridViewTextBoxColumn.Name = "transAmountDataGridViewTextBoxColumn";
            // 
            // transCommentDataGridViewTextBoxColumn
            // 
            transCommentDataGridViewTextBoxColumn.DataPropertyName = "Trans_Comment";
            transCommentDataGridViewTextBoxColumn.HeaderText = "Trans_Comment";
            transCommentDataGridViewTextBoxColumn.Name = "transCommentDataGridViewTextBoxColumn";
            // 
            // periodMaxDataGridViewTextBoxColumn
            // 
            periodMaxDataGridViewTextBoxColumn.DataPropertyName = "Period_Max";
            periodMaxDataGridViewTextBoxColumn.HeaderText = "Period_Max";
            periodMaxDataGridViewTextBoxColumn.Name = "periodMaxDataGridViewTextBoxColumn";
            // 
            // fixedRateDataGridViewTextBoxColumn
            // 
            fixedRateDataGridViewTextBoxColumn.DataPropertyName = "Fixed_Rate";
            fixedRateDataGridViewTextBoxColumn.HeaderText = "Fixed_Rate";
            fixedRateDataGridViewTextBoxColumn.Name = "fixedRateDataGridViewTextBoxColumn";
            // 
            // regionDataGridViewTextBoxColumn
            // 
            regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            regionDataGridViewTextBoxColumn.HeaderText = "Region";
            regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            // 
            // drawTableAdapter1
            // 
            drawTableAdapter1.ClearBeforeFill = true;
            // 
            // winnersTableAdapter1
            // 
            winnersTableAdapter1.ClearBeforeFill = true;
            // 
            // regionTableAdapter
            // 
            regionTableAdapter.ClearBeforeFill = true;
            // 
            // btnClear
            // 
            btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClear.AutoSize = true;
            btnClear.BackColor = System.Drawing.Color.LimeGreen;
            btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnClear.Location = new System.Drawing.Point(332, 513);
            btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(153, 27);
            btnClear.TabIndex = 12;
            btnClear.Text = "1. CLEAR WINNERS";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // frmDraw
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1176, 625);
            Controls.Add(btnClear);
            Controls.Add(label2);
            Controls.Add(cbRegion);
            Controls.Add(btnStart);
            Controls.Add(lblRandomNumber);
            Controls.Add(lblProgress);
            Controls.Add(progressBar1);
            Controls.Add(btnPrint);
            Controls.Add(btnPick);
            Controls.Add(dgWinners);
            Controls.Add(btnAssign);
            Controls.Add(label1);
            Controls.Add(dgDraw);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmDraw";
            Text = "Random Draw";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmDraw_Load;
            ((System.ComponentModel.ISupportInitialize)dgWinners).EndInit();
            ((System.ComponentModel.ISupportInitialize)drawDataSet1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgDraw).EndInit();
            ResumeLayout(false);
            PerformLayout();

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

