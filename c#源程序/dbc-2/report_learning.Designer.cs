namespace dbc_2
{
    partial class report_learning
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
            this.bdcDataSet9 = new dbc_2.bdcDataSet9();
            this.LearningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LearningTableAdapter = new dbc_2.bdcDataSet9TableAdapters.LearningTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "bdcDataSet9_Learning";
            reportDataSource1.Value = this.LearningBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dbc_2.Report_learning.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(400, 250);
            this.reportViewer1.TabIndex = 0;
            // 
            // bdcDataSet9
            // 
            this.bdcDataSet9.DataSetName = "bdcDataSet9";
            this.bdcDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LearningBindingSource
            // 
            this.LearningBindingSource.DataMember = "Learning";
            this.LearningBindingSource.DataSource = this.bdcDataSet9;
            // 
            // LearningTableAdapter
            // 
            this.LearningTableAdapter.ClearBeforeFill = true;
            // 
            // report_learning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 253);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report_learning";
            this.Text = "report_learning";
            this.Load += new System.EventHandler(this.report_learning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdcDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LearningBindingSource;
        private bdcDataSet9 bdcDataSet9;
        private dbc_2.bdcDataSet9TableAdapters.LearningTableAdapter LearningTableAdapter;
    }
}