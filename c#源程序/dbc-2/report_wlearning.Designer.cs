namespace dbc_2
{
    partial class report_wlearning
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
            this.wlearningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wlearningTableAdapter = new dbc_2.bdcDataSet8TableAdapters.wlearningTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wlearningBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "bdcDataSet8_wlearning";
            reportDataSource1.Value = this.wlearningBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dbc_2.Report_wlearning.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(541, 249);
            this.reportViewer1.TabIndex = 0;
            // 
            // bdcDataSet8
            // 
            this.bdcDataSet8.DataSetName = "bdcDataSet8";
            this.bdcDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wlearningBindingSource
            // 
            this.wlearningBindingSource.DataMember = "wlearning";
            this.wlearningBindingSource.DataSource = this.bdcDataSet8;
            // 
            // wlearningTableAdapter
            // 
            this.wlearningTableAdapter.ClearBeforeFill = true;
            // 
            // report_wlearning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 253);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report_wlearning";
            this.Text = "report_wlearningcs";
            this.Load += new System.EventHandler(this.report_wlearning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wlearningBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource wlearningBindingSource;
        private bdcDataSet8 bdcDataSet8;
        private dbc_2.bdcDataSet8TableAdapters.wlearningTableAdapter wlearningTableAdapter;
    }
}