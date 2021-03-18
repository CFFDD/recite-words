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
    public partial class learnedwordlistcs : Form
    {
        public learnedwordlistcs()
        {
            InitializeComponent();
        }
        public learnedwordlistcs(string str)
        {
            InitializeComponent();
            userIDToolStripTextBox.Text=str;
            userIDToolStripTextBox1.Text = str;

        }

        private void learnedwordlistcs_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bdcDataSet5.ledwcount”中。您可以根据需要移动或移除它。
            this.ledwcountTableAdapter.Fill(this.bdcDataSet5.ledwcount);
            // TODO: 这行代码将数据加载到表“bdcDataSet4.ledwlistview_2”中。您可以根据需要移动或移除它。
            this.ledwlistview_2TableAdapter.Fill(this.bdcDataSet4.ledwlistview_2);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ledwlistview_2TableAdapter.FillBy(this.bdcDataSet4.ledwlistview_2, userIDToolStripTextBox.Text);
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
                this.ledwcountTableAdapter.FillBy(this.bdcDataSet5.ledwcount, userIDToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
