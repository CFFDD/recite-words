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
    public partial class newwordstable : Form
    {
        public newwordstable()
        {
            InitializeComponent();
        }

        public newwordstable(string str)
        {
            InitializeComponent();
            txtuserID.Text = str;
        }



        private void newwordsview_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bdcDataSet.Newwords”中。您可以根据需要移动或移除它。
            this.newwordsTableAdapter.Fill(this.bdcDataSet.Newwords);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.newwordsTableAdapter.FillBy(this.bdcDataSet.Newwords, txtuserID.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    }
}
