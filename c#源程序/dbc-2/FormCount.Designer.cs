namespace dbc_2
{
    partial class FormCount
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
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countbwIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formCountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdcDataSet3 = new dbc_2.bdcDataSet3();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.bookIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.txtbookID = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.formCountTableAdapter = new dbc_2.bdcDataSet3TableAdapters.FormCountTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet3)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.countbwIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.formCountBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(244, 128);
            this.dataGridView1.TabIndex = 0;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "bookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "bookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            // 
            // countbwIDDataGridViewTextBoxColumn
            // 
            this.countbwIDDataGridViewTextBoxColumn.DataPropertyName = "count(bwID)";
            this.countbwIDDataGridViewTextBoxColumn.HeaderText = "count(bwID)";
            this.countbwIDDataGridViewTextBoxColumn.Name = "countbwIDDataGridViewTextBoxColumn";
            // 
            // formCountBindingSource
            // 
            this.formCountBindingSource.DataMember = "FormCount";
            this.formCountBindingSource.DataSource = this.bdcDataSet3;
            // 
            // bdcDataSet3
            // 
            this.bdcDataSet3.DataSetName = "bdcDataSet3";
            this.bdcDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookIDToolStripLabel,
            this.txtbookID,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(245, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // bookIDToolStripLabel
            // 
            this.bookIDToolStripLabel.Name = "bookIDToolStripLabel";
            this.bookIDToolStripLabel.Size = new System.Drawing.Size(55, 22);
            this.bookIDToolStripLabel.Text = "bookID:";
            // 
            // txtbookID
            // 
            this.txtbookID.Enabled = false;
            this.txtbookID.Name = "txtbookID";
            this.txtbookID.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(41, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // formCountTableAdapter
            // 
            this.formCountTableAdapter.ClearBeforeFill = true;
            // 
            // FormCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 155);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCount";
            this.Text = "FormCount";
            this.Load += new System.EventHandler(this.FormCount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet3)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bdcDataSet3 bdcDataSet3;
        private System.Windows.Forms.BindingSource formCountBindingSource;
        private dbc_2.bdcDataSet3TableAdapters.FormCountTableAdapter formCountTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel bookIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox txtbookID;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countbwIDDataGridViewTextBoxColumn;
    }
}