using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dbc_2;
using Student2008;

namespace dbc_2
{
    public partial class selectwords : Form
    {
        public selectwords()
        {
            InitializeComponent();
        }
        public selectwords(string str1,string str2)
        {
            InitializeComponent();
            onebookIDToolStripTextBox.Text = str1;
            onewordIDToolStripTextBox.Text = str2;
        }

        private void selectwords_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bdcDataSet.Form”中。您可以根据需要移动或移除它。
            this.formTableAdapter.Fill(this.bdcDataSet.Form);
            // TODO: 这行代码将数据加载到表“bdcDataSet.word”中。您可以根据需要移动或移除它。
            this.wordTableAdapter.Fill(this.bdcDataSet.word);

        }



        private void fillBy2ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.formTableAdapter.FillBy2(this.bdcDataSet.Form, onebookIDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillBy2ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.wordTableAdapter.FillBy2(this.bdcDataSet.word, onewordIDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


    }
}
