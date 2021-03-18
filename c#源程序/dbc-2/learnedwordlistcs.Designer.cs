namespace dbc_2
{
    partial class learnedwordlistcs
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
            this.wordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ledwlistview2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdcDataSet4 = new dbc_2.bdcDataSet4();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.userIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.userIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ledwlistview_2TableAdapter = new dbc_2.bdcDataSet4TableAdapters.ledwlistview_2TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ledwcountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdcDataSet5 = new dbc_2.bdcDataSet5();
            this.ledwcountTableAdapter = new dbc_2.bdcDataSet5TableAdapters.ledwcountTableAdapter();
            this.fillByToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.userIDToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.userIDToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledwlistview2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet4)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledwcountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet5)).BeginInit();
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
            this.wordIDDataGridViewTextBoxColumn,
            this.wordnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ledwlistview2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(437, 150);
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
            // ledwlistview2BindingSource
            // 
            this.ledwlistview2BindingSource.DataMember = "ledwlistview_2";
            this.ledwlistview2BindingSource.DataSource = this.bdcDataSet4;
            // 
            // bdcDataSet4
            // 
            this.bdcDataSet4.DataSetName = "bdcDataSet4";
            this.bdcDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userIDToolStripLabel,
            this.userIDToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(433, 25);
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
            this.fillByToolStripButton.Size = new System.Drawing.Size(144, 22);
            this.fillByToolStripButton.Text = "查询所有书中已学习单词";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // ledwlistview_2TableAdapter
            // 
            this.ledwlistview_2TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "累计学习词数统计";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.ledwcountBindingSource;
            this.comboBox1.DisplayMember = "count(wordID)";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "count(wordID)";
            // 
            // ledwcountBindingSource
            // 
            this.ledwcountBindingSource.DataMember = "ledwcount";
            this.ledwcountBindingSource.DataSource = this.bdcDataSet5;
            // 
            // bdcDataSet5
            // 
            this.bdcDataSet5.DataSetName = "bdcDataSet5";
            this.bdcDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ledwcountTableAdapter
            // 
            this.ledwcountTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip1
            // 
            this.fillByToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userIDToolStripLabel1,
            this.userIDToolStripTextBox1,
            this.fillByToolStripButton1});
            this.fillByToolStrip1.Location = new System.Drawing.Point(0, 25);
            this.fillByToolStrip1.Name = "fillByToolStrip1";
            this.fillByToolStrip1.Size = new System.Drawing.Size(433, 25);
            this.fillByToolStrip1.TabIndex = 4;
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
            this.fillByToolStripButton1.Size = new System.Drawing.Size(144, 22);
            this.fillByToolStripButton1.Text = "所有书中已学习单词统计";
            this.fillByToolStripButton1.Click += new System.EventHandler(this.fillByToolStripButton1_Click);
            // 
            // learnedwordlistcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 256);
            this.Controls.Add(this.fillByToolStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "learnedwordlistcs";
            this.Text = "已学习单词";
            this.Load += new System.EventHandler(this.learnedwordlistcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledwlistview2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet4)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledwcountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet5)).EndInit();
            this.fillByToolStrip1.ResumeLayout(false);
            this.fillByToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bdcDataSet4 bdcDataSet4;
        private System.Windows.Forms.BindingSource ledwlistview2BindingSource;
        private dbc_2.bdcDataSet4TableAdapters.ledwlistview_2TableAdapter ledwlistview_2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel userIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox userIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private bdcDataSet5 bdcDataSet5;
        private System.Windows.Forms.BindingSource ledwcountBindingSource;
        private dbc_2.bdcDataSet5TableAdapters.ledwcountTableAdapter ledwcountTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip1;
        private System.Windows.Forms.ToolStripLabel userIDToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox userIDToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton1;


    }
}