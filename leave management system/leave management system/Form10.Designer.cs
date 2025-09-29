namespace leave_management_system
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet22 = new leave_management_system.Database1DataSet22();
            this.applyLeavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apply_LeavesTableAdapter = new leave_management_system.Database1DataSet22TableAdapters.Apply_LeavesTableAdapter();
            this.leaveIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annualsLeavesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortsLeavesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casualsLeavesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annualStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annualEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAnnualsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceAnnualsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casualStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casualEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCasualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceCasualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortLeaveDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortLeaveStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortLeaveEndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceShortLeaveDaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applyLeavesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(512, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Leaves and Leaves History";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(470, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Leave_Type";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Annuals_Leave",
            "Casuals_Leaves",
            "Shorts_Leaves"});
            this.comboBox2.Location = new System.Drawing.Point(677, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 24);
            this.comboBox2.TabIndex = 38;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Window;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Orange;
            this.button5.Location = new System.Drawing.Point(938, 504);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 49);
            this.button5.TabIndex = 40;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leaveIDDataGridViewTextBoxColumn,
            this.leaveTypeDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.annualsLeavesDataGridViewTextBoxColumn,
            this.shortsLeavesDataGridViewTextBoxColumn,
            this.casualsLeavesDataGridViewTextBoxColumn,
            this.annualStartDateDataGridViewTextBoxColumn,
            this.annualEndDateDataGridViewTextBoxColumn,
            this.totalAnnualsDataGridViewTextBoxColumn,
            this.balanceAnnualsDataGridViewTextBoxColumn,
            this.casualStartDateDataGridViewTextBoxColumn,
            this.casualEndDateDataGridViewTextBoxColumn,
            this.totalCasualDataGridViewTextBoxColumn,
            this.balanceCasualDataGridViewTextBoxColumn,
            this.shortLeaveDayDataGridViewTextBoxColumn,
            this.shortLeaveStartTimeDataGridViewTextBoxColumn,
            this.shortLeaveEndTimeDataGridViewTextBoxColumn,
            this.balanceShortLeaveDaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.applyLeavesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(477, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 283);
            this.dataGridView1.TabIndex = 41;
            // 
            // database1DataSet22
            // 
            this.database1DataSet22.DataSetName = "Database1DataSet22";
            this.database1DataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applyLeavesBindingSource
            // 
            this.applyLeavesBindingSource.DataMember = "Apply_Leaves";
            this.applyLeavesBindingSource.DataSource = this.database1DataSet22;
            // 
            // apply_LeavesTableAdapter
            // 
            this.apply_LeavesTableAdapter.ClearBeforeFill = true;
            // 
            // leaveIDDataGridViewTextBoxColumn
            // 
            this.leaveIDDataGridViewTextBoxColumn.DataPropertyName = "Leave_ID";
            this.leaveIDDataGridViewTextBoxColumn.HeaderText = "Leave_ID";
            this.leaveIDDataGridViewTextBoxColumn.Name = "leaveIDDataGridViewTextBoxColumn";
            // 
            // leaveTypeDataGridViewTextBoxColumn
            // 
            this.leaveTypeDataGridViewTextBoxColumn.DataPropertyName = "Leave_Type";
            this.leaveTypeDataGridViewTextBoxColumn.HeaderText = "Leave_Type";
            this.leaveTypeDataGridViewTextBoxColumn.Name = "leaveTypeDataGridViewTextBoxColumn";
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "Employee_Name";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "Employee_Name";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // annualsLeavesDataGridViewTextBoxColumn
            // 
            this.annualsLeavesDataGridViewTextBoxColumn.DataPropertyName = "Annuals_Leaves";
            this.annualsLeavesDataGridViewTextBoxColumn.HeaderText = "Annuals_Leaves";
            this.annualsLeavesDataGridViewTextBoxColumn.Name = "annualsLeavesDataGridViewTextBoxColumn";
            // 
            // shortsLeavesDataGridViewTextBoxColumn
            // 
            this.shortsLeavesDataGridViewTextBoxColumn.DataPropertyName = "Shorts_Leaves";
            this.shortsLeavesDataGridViewTextBoxColumn.HeaderText = "Shorts_Leaves";
            this.shortsLeavesDataGridViewTextBoxColumn.Name = "shortsLeavesDataGridViewTextBoxColumn";
            // 
            // casualsLeavesDataGridViewTextBoxColumn
            // 
            this.casualsLeavesDataGridViewTextBoxColumn.DataPropertyName = "Casuals_Leaves";
            this.casualsLeavesDataGridViewTextBoxColumn.HeaderText = "Casuals_Leaves";
            this.casualsLeavesDataGridViewTextBoxColumn.Name = "casualsLeavesDataGridViewTextBoxColumn";
            // 
            // annualStartDateDataGridViewTextBoxColumn
            // 
            this.annualStartDateDataGridViewTextBoxColumn.DataPropertyName = "Annual_Start_Date";
            this.annualStartDateDataGridViewTextBoxColumn.HeaderText = "Annual_Start_Date";
            this.annualStartDateDataGridViewTextBoxColumn.Name = "annualStartDateDataGridViewTextBoxColumn";
            // 
            // annualEndDateDataGridViewTextBoxColumn
            // 
            this.annualEndDateDataGridViewTextBoxColumn.DataPropertyName = "Annual_End_Date";
            this.annualEndDateDataGridViewTextBoxColumn.HeaderText = "Annual_End_Date";
            this.annualEndDateDataGridViewTextBoxColumn.Name = "annualEndDateDataGridViewTextBoxColumn";
            // 
            // totalAnnualsDataGridViewTextBoxColumn
            // 
            this.totalAnnualsDataGridViewTextBoxColumn.DataPropertyName = "Total_Annuals";
            this.totalAnnualsDataGridViewTextBoxColumn.HeaderText = "Total_Annuals";
            this.totalAnnualsDataGridViewTextBoxColumn.Name = "totalAnnualsDataGridViewTextBoxColumn";
            // 
            // balanceAnnualsDataGridViewTextBoxColumn
            // 
            this.balanceAnnualsDataGridViewTextBoxColumn.DataPropertyName = "Balance_Annuals";
            this.balanceAnnualsDataGridViewTextBoxColumn.HeaderText = "Balance_Annuals";
            this.balanceAnnualsDataGridViewTextBoxColumn.Name = "balanceAnnualsDataGridViewTextBoxColumn";
            // 
            // casualStartDateDataGridViewTextBoxColumn
            // 
            this.casualStartDateDataGridViewTextBoxColumn.DataPropertyName = "Casual_Start_Date";
            this.casualStartDateDataGridViewTextBoxColumn.HeaderText = "Casual_Start_Date";
            this.casualStartDateDataGridViewTextBoxColumn.Name = "casualStartDateDataGridViewTextBoxColumn";
            // 
            // casualEndDateDataGridViewTextBoxColumn
            // 
            this.casualEndDateDataGridViewTextBoxColumn.DataPropertyName = "Casual_End_Date";
            this.casualEndDateDataGridViewTextBoxColumn.HeaderText = "Casual_End_Date";
            this.casualEndDateDataGridViewTextBoxColumn.Name = "casualEndDateDataGridViewTextBoxColumn";
            // 
            // totalCasualDataGridViewTextBoxColumn
            // 
            this.totalCasualDataGridViewTextBoxColumn.DataPropertyName = "Total_Casual";
            this.totalCasualDataGridViewTextBoxColumn.HeaderText = "Total_Casual";
            this.totalCasualDataGridViewTextBoxColumn.Name = "totalCasualDataGridViewTextBoxColumn";
            // 
            // balanceCasualDataGridViewTextBoxColumn
            // 
            this.balanceCasualDataGridViewTextBoxColumn.DataPropertyName = "Balance_Casual";
            this.balanceCasualDataGridViewTextBoxColumn.HeaderText = "Balance_Casual";
            this.balanceCasualDataGridViewTextBoxColumn.Name = "balanceCasualDataGridViewTextBoxColumn";
            // 
            // shortLeaveDayDataGridViewTextBoxColumn
            // 
            this.shortLeaveDayDataGridViewTextBoxColumn.DataPropertyName = "Short_Leave_Day";
            this.shortLeaveDayDataGridViewTextBoxColumn.HeaderText = "Short_Leave_Day";
            this.shortLeaveDayDataGridViewTextBoxColumn.Name = "shortLeaveDayDataGridViewTextBoxColumn";
            // 
            // shortLeaveStartTimeDataGridViewTextBoxColumn
            // 
            this.shortLeaveStartTimeDataGridViewTextBoxColumn.DataPropertyName = "Short_Leave_Start_Time";
            this.shortLeaveStartTimeDataGridViewTextBoxColumn.HeaderText = "Short_Leave_Start_Time";
            this.shortLeaveStartTimeDataGridViewTextBoxColumn.Name = "shortLeaveStartTimeDataGridViewTextBoxColumn";
            // 
            // shortLeaveEndTimeDataGridViewTextBoxColumn
            // 
            this.shortLeaveEndTimeDataGridViewTextBoxColumn.DataPropertyName = "Short_Leave_End_Time";
            this.shortLeaveEndTimeDataGridViewTextBoxColumn.HeaderText = "Short_Leave_End_Time";
            this.shortLeaveEndTimeDataGridViewTextBoxColumn.Name = "shortLeaveEndTimeDataGridViewTextBoxColumn";
            // 
            // balanceShortLeaveDaDataGridViewTextBoxColumn
            // 
            this.balanceShortLeaveDaDataGridViewTextBoxColumn.DataPropertyName = "Balance_Short_Leave_Da";
            this.balanceShortLeaveDaDataGridViewTextBoxColumn.HeaderText = "Balance_Short_Leave_Da";
            this.balanceShortLeaveDaDataGridViewTextBoxColumn.Name = "balanceShortLeaveDaDataGridViewTextBoxColumn";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 565);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applyLeavesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet22 database1DataSet22;
        private System.Windows.Forms.BindingSource applyLeavesBindingSource;
        private Database1DataSet22TableAdapters.Apply_LeavesTableAdapter apply_LeavesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualsLeavesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortsLeavesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casualsLeavesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAnnualsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceAnnualsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casualStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casualEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCasualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceCasualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortLeaveDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortLeaveStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortLeaveEndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceShortLeaveDaDataGridViewTextBoxColumn;
    }
}