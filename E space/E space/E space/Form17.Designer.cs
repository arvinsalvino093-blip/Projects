namespace E_space
{
    partial class Form17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form17));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.e_SpaceDataSet16 = new E_space.E_SpaceDataSet16();
            this.astronomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.astronomerTableAdapter = new E_space.E_SpaceDataSet16TableAdapters.AstronomerTableAdapter();
            this.astronomerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fristNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofSpaceHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_SpaceDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.astronomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 167;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Window;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.SteelBlue;
            this.button5.Location = new System.Drawing.Point(713, 495);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 43);
            this.button5.TabIndex = 180;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(507, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 179;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.astronomerIDDataGridViewTextBoxColumn,
            this.fristNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.numberofSpaceHoursDataGridViewTextBoxColumn,
            this.jetIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.astronomerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(365, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(445, 211);
            this.dataGridView1.TabIndex = 178;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(470, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 43);
            this.label1.TabIndex = 177;
            this.label1.Text = "Astronomer";
            // 
            // e_SpaceDataSet16
            // 
            this.e_SpaceDataSet16.DataSetName = "E_SpaceDataSet16";
            this.e_SpaceDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // astronomerBindingSource
            // 
            this.astronomerBindingSource.DataMember = "Astronomer";
            this.astronomerBindingSource.DataSource = this.e_SpaceDataSet16;
            // 
            // astronomerTableAdapter
            // 
            this.astronomerTableAdapter.ClearBeforeFill = true;
            // 
            // astronomerIDDataGridViewTextBoxColumn
            // 
            this.astronomerIDDataGridViewTextBoxColumn.DataPropertyName = "Astronomer_ID";
            this.astronomerIDDataGridViewTextBoxColumn.HeaderText = "Astronomer_ID";
            this.astronomerIDDataGridViewTextBoxColumn.Name = "astronomerIDDataGridViewTextBoxColumn";
            // 
            // fristNameDataGridViewTextBoxColumn
            // 
            this.fristNameDataGridViewTextBoxColumn.DataPropertyName = "Frist_Name";
            this.fristNameDataGridViewTextBoxColumn.HeaderText = "Frist_Name";
            this.fristNameDataGridViewTextBoxColumn.Name = "fristNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "Middle_Name";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Middle_Name";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            // 
            // numberofSpaceHoursDataGridViewTextBoxColumn
            // 
            this.numberofSpaceHoursDataGridViewTextBoxColumn.DataPropertyName = "Number_of_Space_Hours";
            this.numberofSpaceHoursDataGridViewTextBoxColumn.HeaderText = "Number_of_Space_Hours";
            this.numberofSpaceHoursDataGridViewTextBoxColumn.Name = "numberofSpaceHoursDataGridViewTextBoxColumn";
            // 
            // jetIDDataGridViewTextBoxColumn
            // 
            this.jetIDDataGridViewTextBoxColumn.DataPropertyName = "Jet_ID";
            this.jetIDDataGridViewTextBoxColumn.HeaderText = "Jet_ID";
            this.jetIDDataGridViewTextBoxColumn.Name = "jetIDDataGridViewTextBoxColumn";
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(845, 552);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form17";
            this.Text = "Form17";
            this.Load += new System.EventHandler(this.Form17_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_SpaceDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.astronomerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private E_SpaceDataSet16 e_SpaceDataSet16;
        private System.Windows.Forms.BindingSource astronomerBindingSource;
        private E_SpaceDataSet16TableAdapters.AstronomerTableAdapter astronomerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn astronomerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fristNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofSpaceHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jetIDDataGridViewTextBoxColumn;
    }
}