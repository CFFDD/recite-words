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
    public partial class report_word : Form
    {
        public report_word()
        {
            InitializeComponent();
        }

        private void report_book_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bdcDataSet.word”中。您可以根据需要移动或移除它。
            this.wordTableAdapter.Fill(this.bdcDataSet.word);
            // TODO: 这行代码将数据加载到表“bdcDataSet.book”中。您可以根据需要移动或移除它。
            this.bookTableAdapter.Fill(this.bdcDataSet.book);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
