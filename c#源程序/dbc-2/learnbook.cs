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
    public partial class learnbook : Form
    {
        public learnbook()
        {
            InitializeComponent();
        }
        public learnbook(string str)
        {
            InitializeComponent();
            userIDToolStripTextBox.Text = str;
            userIDToolStripTextBox1.Text = str;
        }

        private void learnbook_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bdcDataSet7.ledbookCOUNT_3”中。您可以根据需要移动或移除它。
            this.ledbookCOUNT_3TableAdapter.Fill(this.bdcDataSet7.ledbookCOUNT_3);
            // TODO: 这行代码将数据加载到表“bdcDataSet6.ledbookview_3”中。您可以根据需要移动或移除它。
            this.ledbookview_3TableAdapter.Fill(this.bdcDataSet6.ledbookview_3);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ledbookview_3TableAdapter.FillBy(this.bdcDataSet6.ledbookview_3, userIDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.ledbookCOUNT_3TableAdapter.FillBy(this.bdcDataSet7.ledbookCOUNT_3, userIDToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
