namespace E_space
{
    partial class Form26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form26));
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.astronomerTableAdapter = new E_space.E_SpaceDataSet16TableAdapters.AstronomerTableAdapter();
            this.e_SpaceDataSet18 = new E_space.E_SpaceDataSet18();
            this.colonistJobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colonist_JobTableAdapter = new E_space.E_SpaceDataSet18TableAdapters.Colonist_JobTableAdapter();
            this.marsColonizationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_SpaceDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colonistJobBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Window;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.SteelBlue;
            this.button5.Location = new System.Drawing.Point(713, 494);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 43);
            this.button5.TabIndex = 185;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(507, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 184;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marsColonizationIDDataGridViewTextBoxColumn,
            this.jobIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.colonistJobBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(365, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(445, 211);
            this.dataGridView1.TabIndex = 183;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(470, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 43);
            this.label1.TabIndex = 182;
            this.label1.Text = "Colonist_Job";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 181;
            this.pictureBox1.TabStop = false;
            // 
            // astronomerTableAdapter
            // 
            this.astronomerTableAdapter.ClearBeforeFill = true;
            // 
            // e_SpaceDataSet18
            // 
            this.e_SpaceDataSet18.DataSetName = "E_SpaceDataSet18";
            this.e_SpaceDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colonistJobBindingSource
            // 
            this.colonistJobBindingSource.DataMember = "Colonist_Job";
            this.colonistJobBindingSource.DataSource = this.e_SpaceDataSet18;
            // 
            // colonist_JobTableAdapter
            // 
            this.colonist_JobTableAdapter.ClearBeforeFill = true;
            // 
            // marsColonizationIDDataGridViewTextBoxColumn
            // 
            this.marsColonizationIDDataGridViewTextBoxColumn.DataPropertyName = "Mars_Colonization_ID";
            this.marsColonizationIDDataGridViewTextBoxColumn.HeaderText = "Mars_Colonization_ID";
            this.marsColonizationIDDataGridViewTextBoxColumn.Name = "marsColonizationIDDataGridViewTextBoxColumn";
            // 
            // jobIDDataGridViewTextBoxColumn
            // 
            this.jobIDDataGridViewTextBoxColumn.DataPropertyName = "Job_ID";
            this.jobIDDataGridViewTextBoxColumn.HeaderText = "Job_ID";
            this.jobIDDataGridViewTextBoxColumn.Name = "jobIDDataGridViewTextBoxColumn";
            // 
            // Form26
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(840, 561);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form26";
            this.Text = "Form26";
            this.Load += new System.EventHandler(this.Form26_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_SpaceDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colonistJobBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private E_SpaceDataSet16TableAdapters.AstronomerTableAdapter astronomerTableAdapter;
        private E_SpaceDataSet18 e_SpaceDataSet18;
        private System.Windows.Forms.BindingSource colonistJobBindingSource;
        private E_SpaceDataSet18TableAdapters.Colonist_JobTableAdapter colonist_JobTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn marsColonizationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobIDDataGridViewTextBoxColumn;
    }
}