namespace HARFLER
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hARF1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hARF2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hARF3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oLASILIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uCLUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.harflerDataSet = new HARFLER.harflerDataSet();
            this.uCLUTableAdapter = new HARFLER.harflerDataSetTableAdapters.UCLUTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uCLUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harflerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "DOSYA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "OKU";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hARF1DataGridViewTextBoxColumn,
            this.hARF2DataGridViewTextBoxColumn,
            this.hARF3DataGridViewTextBoxColumn,
            this.oLASILIKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uCLUBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 444);
            this.dataGridView1.TabIndex = 3;
            // 
            // hARF1DataGridViewTextBoxColumn
            // 
            this.hARF1DataGridViewTextBoxColumn.DataPropertyName = "HARF1";
            this.hARF1DataGridViewTextBoxColumn.HeaderText = "HARF1";
            this.hARF1DataGridViewTextBoxColumn.Name = "hARF1DataGridViewTextBoxColumn";
            // 
            // hARF2DataGridViewTextBoxColumn
            // 
            this.hARF2DataGridViewTextBoxColumn.DataPropertyName = "HARF2";
            this.hARF2DataGridViewTextBoxColumn.HeaderText = "HARF2";
            this.hARF2DataGridViewTextBoxColumn.Name = "hARF2DataGridViewTextBoxColumn";
            // 
            // hARF3DataGridViewTextBoxColumn
            // 
            this.hARF3DataGridViewTextBoxColumn.DataPropertyName = "HARF3";
            this.hARF3DataGridViewTextBoxColumn.HeaderText = "HARF3";
            this.hARF3DataGridViewTextBoxColumn.Name = "hARF3DataGridViewTextBoxColumn";
            // 
            // oLASILIKDataGridViewTextBoxColumn
            // 
            this.oLASILIKDataGridViewTextBoxColumn.DataPropertyName = "OLASILIK";
            this.oLASILIKDataGridViewTextBoxColumn.HeaderText = "OLASILIK";
            this.oLASILIKDataGridViewTextBoxColumn.Name = "oLASILIKDataGridViewTextBoxColumn";
            // 
            // uCLUBindingSource
            // 
            this.uCLUBindingSource.DataMember = "UCLU";
            this.uCLUBindingSource.DataSource = this.harflerDataSet;
            // 
            // harflerDataSet
            // 
            this.harflerDataSet.DataSetName = "harflerDataSet";
            this.harflerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uCLUTableAdapter
            // 
            this.uCLUTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 502);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(468, 42);
            this.textBox2.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(458, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 19);
            this.button3.TabIndex = 5;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 555);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "ÜÇLÜ HARFLER";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uCLUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harflerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private harflerDataSet harflerDataSet;
        private System.Windows.Forms.BindingSource uCLUBindingSource;
        private HARFLER.harflerDataSetTableAdapters.UCLUTableAdapter uCLUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hARF1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hARF2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hARF3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLASILIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
    }
}