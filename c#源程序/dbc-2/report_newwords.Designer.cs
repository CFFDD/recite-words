namespace dbc_2
{
    partial class report_newwords
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bdcDataSet8 = new dbc_2.bdcDataSet8();
            this.NewwordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NewwordsTableAdapter = new dbc_2.bdcDataSet8TableAdapters.NewwordsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewwordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "bdcDataSet8_Newwords";
            reportDataSource1.Value = this.NewwordsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dbc_2.Report_newwords.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(400, 250);
            this.reportViewer1.TabIndex = 0;
            // 
            // bdcDataSet8
            // 
            this.bdcDataSet8.DataSetName = "bdcDataSet8";
            this.bdcDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NewwordsBindingSource
            // 
            this.NewwordsBindingSource.DataMember = "Newwords";
            this.NewwordsBindingSource.DataSource = this.bdcDataSet8;
            // 
            // NewwordsTableAdapter
            // 
            this.NewwordsTableAdapter.ClearBeforeFill = true;
            // 
            // report_newwprds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 253);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report_newwprds";
            this.Text = "report_newwprds";
            this.Load += new System.EventHandler(this.report_newwprds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewwordsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NewwordsBindingSource;
        private bdcDataSet8 bdcDataSet8;
        private dbc_2.bdcDataSet8TableAdapters.NewwordsTableAdapter NewwordsTableAdapter;
    }
}