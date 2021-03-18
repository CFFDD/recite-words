namespace dbc_2
{
    partial class newwordstable
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
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newwordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdcDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdcDataSet = new dbc_2.bdcDataSet();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.userIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.txtuserID = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.newwordsTableAdapter = new dbc_2.bdcDataSetTableAdapters.NewwordsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newwordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.wordIDDataGridViewTextBoxColumn,
            this.stimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.newwordsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(336, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "userID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // wordIDDataGridViewTextBoxColumn
            // 
            this.wordIDDataGridViewTextBoxColumn.DataPropertyName = "wordID";
            this.wordIDDataGridViewTextBoxColumn.HeaderText = "wordID";
            this.wordIDDataGridViewTextBoxColumn.Name = "wordIDDataGridViewTextBoxColumn";
            // 
            // stimeDataGridViewTextBoxColumn
            // 
            this.stimeDataGridViewTextBoxColumn.DataPropertyName = "stime";
            this.stimeDataGridViewTextBoxColumn.HeaderText = "stime";
            this.stimeDataGridViewTextBoxColumn.Name = "stimeDataGridViewTextBoxColumn";
            // 
            // newwordsBindingSource
            // 
            this.newwordsBindingSource.DataMember = "Newwords";
            this.newwordsBindingSource.DataSource = this.bdcDataSetBindingSource;
            // 
            // bdcDataSetBindingSource
            // 
            this.bdcDataSetBindingSource.DataSource = this.bdcDataSet;
            this.bdcDataSetBindingSource.Position = 0;
            // 
            // bdcDataSet
            // 
            this.bdcDataSet.DataSetName = "bdcDataSet";
            this.bdcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userIDToolStripLabel,
            this.txtuserID,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(334, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // userIDToolStripLabel
            // 
            this.userIDToolStripLabel.Name = "userIDToolStripLabel";
            this.userIDToolStripLabel.Size = new System.Drawing.Size(49, 22);
            this.userIDToolStripLabel.Text = "userID:";
            // 
            // txtuserID
            // 
            this.txtuserID.Name = "txtuserID";
            this.txtuserID.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(36, 22);
            this.fillByToolStripButton.Text = "查询";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // newwordsTableAdapter
            // 
            this.newwordsTableAdapter.ClearBeforeFill = true;
            // 
            // newwordstable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 198);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "newwordstable";
            this.Text = "生词表视图";
            this.Load += new System.EventHandler(this.newwordsview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newwordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bdcDataSetBindingSource;
        private bdcDataSet bdcDataSet;
        private System.Windows.Forms.BindingSource newwordsBindingSource;
        private dbc_2.bdcDataSetTableAdapters.NewwordsTableAdapter newwordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel userIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox txtuserID;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}