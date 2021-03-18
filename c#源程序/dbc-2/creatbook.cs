using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dbc_2;

namespace Student2008
{
    public partial class createbook : Form
    {
        public createbook()
        {
            InitializeComponent();
        }

        private void btncrebook_Click(object sender, EventArgs e)
        {
            if (txtbookID.Text.Trim() != "" && txtbookname.Text.Trim() != "")
            {
                string sqlStr;
                sqlStr = "insert into book(bookID,bookname) values('" + txtbookID.Text.Trim() + "','" + txtbookname.Text.Trim() + "')";
                DataBase db = new DataBase();
                bool b;
                b = db.UpdateDB(sqlStr);
                if (b == true)
                {
                    if (MessageBox.Show("创建成功", "创建成功", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        txtbookname.Text = "";
                        txtbookID.Focus();
                        this.addword.Show(); //显示添加单词控件——在创建词书之前为隐藏状态
                    }
                }
            }
            else
            {
                MessageBox.Show("词书ID和词书名不能为空");
                txtbookID.Focus();

            }
        }

        private void selbook_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                DataBase db = new DataBase();
                string sqlStr = "select bookID,bookname,vocabulary from book";
                ds = db.GetDataFormDB(sqlStr);
                if (ds != null)
                {
                    booklist  ob_booklist = new booklist();
                    ob_booklist.Show();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("错误！" + ex.Message, "错误");
            }
        }


        private void goback_Click_1(object sender, EventArgs e)
        {
            main ob_main = new main();
            ob_main.Show();
            this.Hide();
        }

        private void addword_Click(object sender, EventArgs e)
        {
            addwordtobook ob_adwtbook_1 = new addwordtobook();
            ob_adwtbook_1.Show();
        }
        }



    }

