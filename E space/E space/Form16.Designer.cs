namespace E_space
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madeYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enginetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfPassengerSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eJetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_SpaceDataSet15 = new E_space.E_SpaceDataSet15();
            this.label1 = new System.Windows.Forms.Label();
            this.e_JetTableAdapter = new E_space.E_SpaceDataSet15TableAdapters.E_JetTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eJetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_SpaceDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 166;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Window;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.SteelBlue;
            this.button5.Location = new System.Drawing.Point(620, 481);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 43);
            this.button5.TabIndex = 176;
            this.button5.Text = "Exit to Admin";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(494, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 175;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jetIDDataGridViewTextBoxColumn,
            this.madeYearDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.enginetypeDataGridViewTextBoxColumn,
            this.powerSourceDataGridViewTextBoxColumn,
            this.numberOfPassengerSeatsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eJetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(352, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(445, 211);
            this.dataGridView1.TabIndex = 174;
            // 
            // jetIDDataGridViewTextBoxColumn
            // 
            this.jetIDDataGridViewTextBoxColumn.DataPropertyName = "Jet_ID";
            this.jetIDDataGridViewTextBoxColumn.HeaderText = "Jet_ID";
            this.jetIDDataGridViewTextBoxColumn.Name = "jetIDDataGridViewTextBoxColumn";
            // 
            // madeYearDataGridViewTextBoxColumn
            // 
            this.madeYearDataGridViewTextBoxColumn.DataPropertyName = "Made_Year";
            this.madeYearDataGridViewTextBoxColumn.HeaderText = "Made_Year";
            this.madeYearDataGridViewTextBoxColumn.Name = "madeYearDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // enginetypeDataGridViewTextBoxColumn
            // 
            this.enginetypeDataGridViewTextBoxColumn.DataPropertyName = "Engine_type";
            this.enginetypeDataGridViewTextBoxColumn.HeaderText = "Engine_type";
            this.enginetypeDataGridViewTextBoxColumn.Name = "enginetypeDataGridViewTextBoxColumn";
            // 
            // powerSourceDataGridViewTextBoxColumn
            // 
            this.powerSourceDataGridViewTextBoxColumn.DataPropertyName = "Power_Source";
            this.powerSourceDataGridViewTextBoxColumn.HeaderText = "Power_Source";
            this.powerSourceDataGridViewTextBoxColumn.Name = "powerSourceDataGridViewTextBoxColumn";
            // 
            // numberOfPassengerSeatsDataGridViewTextBoxColumn
            // 
            this.numberOfPassengerSeatsDataGridViewTextBoxColumn.DataPropertyName = "Number_Of_Passenger_Seats";
            this.numberOfPassengerSeatsDataGridViewTextBoxColumn.HeaderText = "Number_Of_Passenger_Seats";
            this.numberOfPassengerSeatsDataGridViewTextBoxColumn.Name = "numberOfPassengerSeatsDataGridViewTextBoxColumn";
            // 
            // eJetBindingSource
            // 
            this.eJetBindingSource.DataMember = "E_Jet";
            this.eJetBindingSource.DataSource = this.e_SpaceDataSet15;
            // 
            // e_SpaceDataSet15
            // 
            this.e_SpaceDataSet15.DataSetName = "E_SpaceDataSet15";
            this.e_SpaceDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(511, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 43);
            this.label1.TabIndex = 173;
            this.label1.Text = "E_Jet";
            // 
            // e_JetTableAdapter
            // 
            this.e_JetTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(352, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 43);
            this.button1.TabIndex = 177;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(822, 549);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form16";
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eJetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_SpaceDataSet15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private E_SpaceDataSet15 e_SpaceDataSet15;
        private System.Windows.Forms.BindingSource eJetBindingSource;
        private E_SpaceDataSet15TableAdapters.E_JetTableAdapter e_JetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madeYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enginetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPassengerSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}