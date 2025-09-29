namespace E_space
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.e_SpaceDataSet12 = new E_space.E_SpaceDataSet12();
            this.houseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseTableAdapter = new E_space.E_SpaceDataSet12TableAdapters.HouseTableAdapter();
            this.colonyLotNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOFRoomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squareFeetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_SpaceDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Window;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.SteelBlue;
            this.button5.Location = new System.Drawing.Point(714, 495);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 43);
            this.button5.TabIndex = 162;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(508, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 161;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colonyLotNoDataGridViewTextBoxColumn,
            this.numberOFRoomsDataGridViewTextBoxColumn,
            this.squareFeetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.houseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(366, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(445, 211);
            this.dataGridView1.TabIndex = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(520, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 43);
            this.label1.TabIndex = 159;
            this.label1.Text = "House";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 558);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 163;
            this.pictureBox1.TabStop = false;
            // 
            // e_SpaceDataSet12
            // 
            this.e_SpaceDataSet12.DataSetName = "E_SpaceDataSet12";
            this.e_SpaceDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // houseBindingSource
            // 
            this.houseBindingSource.DataMember = "House";
            this.houseBindingSource.DataSource = this.e_SpaceDataSet12;
            // 
            // houseTableAdapter
            // 
            this.houseTableAdapter.ClearBeforeFill = true;
            // 
            // colonyLotNoDataGridViewTextBoxColumn
            // 
            this.colonyLotNoDataGridViewTextBoxColumn.DataPropertyName = "Colony_Lot_No";
            this.colonyLotNoDataGridViewTextBoxColumn.HeaderText = "Colony_Lot_No";
            this.colonyLotNoDataGridViewTextBoxColumn.Name = "colonyLotNoDataGridViewTextBoxColumn";
            // 
            // numberOFRoomsDataGridViewTextBoxColumn
            // 
            this.numberOFRoomsDataGridViewTextBoxColumn.DataPropertyName = "Number_OF_Rooms";
            this.numberOFRoomsDataGridViewTextBoxColumn.HeaderText = "Number_OF_Rooms";
            this.numberOFRoomsDataGridViewTextBoxColumn.Name = "numberOFRoomsDataGridViewTextBoxColumn";
            // 
            // squareFeetDataGridViewTextBoxColumn
            // 
            this.squareFeetDataGridViewTextBoxColumn.DataPropertyName = "Square_Feet";
            this.squareFeetDataGridViewTextBoxColumn.HeaderText = "Square_Feet";
            this.squareFeetDataGridViewTextBoxColumn.Name = "squareFeetDataGridViewTextBoxColumn";
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(838, 552);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form13";
            this.Text = "Form13";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_SpaceDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private E_SpaceDataSet12 e_SpaceDataSet12;
        private System.Windows.Forms.BindingSource houseBindingSource;
        private E_SpaceDataSet12TableAdapters.HouseTableAdapter houseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonyLotNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOFRoomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn squareFeetDataGridViewTextBoxColumn;
    }
}