namespace E_space
{
    partial class Form15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.e_SpaceDataSet14 = new E_space.E_SpaceDataSet14();
            this.tripBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tripTableAdapter = new E_space.E_SpaceDataSet14TableAdapters.TripTableAdapter();
            this.tripIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.launchDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_SpaceDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 165;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Window;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.SteelBlue;
            this.button5.Location = new System.Drawing.Point(709, 495);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 43);
            this.button5.TabIndex = 172;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(503, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 171;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tripIDDataGridViewTextBoxColumn,
            this.launchDateDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn,
            this.jetIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tripBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(361, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(445, 211);
            this.dataGridView1.TabIndex = 170;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(539, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 43);
            this.label1.TabIndex = 169;
            this.label1.Text = "Trip";
            // 
            // e_SpaceDataSet14
            // 
            this.e_SpaceDataSet14.DataSetName = "E_SpaceDataSet14";
            this.e_SpaceDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tripBindingSource
            // 
            this.tripBindingSource.DataMember = "Trip";
            this.tripBindingSource.DataSource = this.e_SpaceDataSet14;
            // 
            // tripTableAdapter
            // 
            this.tripTableAdapter.ClearBeforeFill = true;
            // 
            // tripIDDataGridViewTextBoxColumn
            // 
            this.tripIDDataGridViewTextBoxColumn.DataPropertyName = "Trip_ID";
            this.tripIDDataGridViewTextBoxColumn.HeaderText = "Trip_ID";
            this.tripIDDataGridViewTextBoxColumn.Name = "tripIDDataGridViewTextBoxColumn";
            // 
            // launchDateDataGridViewTextBoxColumn
            // 
            this.launchDateDataGridViewTextBoxColumn.DataPropertyName = "Launch_Date";
            this.launchDateDataGridViewTextBoxColumn.HeaderText = "Launch_Date";
            this.launchDateDataGridViewTextBoxColumn.Name = "launchDateDataGridViewTextBoxColumn";
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "Return_Date";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "Return_Date";
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            // 
            // jetIDDataGridViewTextBoxColumn
            // 
            this.jetIDDataGridViewTextBoxColumn.DataPropertyName = "Jet_ID";
            this.jetIDDataGridViewTextBoxColumn.HeaderText = "Jet_ID";
            this.jetIDDataGridViewTextBoxColumn.Name = "jetIDDataGridViewTextBoxColumn";
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(836, 554);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form15";
            this.Text = "Form15";
            this.Load += new System.EventHandler(this.Form15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_SpaceDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private E_SpaceDataSet14 e_SpaceDataSet14;
        private System.Windows.Forms.BindingSource tripBindingSource;
        private E_SpaceDataSet14TableAdapters.TripTableAdapter tripTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn launchDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jetIDDataGridViewTextBoxColumn;
    }
}