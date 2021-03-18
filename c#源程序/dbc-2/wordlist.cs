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
    public partial class wordlist : Form
    {
        public wordlist()
        {
            InitializeComponent();
        }

        private void wordlist_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bdcDataSet8.word”中。您可以根据需要移动或移除它。
            this.wordTableAdapter.Fill(this.bdcDataSet8.word);

        }
    }
}
