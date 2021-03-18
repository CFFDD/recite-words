using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Student2008;

namespace dbc_2
{
    public partial class addwordtobook : Form
    {
        public addwordtobook()
        {
            InitializeComponent();
        }

        private void btncrebook_Click(object sender, EventArgs e)
        {
            if (txtbookID.Text.Trim() != "" && txtwordID.Text.Trim() != "" && txtbwID.Text.Trim() !="")
            {
                string sqlStr;
                sqlStr = "insert into form(bookID,wordID,bwID) values('" + txtbookID.Text.Trim() + "','" + txtwordID.Text.Trim() + "','" + txtbwID.Text.Trim()+"')";
                DataBase db = new DataBase();
                bool b;
                b = db.UpdateDB(sqlStr);
                if (b == true)
                {
                    if (MessageBox.Show("添加成功", "添加成功", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        txtbookID.Text = ""; txtwordID.Text = "";
                        txtbookID.Focus();
                    }
                }
                else { MessageBox.Show("请检查您输入的单词ID与单词词书ID，它或许已存在，或该单词尚未被收录"); }
            }
            else
            {
                MessageBox.Show("所有ID都不能为空");
                txtbookID.Focus();

            }
        }

        private void 查询方式查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectwords ob_selw_1 = new selectwords(txtbookID.Text,txtwordID.Text);
            ob_selw_1.ShowDialog();
        }

        private void 视图方式查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormView ob_formview_1 = new FormView(txtbookID.Text);
            ob_formview_1.ShowDialog();
        }

        private void 查看词书现有单词数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCount ob_foco_1 = new FormCount(txtbookID.Text);
            ob_foco_1.ShowDialog();
        }

        private void 查看系统现有单词ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wordlist ob_wordlist_1 = new wordlist();
            ob_wordlist_1.Show();
        }



    }
}
