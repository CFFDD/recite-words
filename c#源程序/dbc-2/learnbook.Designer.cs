namespace dbc_2
{
    partial class learnbook
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
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.已学习单词数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ledbookview3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdcDataSet6 = new dbc_2.bdcDataSet6();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.userIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.userIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ledbookview_3TableAdapter = new dbc_2.bdcDataSet6TableAdapters.ledbookview_3TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ledbookCOUNT3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdcDataSet7 = new dbc_2.bdcDataSet7();
            this.ledbookCOUNT_3TableAdapter = new dbc_2.bdcDataSet7TableAdapters.ledbookCOUNT_3TableAdapter();
            this.fillByToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.userIDToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.userIDToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledbookview3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet6)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledbookCOUNT3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet7)).BeginInit();
            this.fillByToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn,
            this.booknameDataGridViewTextBoxColumn,
            this.已学习单词数DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ledbookview3BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(439, 112);
            this.dataGridView1.TabIndex = 0;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "userID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "bookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "bookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            // 
            // booknameDataGridViewTextBoxColumn
            // 
            this.booknameDataGridViewTextBoxColumn.DataPropertyName = "bookname";
            this.booknameDataGridViewTextBoxColumn.HeaderText = "bookname";
            this.booknameDataGridViewTextBoxColumn.Name = "booknameDataGridViewTextBoxColumn";
            // 
            // 已学习单词数DataGridViewTextBoxColumn
            // 
            this.已学习单词数DataGridViewTextBoxColumn.DataPropertyName = "已学习单词数";
            this.已学习单词数DataGridViewTextBoxColumn.HeaderText = "已学习单词数";
            this.已学习单词数DataGridViewTextBoxColumn.Name = "已学习单词数DataGridViewTextBoxColumn";
            // 
            // ledbookview3BindingSource
            // 
            this.ledbookview3BindingSource.DataMember = "ledbookview_3";
            this.ledbookview3BindingSource.DataSource = this.bdcDataSet6;
            // 
            // bdcDataSet6
            // 
            this.bdcDataSet6.DataSetName = "bdcDataSet6";
            this.bdcDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userIDToolStripLabel,
            this.userIDToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(463, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // userIDToolStripLabel
            // 
            this.userIDToolStripLabel.Name = "userIDToolStripLabel";
            this.userIDToolStripLabel.Size = new System.Drawing.Size(49, 22);
            this.userIDToolStripLabel.Text = "userID:";
            // 
            // userIDToolStripTextBox
            // 
            this.userIDToolStripTextBox.Enabled = false;
            this.userIDToolStripTextBox.Name = "userIDToolStripTextBox";
            this.userIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(36, 22);
            this.fillByToolStripButton.Text = "查询";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // ledbookview_3TableAdapter
            // 
            this.ledbookview_3TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "已学习词书数统计";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.ledbookCOUNT3BindingSource;
            this.comboBox1.DisplayMember = "已学习词书数";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "已学习词书数";
            // 
            // ledbookCOUNT3BindingSource
            // 
            this.ledbookCOUNT3BindingSource.DataMember = "ledbookCOUNT_3";
            this.ledbookCOUNT3BindingSource.DataSource = this.bdcDataSet7;
            // 
            // bdcDataSet7
            // 
            this.bdcDataSet7.DataSetName = "bdcDataSet7";
            this.bdcDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ledbookCOUNT_3TableAdapter
            // 
            this.ledbookCOUNT_3TableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip1
            // 
            this.fillByToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userIDToolStripLabel1,
            this.userIDToolStripTextBox1,
            this.fillByToolStripButton1});
            this.fillByToolStrip1.Location = new System.Drawing.Point(0, 25);
            this.fillByToolStrip1.Name = "fillByToolStrip1";
            this.fillByToolStrip1.Size = new System.Drawing.Size(463, 25);
            this.fillByToolStrip1.TabIndex = 5;
            this.fillByToolStrip1.Text = "fillByToolStrip1";
            // 
            // userIDToolStripLabel1
            // 
            this.userIDToolStripLabel1.Name = "userIDToolStripLabel1";
            this.userIDToolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.userIDToolStripLabel1.Text = "userID:";
            // 
            // userIDToolStripTextBox1
            // 
            this.userIDToolStripTextBox1.Enabled = false;
            this.userIDToolStripTextBox1.Name = "userIDToolStripTextBox1";
            this.userIDToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton1
            // 
            this.fillByToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton1.Name = "fillByToolStripButton1";
            this.fillByToolStripButton1.Size = new System.Drawing.Size(36, 22);
            this.fillByToolStripButton1.Text = "统计";
            this.fillByToolStripButton1.Click += new System.EventHandler(this.fillByToolStripButton1_Click);
            // 
            // learnbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 207);
            this.Controls.Add(this.fillByToolStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "learnbook";
            this.Text = "已学习词书";
            this.Load += new System.EventHandler(this.learnbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledbookview3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet6)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledbookCOUNT3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet7)).EndInit();
            this.fillByToolStrip1.ResumeLayout(false);
            this.fillByToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bdcDataSet6 bdcDataSet6;
        private System.Windows.Forms.BindingSource ledbookview3BindingSource;
        private dbc_2.bdcDataSet6TableAdapters.ledbookview_3TableAdapter ledbookview_3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 已学习单词数DataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel userIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox userIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private bdcDataSet7 bdcDataSet7;
        private System.Windows.Forms.BindingSource ledbookCOUNT3BindingSource;
        private dbc_2.bdcDataSet7TableAdapters.ledbookCOUNT_3TableAdapter ledbookCOUNT_3TableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip1;
        private System.Windows.Forms.ToolStripLabel userIDToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox userIDToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton1;
    }
}