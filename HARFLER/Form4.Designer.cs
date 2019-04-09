namespace HARFLER
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hARFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oLASILIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEKLIBindingSource = new System.Windows.Forms.BindingSource();
            this.harflerDataSet2 = new HARFLER.harflerDataSet2();
            this.tEKLITableAdapter = new HARFLER.harflerDataSet2TableAdapters.TEKLITableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.harflerDataSet3 = new HARFLER.harflerDataSet3();
            this.tEKLIBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tEKLITableAdapter1 = new HARFLER.harflerDataSet3TableAdapters.TEKLITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.harflerDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEKLIBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hARFDataGridViewTextBoxColumn,
            this.oLASILIKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tEKLIBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // hARFDataGridViewTextBoxColumn
            // 
            this.hARFDataGridViewTextBoxColumn.DataPropertyName = "HARF";
            this.hARFDataGridViewTextBoxColumn.HeaderText = "HARF";
            this.hARFDataGridViewTextBoxColumn.Name = "hARFDataGridViewTextBoxColumn";
            // 
            // oLASILIKDataGridViewTextBoxColumn
            // 
            this.oLASILIKDataGridViewTextBoxColumn.DataPropertyName = "OLASILIK";
            this.oLASILIKDataGridViewTextBoxColumn.HeaderText = "OLASILIK";
            this.oLASILIKDataGridViewTextBoxColumn.Name = "oLASILIKDataGridViewTextBoxColumn";
            // 
            // tEKLIBindingSource
            // 
            this.tEKLIBindingSource.DataMember = "TEKLI";
            this.tEKLIBindingSource.DataSource = this.harflerDataSet2;
            // 
            // harflerDataSet2
            // 
            this.harflerDataSet2.DataSetName = "harflerDataSet2";
            this.harflerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tEKLITableAdapter
            // 
            this.tEKLITableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(443, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 19);
            this.button3.TabIndex = 9;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 20);
            this.button2.TabIndex = 8;
            this.button2.Text = "OKU";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "DOSYA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 345);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(468, 42);
            this.textBox2.TabIndex = 10;
            // 
            // harflerDataSet3
            // 
            this.harflerDataSet3.DataSetName = "harflerDataSet3";
            this.harflerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tEKLIBindingSource1
            // 
            this.tEKLIBindingSource1.DataMember = "TEKLI";
            this.tEKLIBindingSource1.DataSource = this.harflerDataSet3;
            // 
            // tEKLITableAdapter1
            // 
            this.tEKLITableAdapter1.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 399);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "TEK HARF";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.harflerDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEKLIBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private harflerDataSet2 harflerDataSet2;
        private System.Windows.Forms.BindingSource tEKLIBindingSource;
        private harflerDataSet2TableAdapters.TEKLITableAdapter tEKLITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hARFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLASILIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private harflerDataSet3 harflerDataSet3;
        private System.Windows.Forms.BindingSource tEKLIBindingSource1;
        private harflerDataSet3TableAdapters.TEKLITableAdapter tEKLITableAdapter1;
    }
}