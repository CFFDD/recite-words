namespace dbc_2
{
    partial class report_word
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.wordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdcDataSet = new dbc_2.bdcDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new dbc_2.bdcDataSetTableAdapters.bookTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.wordTableAdapter = new dbc_2.bdcDataSetTableAdapters.wordTableAdapter();
            this.bdcDataSet8 = new dbc_2.bdcDataSet8();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // wordBindingSource
            // 
            this.wordBindingSource.DataMember = "word";
            this.wordBindingSource.DataSource = this.bdcDataSet;
            // 
            // bdcDataSet
            // 
            this.bdcDataSet.DataSetName = "bdcDataSet";
            this.bdcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.bdcDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "bdcDataSet8_word";
            reportDataSource1.Value = this.wordBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dbc_2.Report_word.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(755, 272);
            this.reportViewer1.TabIndex = 0;
            // 
            // wordTableAdapter
            // 
            this.wordTableAdapter.ClearBeforeFill = true;
            // 
            // bdcDataSet8
            // 
            this.bdcDataSet8.DataSetName = "bdcDataSet8";
            this.bdcDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report_word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 283);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report_word";
            this.Text = "report_word";
            this.Load += new System.EventHandler(this.report_book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bookBindingSource;
        private bdcDataSet bdcDataSet;
        private dbc_2.bdcDataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource wordBindingSource;
        private dbc_2.bdcDataSetTableAdapters.wordTableAdapter wordTableAdapter;
        private bdcDataSet8 bdcDataSet8;
    }
}