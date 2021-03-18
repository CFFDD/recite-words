namespace dbc_2
{
    partial class FormView
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
            this.wordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bwIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdcDataSet3 = new dbc_2.bdcDataSet3();
            this.fillByToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.bookIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.txtbookID = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.formViewTableAdapter = new dbc_2.bdcDataSet3TableAdapters.FormViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet3)).BeginInit();
            this.fillByToolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.wordIDDataGridViewTextBoxColumn,
            this.bwIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.formViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(341, 127);
            this.dataGridView1.TabIndex = 0;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "bookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "bookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            // 
            // wordIDDataGridViewTextBoxColumn
            // 
            this.wordIDDataGridViewTextBoxColumn.DataPropertyName = "wordID";
            this.wordIDDataGridViewTextBoxColumn.HeaderText = "wordID";
            this.wordIDDataGridViewTextBoxColumn.Name = "wordIDDataGridViewTextBoxColumn";
            // 
            // bwIDDataGridViewTextBoxColumn
            // 
            this.bwIDDataGridViewTextBoxColumn.DataPropertyName = "bwID";
            this.bwIDDataGridViewTextBoxColumn.HeaderText = "bwID";
            this.bwIDDataGridViewTextBoxColumn.Name = "bwIDDataGridViewTextBoxColumn";
            // 
            // formViewBindingSource
            // 
            this.formViewBindingSource.DataMember = "FormView";
            this.formViewBindingSource.DataSource = this.bdcDataSet3;
            // 
            // bdcDataSet3
            // 
            this.bdcDataSet3.DataSetName = "bdcDataSet3";
            this.bdcDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip2
            // 
            this.fillByToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookIDToolStripLabel,
            this.txtbookID,
            this.fillBy2ToolStripButton});
            this.fillByToolStrip2.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip2.Name = "fillByToolStrip2";
            this.fillByToolStrip2.Size = new System.Drawing.Size(343, 25);
            this.fillByToolStrip2.TabIndex = 1;
            this.fillByToolStrip2.Text = "fillBy2ToolStrip";
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
            // fillBy2ToolStripButton
            // 
            this.fillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy2ToolStripButton.Name = "fillBy2ToolStripButton";
            this.fillBy2ToolStripButton.Size = new System.Drawing.Size(48, 22);
            this.fillBy2ToolStripButton.Text = "FillBy2";
            this.fillBy2ToolStripButton.Click += new System.EventHandler(this.fillBy2ToolStripButton_Click);
            // 
            // formViewTableAdapter
            // 
            this.formViewTableAdapter.ClearBeforeFill = true;
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 155);
            this.Controls.Add(this.fillByToolStrip2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormView";
            this.Text = "FormView";
            this.Load += new System.EventHandler(this.FormView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet3)).EndInit();
            this.fillByToolStrip2.ResumeLayout(false);
            this.fillByToolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bdcDataSet3 bdcDataSet3;
        private System.Windows.Forms.BindingSource formViewBindingSource;
        private dbc_2.bdcDataSet3TableAdapters.FormViewTableAdapter formViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bwIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip2;
        private System.Windows.Forms.ToolStripLabel bookIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox txtbookID;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton;


    }
}