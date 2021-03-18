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
    public partial class UpdateNewwords : Form
    {
        public UpdateNewwords()
        {
            InitializeComponent();
        }

        public UpdateNewwords(string str)
        {
            InitializeComponent();
            txtuserID.Text = str;
        }


        private void add_Click(object sender, EventArgs e)
        {
            if (txtwordID.Text.Trim() != "" && txtuserID.Text.Trim() != "")
            {
               
                string sqlStr;
                sqlStr = "insert into newwords(userID,wordID,stime) values('" + txtuserID.Text.Trim() + "','" + txtwordID.Text.Trim() + "','"+DateTime.Now.ToString()+ "')";
                DataBase db = new DataBase();
                bool b;
                b = db.UpdateDB(sqlStr);
                if (b == true)
                {
                    if (MessageBox.Show("成功加入生词表", "添加成功", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        txtuserID.Text = ""; txtwordID.Text = "";
                        txtuserID.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("用户ID与单词ID不可为空");
                txtuserID.Focus();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (txtwordID.Text.Trim() != "" && txtuserID.Text.Trim() != "")
            {
                string sqlStr;
                sqlStr = "delete from newwords where userID='" + txtuserID.Text.Trim() + "' AND wordID='" + txtwordID.Text.Trim() + "'";
                DataBase db = new DataBase();
                bool b;
                b = db.UpdateDB(sqlStr);
                if (b == true)
                {
                    if (MessageBox.Show("成功从生词表中删除", "删除成功", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        txtuserID.Text = ""; txtwordID.Text = "";
                        txtuserID.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("用户ID与单词ID不可为空");
                txtuserID.Focus();
            }
        }

        private void selectnew_Click(object sender, EventArgs e)
        {
            newwordstable ob_newword_1 = new newwordstable(txtuserID.Text);
            ob_newword_1.ShowDialog();
        }
    }
}
