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
    public partial class FormView : Form
    {
        public FormView()
        {
            InitializeComponent();
        }

        public FormView(string str)
        {
            InitializeComponent();
            txtbookID.Text = str;
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bdcDataSet3.FormView”中。您可以根据需要移动或移除它。
            this.formViewTableAdapter.Fill(this.bdcDataSet3.FormView);

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.formViewTableAdapter.FillBy2(this.bdcDataSet3.FormView, txtbookID.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


    }
}
