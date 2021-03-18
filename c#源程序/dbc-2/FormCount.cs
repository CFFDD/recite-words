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
    public partial class FormCount : Form
    {
        public FormCount()
        {
            InitializeComponent();
        }
        public FormCount(string str)
        {
            InitializeComponent();
            txtbookID.Text = str;
        }

        private void FormCount_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bdcDataSet3.FormCount”中。您可以根据需要移动或移除它。
            this.formCountTableAdapter.Fill(this.bdcDataSet3.FormCount);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.formCountTableAdapter.FillBy(this.bdcDataSet3.FormCount, txtbookID.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
