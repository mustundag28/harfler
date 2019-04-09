namespace HARFLER
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.hARF1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hARF2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oLASILIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iKILIBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.harflerDataSet1 = new HARFLER.harflerDataSet1();
            this.iKILITableAdapter1 = new HARFLER.harflerDataSet1TableAdapters.IKILITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iKILIBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harflerDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "OKU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 441);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(427, 32);
            this.textBox2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 19);
            this.button2.TabIndex = 4;
            this.button2.Text = "DOSYA";
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
            this.oLASILIKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iKILIBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 387);
            this.dataGridView1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(409, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 20);
            this.button3.TabIndex = 6;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
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
            // oLASILIKDataGridViewTextBoxColumn
            // 
            this.oLASILIKDataGridViewTextBoxColumn.DataPropertyName = "OLASILIK";
            this.oLASILIKDataGridViewTextBoxColumn.HeaderText = "OLASILIK";
            this.oLASILIKDataGridViewTextBoxColumn.Name = "oLASILIKDataGridViewTextBoxColumn";
            // 
            // iKILIBindingSource1
            // 
            this.iKILIBindingSource1.DataMember = "IKILI";
            this.iKILIBindingSource1.DataSource = this.harflerDataSet1;
            // 
            // harflerDataSet1
            // 
            this.harflerDataSet1.DataSetName = "harflerDataSet1";
            this.harflerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iKILITableAdapter1
            // 
            this.iKILITableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 485);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "İKİLİ HARLER";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iKILIBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harflerDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private harflerDataSet1 harflerDataSet1;
        private System.Windows.Forms.BindingSource iKILIBindingSource1;
        private HARFLER.harflerDataSet1TableAdapters.IKILITableAdapter iKILITableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hARF1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hARF2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLASILIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}

