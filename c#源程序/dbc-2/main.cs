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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        public main(string str)
        {
            InitializeComponent();
            txtuserID.Text = str;
        }


        private void 开始学习单词ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wlearning ob_wlearning_1 = new wlearning(txtuserID.Text);
            ob_wlearning_1.Show();

        }

        private void 查看生词表ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newwordstable ob_newword_1 = new newwordstable(txtuserID.Text);
            ob_newword_1.ShowDialog();
        }

        private void 已学习词书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            learnbook ob_ledbook_1 = new learnbook(txtuserID.Text);
            ob_ledbook_1.Show();
            //learnbook ob_ledbook_1 = new learnbook(txtuserID.Text);
            //ob_ledbook_1.ShowDialog();
        }

        private void 已学习单词ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            learnedwordlistcs ob_ledwlist_1 = new learnedwordlistcs(txtuserID.Text);
            ob_ledwlist_1.ShowDialog();
        }

        private void 已学习词书ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            learnbook ob_ledbook_1 = new learnbook(txtuserID.Text);
            ob_ledbook_1.Show();

        }

        private void 已学习单词ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            learnedwordlistcs ob_ledwlist_1 = new learnedwordlistcs(txtuserID.Text);
            ob_ledwlist_1.ShowDialog();
        }

        private void 生词表ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            newwordstable ob_newword_1 = new newwordstable(txtuserID.Text);
            ob_newword_1.ShowDialog();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtnewpass.Text.Trim() != "")
            {
                string sqlStr;
                sqlStr = "update users set userpassword='" + txtnewpass.Text.Trim() + "' where userID='" + txtuserID.Text.Trim() + "'";
                DataBase db = new DataBase();
                bool b;
                b = db.UpdateDB(sqlStr);
                if (b == true)
                {
                    if (MessageBox.Show("修改成功！请重新登录", "修改成功", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        Form1 ob_form1_1 = new Form1();
                        ob_form1_1.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void 注销登陆ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 ob_Form1_1 = new Form1();
            ob_Form1_1.Show();
            this.Hide();
        }


        private void 添加新单词ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addwords ob_addwords_1 = new addwords();
            ob_addwords_1.Show();
        }

        private void 建立新词书ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            createbook ob_createbook_1 = new createbook();
            ob_createbook_1.Show();
        }


        //
        //报表
        //
        private void 生词表ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            report_newwords ob_new = new report_newwords();
            ob_new.Show();
        }

        private void 词书学习表ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            report_learning ob_learning = new report_learning();
            ob_learning.Show();
        }

        private void 词书组成表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report_form ob_formlist = new report_form();
            ob_formlist.Show();
        }

        private void 用户表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report_users ob_users = new report_users();
            ob_users.Show();
        }

        private void 词书表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report_book ob_book = new report_book();
            ob_book.Show();
        }

        private void 单词表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report_word ob_word = new report_word();
            ob_word.Show();
        }

        private void 词书单词学习表ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            report_wlearning ob_wl = new report_wlearning();
            ob_wl.Show();

        }


        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helptxt ob_help_1 = new helptxt();
            ob_help_1.Show();
        }
    }
}