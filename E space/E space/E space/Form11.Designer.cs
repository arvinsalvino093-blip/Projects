namespace E_space
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colonistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_SpaceDataSet = new E_space.E_SpaceDataSet();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.colonistTableAdapter = new E_space.E_SpaceDataSetTableAdapters.ColonistTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.e_SpaceDataSet10 = new E_space.E_SpaceDataSet10();
            this.colonistBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colonistTableAdapter1 = new E_space.E_SpaceDataSet10TableAdapters.ColonistTableAdapter();
            this.marsColonizationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fristNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.civilStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.earthAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofpeoplebringtoMarsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colonistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_SpaceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_SpaceDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colonistBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 542);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(479, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 43);
            this.label1.TabIndex = 33;
            this.label1.Text = "Colonist";
            // 
            // colonistBindingSource
            // 
            this.colonistBindingSource.DataMember = "Colonist";
            this.colonistBindingSource.DataSource = this.e_SpaceDataSet;
            // 
            // e_SpaceDataSet
            // 
            this.e_SpaceDataSet.DataSetName = "E_SpaceDataSet";
            this.e_SpaceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(487, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Window;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.SteelBlue;
            this.button5.Location = new System.Drawing.Point(693, 485);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 43);
            this.button5.TabIndex = 158;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // colonistTableAdapter
            // 
            this.colonistTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marsColonizationIDDataGridViewTextBoxColumn,
            this.fristNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.civilStatusDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.earthAddressDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.numberofpeoplebringtoMarsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.colonistBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(347, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(452, 222);
            this.dataGridView1.TabIndex = 159;
            // 
            // e_SpaceDataSet10
            // 
            this.e_SpaceDataSet10.DataSetName = "E_SpaceDataSet10";
            this.e_SpaceDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colonistBindingSource1
            // 
            this.colonistBindingSource1.DataMember = "Colonist";
            this.colonistBindingSource1.DataSource = this.e_SpaceDataSet10;
            // 
            // colonistTableAdapter1
            // 
            this.colonistTableAdapter1.ClearBeforeFill = true;
            // 
            // marsColonizationIDDataGridViewTextBoxColumn
            // 
            this.marsColonizationIDDataGridViewTextBoxColumn.DataPropertyName = "Mars_Colonization_ID";
            this.marsColonizationIDDataGridViewTextBoxColumn.HeaderText = "Mars_Colonization_ID";
            this.marsColonizationIDDataGridViewTextBoxColumn.Name = "marsColonizationIDDataGridViewTextBoxColumn";
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
            // civilStatusDataGridViewTextBoxColumn
            // 
            this.civilStatusDataGridViewTextBoxColumn.DataPropertyName = "Civil_Status";
            this.civilStatusDataGridViewTextBoxColumn.HeaderText = "Civil_Status";
            this.civilStatusDataGridViewTextBoxColumn.Name = "civilStatusDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "Contact_No";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "Contact_No";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            // 
            // earthAddressDataGridViewTextBoxColumn
            // 
            this.earthAddressDataGridViewTextBoxColumn.DataPropertyName = "Earth_Address";
            this.earthAddressDataGridViewTextBoxColumn.HeaderText = "Earth_Address";
            this.earthAddressDataGridViewTextBoxColumn.Name = "earthAddressDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // numberofpeoplebringtoMarsDataGridViewTextBoxColumn
            // 
            this.numberofpeoplebringtoMarsDataGridViewTextBoxColumn.DataPropertyName = "Number_of_people_bring_to_Mars";
            this.numberofpeoplebringtoMarsDataGridViewTextBoxColumn.HeaderText = "Number_of_people_bring_to_Mars";
            this.numberofpeoplebringtoMarsDataGridViewTextBoxColumn.Name = "numberofpeoplebringtoMarsDataGridViewTextBoxColumn";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(811, 540);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colonistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_SpaceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_SpaceDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colonistBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button5;
        private E_SpaceDataSet e_SpaceDataSet;
        private System.Windows.Forms.BindingSource colonistBindingSource;
        private E_SpaceDataSetTableAdapters.ColonistTableAdapter colonistTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private E_SpaceDataSet10 e_SpaceDataSet10;
        private System.Windows.Forms.BindingSource colonistBindingSource1;
        private E_SpaceDataSet10TableAdapters.ColonistTableAdapter colonistTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn marsColonizationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fristNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn civilStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn earthAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofpeoplebringtoMarsDataGridViewTextBoxColumn;
    }
}