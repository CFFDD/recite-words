using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dbc_2
{
    public partial class report_learning : Form
    {
        public report_learning()
        {
            InitializeComponent();
        }

        private void report_learning_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bdcDataSet9.Learning”中。您可以根据需要移动或移除它。
            this.LearningTableAdapter.Fill(this.bdcDataSet9.Learning);

            this.reportViewer1.RefreshReport();
        }
    }
}
