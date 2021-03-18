namespace dbc_2
{
    partial class wordlist
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bdcDataSet8 = new dbc_2.bdcDataSet8();
            this.wordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wordTableAdapter = new dbc_2.bdcDataSet8TableAdapters.wordTableAdapter();
            this.wordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.similarwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.explanation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordIDDataGridViewTextBoxColumn,
            this.wordnameDataGridViewTextBoxColumn,
            this.similarwordDataGridViewTextBoxColumn,
            this.explanation});
            this.dataGridView1.DataSource = this.wordBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(439, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // bdcDataSet8
            // 
            this.bdcDataSet8.DataSetName = "bdcDataSet8";
            this.bdcDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wordBindingSource
            // 
            this.wordBindingSource.DataMember = "word";
            this.wordBindingSource.DataSource = this.bdcDataSet8;
            // 
            // wordTableAdapter
            // 
            this.wordTableAdapter.ClearBeforeFill = true;
            // 
            // wordIDDataGridViewTextBoxColumn
            // 
            this.wordIDDataGridViewTextBoxColumn.DataPropertyName = "wordID";
            this.wordIDDataGridViewTextBoxColumn.HeaderText = "wordID";
            this.wordIDDataGridViewTextBoxColumn.Name = "wordIDDataGridViewTextBoxColumn";
            // 
            // wordnameDataGridViewTextBoxColumn
            // 
            this.wordnameDataGridViewTextBoxColumn.DataPropertyName = "wordname";
            this.wordnameDataGridViewTextBoxColumn.HeaderText = "wordname";
            this.wordnameDataGridViewTextBoxColumn.Name = "wordnameDataGridViewTextBoxColumn";
            // 
            // similarwordDataGridViewTextBoxColumn
            // 
            this.similarwordDataGridViewTextBoxColumn.DataPropertyName = "Similarword";
            this.similarwordDataGridViewTextBoxColumn.HeaderText = "Similarword";
            this.similarwordDataGridViewTextBoxColumn.Name = "similarwordDataGridViewTextBoxColumn";
            // 
            // explanation
            // 
            this.explanation.DataPropertyName = "explanation";
            this.explanation.HeaderText = "explanation";
            this.explanation.Name = "explanation";
            // 
            // wordlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 147);
            this.Controls.Add(this.dataGridView1);
            this.Name = "wordlist";
            this.Text = "wordlist";
            this.Load += new System.EventHandler(this.wordlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bdcDataSet8 bdcDataSet8;
        private System.Windows.Forms.BindingSource wordBindingSource;
        private dbc_2.bdcDataSet8TableAdapters.wordTableAdapter wordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn similarwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn explanation;
    }
}