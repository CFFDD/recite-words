namespace dbc_2
{
    partial class wlearning
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
            this.learned = new System.Windows.Forms.Button();
            this.formBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdcDataSet = new dbc_2.bdcDataSet();
            this.wordBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wordTableAdapter = new dbc_2.bdcDataSetTableAdapters.wordTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.wordname = new System.Windows.Forms.Label();
            this.Bphonetic = new System.Windows.Forms.Label();
            this.Uphonetic = new System.Windows.Forms.Label();
            this.explanation = new System.Windows.Forms.Label();
            this.Similarword = new System.Windows.Forms.Label();
            this.Cexample = new System.Windows.Forms.Label();
            this.Eexample = new System.Windows.Forms.Label();
            this.root1 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.addtonewword = new System.Windows.Forms.Button();
            this.bwID = new System.Windows.Forms.Label();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.formTableAdapter = new dbc_2.bdcDataSetTableAdapters.FormTableAdapter();
            this.bdcDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fillBy2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.onebookIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.txtbookID = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillBy2ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.onewordIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.txtwordID = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy2ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.wordID = new System.Windows.Forms.Label();
            this.txtuserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource1)).BeginInit();
            this.fillBy2ToolStrip.SuspendLayout();
            this.fillBy2ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // learned
            // 
            this.learned.Location = new System.Drawing.Point(578, 367);
            this.learned.Name = "learned";
            this.learned.Size = new System.Drawing.Size(75, 23);
            this.learned.TabIndex = 0;
            this.learned.Text = "已学习";
            this.learned.UseVisualStyleBackColor = true;
            this.learned.Click += new System.EventHandler(this.learned_Click);
            // 
            // formBindingSource
            // 
            this.formBindingSource.DataMember = "Form";
            this.formBindingSource.DataSource = this.bdcDataSet;
            // 
            // bdcDataSet
            // 
            this.bdcDataSet.DataSetName = "bdcDataSet";
            this.bdcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wordBindingSource1
            // 
            this.wordBindingSource1.DataMember = "word";
            this.wordBindingSource1.DataSource = this.bdcDataSet;
            // 
            // wordBindingSource
            // 
            this.wordBindingSource.DataMember = "word";
            this.wordBindingSource.DataSource = this.bdcDataSet;
            // 
            // wordTableAdapter
            // 
            this.wordTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.wordBindingSource1;
            this.comboBox2.DisplayMember = "wordname";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(325, 120);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "wordname";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.wordBindingSource1;
            this.comboBox3.DisplayMember = "Bphonetic";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(104, 154);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.ValueMember = "Bphonetic";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.wordBindingSource1;
            this.comboBox4.DisplayMember = "Eexample";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(104, 269);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(534, 20);
            this.comboBox4.TabIndex = 4;
            this.comboBox4.ValueMember = "Eexample";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.wordBindingSource1;
            this.comboBox5.DisplayMember = "root1";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(104, 239);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(534, 20);
            this.comboBox5.TabIndex = 5;
            this.comboBox5.ValueMember = "root1";
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.wordBindingSource1;
            this.comboBox6.DisplayMember = "Similarword";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(104, 203);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(534, 20);
            this.comboBox6.TabIndex = 6;
            this.comboBox6.ValueMember = "Similarword";
            // 
            // wordname
            // 
            this.wordname.AutoSize = true;
            this.wordname.Location = new System.Drawing.Point(290, 128);
            this.wordname.Name = "wordname";
            this.wordname.Size = new System.Drawing.Size(29, 12);
            this.wordname.TabIndex = 8;
            this.wordname.Text = "单词";
            // 
            // Bphonetic
            // 
            this.Bphonetic.AutoSize = true;
            this.Bphonetic.Location = new System.Drawing.Point(32, 157);
            this.Bphonetic.Name = "Bphonetic";
            this.Bphonetic.Size = new System.Drawing.Size(53, 12);
            this.Bphonetic.TabIndex = 9;
            this.Bphonetic.Text = "英式音标";
            // 
            // Uphonetic
            // 
            this.Uphonetic.AutoSize = true;
            this.Uphonetic.Location = new System.Drawing.Point(265, 154);
            this.Uphonetic.Name = "Uphonetic";
            this.Uphonetic.Size = new System.Drawing.Size(53, 12);
            this.Uphonetic.TabIndex = 10;
            this.Uphonetic.Text = "美式音标";
            // 
            // explanation
            // 
            this.explanation.AutoSize = true;
            this.explanation.Location = new System.Drawing.Point(31, 317);
            this.explanation.Name = "explanation";
            this.explanation.Size = new System.Drawing.Size(53, 12);
            this.explanation.TabIndex = 11;
            this.explanation.Text = "双语释义";
            // 
            // Similarword
            // 
            this.Similarword.AutoSize = true;
            this.Similarword.Location = new System.Drawing.Point(44, 206);
            this.Similarword.Name = "Similarword";
            this.Similarword.Size = new System.Drawing.Size(41, 12);
            this.Similarword.TabIndex = 12;
            this.Similarword.Text = "相近词";
            // 
            // Cexample
            // 
            this.Cexample.AutoSize = true;
            this.Cexample.Location = new System.Drawing.Point(32, 300);
            this.Cexample.Name = "Cexample";
            this.Cexample.Size = new System.Drawing.Size(53, 12);
            this.Cexample.TabIndex = 14;
            this.Cexample.Text = "例句释义";
            // 
            // Eexample
            // 
            this.Eexample.AutoSize = true;
            this.Eexample.Location = new System.Drawing.Point(32, 272);
            this.Eexample.Name = "Eexample";
            this.Eexample.Size = new System.Drawing.Size(53, 12);
            this.Eexample.TabIndex = 15;
            this.Eexample.Text = "英文例句";
            // 
            // root1
            // 
            this.root1.AutoSize = true;
            this.root1.Location = new System.Drawing.Point(32, 242);
            this.root1.Name = "root1";
            this.root1.Size = new System.Drawing.Size(53, 12);
            this.root1.TabIndex = 16;
            this.root1.Text = "词根词缀";
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.wordBindingSource1;
            this.comboBox7.DisplayMember = "explanation";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(104, 322);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(534, 20);
            this.comboBox7.TabIndex = 17;
            this.comboBox7.ValueMember = "explanation";
            // 
            // comboBox8
            // 
            this.comboBox8.DataSource = this.wordBindingSource1;
            this.comboBox8.DisplayMember = "Uphonetic";
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(325, 146);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 20);
            this.comboBox8.TabIndex = 18;
            this.comboBox8.ValueMember = "Uphonetic";
            // 
            // comboBox9
            // 
            this.comboBox9.DataSource = this.wordBindingSource1;
            this.comboBox9.DisplayMember = "Cexample";
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(104, 297);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(534, 20);
            this.comboBox9.TabIndex = 19;
            this.comboBox9.ValueMember = "Cexample";
            // 
            // addtonewword
            // 
            this.addtonewword.Location = new System.Drawing.Point(468, 367);
            this.addtonewword.Name = "addtonewword";
            this.addtonewword.Size = new System.Drawing.Size(75, 23);
            this.addtonewword.TabIndex = 20;
            this.addtonewword.Text = "更新生词表";
            this.addtonewword.UseVisualStyleBackColor = true;
            this.addtonewword.Click += new System.EventHandler(this.addtonewword_Click);
            // 
            // bwID
            // 
            this.bwID.AutoSize = true;
            this.bwID.Location = new System.Drawing.Point(20, 86);
            this.bwID.Name = "bwID";
            this.bwID.Size = new System.Drawing.Size(65, 12);
            this.bwID.TabIndex = 21;
            this.bwID.Text = "词书单词ID";
            // 
            // comboBox10
            // 
            this.comboBox10.DataSource = this.formBindingSource;
            this.comboBox10.DisplayMember = "bwID";
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(104, 83);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(121, 20);
            this.comboBox10.TabIndex = 22;
            this.comboBox10.ValueMember = "bwID";
            // 
            // formTableAdapter
            // 
            this.formTableAdapter.ClearBeforeFill = true;
            // 
            // bdcDataSetBindingSource
            // 
            this.bdcDataSetBindingSource.DataSource = this.bdcDataSet;
            this.bdcDataSetBindingSource.Position = 0;
            // 
            // formBindingSource1
            // 
            this.formBindingSource1.DataMember = "Form";
            this.formBindingSource1.DataSource = this.bdcDataSetBindingSource;
            // 
            // fillBy2ToolStrip
            // 
            this.fillBy2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onebookIDToolStripLabel,
            this.txtbookID,
            this.fillBy2ToolStripButton});
            this.fillBy2ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy2ToolStrip.Name = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Size = new System.Drawing.Size(665, 25);
            this.fillBy2ToolStrip.TabIndex = 23;
            this.fillBy2ToolStrip.Text = "fillBy2ToolStrip";
            // 
            // onebookIDToolStripLabel
            // 
            this.onebookIDToolStripLabel.Name = "onebookIDToolStripLabel";
            this.onebookIDToolStripLabel.Size = new System.Drawing.Size(141, 22);
            this.onebookIDToolStripLabel.Text = "请输入要学习的词书ID：";
            // 
            // txtbookID
            // 
            this.txtbookID.Name = "txtbookID";
            this.txtbookID.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy2ToolStripButton
            // 
            this.fillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy2ToolStripButton.Name = "fillBy2ToolStripButton";
            this.fillBy2ToolStripButton.Size = new System.Drawing.Size(36, 22);
            this.fillBy2ToolStripButton.Text = "开始";
            this.fillBy2ToolStripButton.Click += new System.EventHandler(this.fillBy2ToolStripButton_Click);
            // 
            // fillBy2ToolStrip1
            // 
            this.fillBy2ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onewordIDToolStripLabel,
            this.txtwordID,
            this.fillBy2ToolStripButton1});
            this.fillBy2ToolStrip1.Location = new System.Drawing.Point(0, 25);
            this.fillBy2ToolStrip1.Name = "fillBy2ToolStrip1";
            this.fillBy2ToolStrip1.Size = new System.Drawing.Size(665, 25);
            this.fillBy2ToolStrip1.TabIndex = 24;
            this.fillBy2ToolStrip1.Text = "fillBy2ToolStrip1";
            // 
            // onewordIDToolStripLabel
            // 
            this.onewordIDToolStripLabel.Name = "onewordIDToolStripLabel";
            this.onewordIDToolStripLabel.Size = new System.Drawing.Size(141, 22);
            this.onewordIDToolStripLabel.Text = "请输入要学习的单词ID：";
            // 
            // txtwordID
            // 
            this.txtwordID.Name = "txtwordID";
            this.txtwordID.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy2ToolStripButton1
            // 
            this.fillBy2ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy2ToolStripButton1.Name = "fillBy2ToolStripButton1";
            this.fillBy2ToolStripButton1.Size = new System.Drawing.Size(36, 22);
            this.fillBy2ToolStripButton1.Text = "开始";
            this.fillBy2ToolStripButton1.Click += new System.EventHandler(this.fillBy2ToolStripButton1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.formBindingSource;
            this.comboBox1.DisplayMember = "wordID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // wordID
            // 
            this.wordID.AutoSize = true;
            this.wordID.Location = new System.Drawing.Point(44, 123);
            this.wordID.Name = "wordID";
            this.wordID.Size = new System.Drawing.Size(41, 12);
            this.wordID.TabIndex = 7;
            this.wordID.Text = "单词ID";
            // 
            // txtuserID
            // 
            this.txtuserID.Enabled = false;
            this.txtuserID.Location = new System.Drawing.Point(553, 25);
            this.txtuserID.Name = "txtuserID";
            this.txtuserID.Size = new System.Drawing.Size(100, 21);
            this.txtuserID.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "用户ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "查看学习记录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 39);
            this.button2.TabIndex = 28;
            this.button2.Text = "检测书中是否存在该单词";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(549, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 29;
            // 
            // wlearning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 402);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtuserID);
            this.Controls.Add(this.fillBy2ToolStrip1);
            this.Controls.Add(this.fillBy2ToolStrip);
            this.Controls.Add(this.comboBox10);
            this.Controls.Add(this.bwID);
            this.Controls.Add(this.addtonewword);
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.root1);
            this.Controls.Add(this.Eexample);
            this.Controls.Add(this.Cexample);
            this.Controls.Add(this.Similarword);
            this.Controls.Add(this.explanation);
            this.Controls.Add(this.Uphonetic);
            this.Controls.Add(this.Bphonetic);
            this.Controls.Add(this.wordname);
            this.Controls.Add(this.wordID);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.learned);
            this.Name = "wlearning";
            this.Text = "词书单词学习";
            this.Load += new System.EventHandler(this.wlearning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource1)).EndInit();
            this.fillBy2ToolStrip.ResumeLayout(false);
            this.fillBy2ToolStrip.PerformLayout();
            this.fillBy2ToolStrip1.ResumeLayout(false);
            this.fillBy2ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button learned;
        private bdcDataSet bdcDataSet;
        private System.Windows.Forms.BindingSource wordBindingSource;
        private dbc_2.bdcDataSetTableAdapters.wordTableAdapter wordTableAdapter;
        private System.Windows.Forms.BindingSource wordBindingSource1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label wordname;
        private System.Windows.Forms.Label Bphonetic;
        private System.Windows.Forms.Label Uphonetic;
        private System.Windows.Forms.Label explanation;
        private System.Windows.Forms.Label Similarword;
        private System.Windows.Forms.Label Cexample;
        private System.Windows.Forms.Label Eexample;
        private System.Windows.Forms.Label root1;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Button addtonewword;
        private System.Windows.Forms.Label bwID;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.BindingSource formBindingSource;
        private dbc_2.bdcDataSetTableAdapters.FormTableAdapter formTableAdapter;
        private System.Windows.Forms.BindingSource bdcDataSetBindingSource;
        private System.Windows.Forms.BindingSource formBindingSource1;
        private System.Windows.Forms.ToolStrip fillBy2ToolStrip;
        private System.Windows.Forms.ToolStripLabel onebookIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox txtbookID;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton;
        private System.Windows.Forms.ToolStrip fillBy2ToolStrip1;
        private System.Windows.Forms.ToolStripLabel onewordIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox txtwordID;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label wordID;
        private System.Windows.Forms.TextBox txtuserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}