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
    public partial class report_users : Form
    {
        public report_users()
        {
            InitializeComponent();
        }

        private void report_users_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bdcDataSet8.users”中。您可以根据需要移动或移除它。
            this.usersTableAdapter.Fill(this.bdcDataSet8.users);

            this.reportViewer1.RefreshReport();
        }
    }
}
