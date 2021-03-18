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
    public partial class wlearning : Form
    {
        public wlearning()
        {
            InitializeComponent();
        }

        public wlearning(string str)
        {
            InitializeComponent();
            txtuserID.Text = str;
        }


        private void wlearning_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bdcDataSet.Form”中。您可以根据需要移动或移除它。
            this.formTableAdapter.Fill(this.bdcDataSet.Form);
            // TODO: 这行代码将数据加载到表“bdcDataSet.word”中。您可以根据需要移动或移除它。
            this.wordTableAdapter.Fill(this.bdcDataSet.word);

        }



        private void addtonewword_Click(object sender, EventArgs e)
        {
            UpdateNewwords ob_add_1 = new UpdateNewwords(txtuserID.Text);
            ob_add_1.ShowDialog();
        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.formTableAdapter.FillBy2(this.bdcDataSet.Form, txtbookID.Text);
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
                this.wordTableAdapter.FillBy2(this.bdcDataSet.word, txtwordID.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void learned_Click(object sender, EventArgs e)
        {

            if (txtuserID.Text.Trim() != "" && txtwordID.Text.Trim() != "" && txtbookID.Text.Trim() != "")
            {
                //
                //对（用户-词书）表更新
                //
                try
                {
                    DataSet dsc = new DataSet();
                    DataBase dbs = new DataBase();
                    string Sqlstr_2;
                    Sqlstr_2 = "select bookID,wordID from form where bookID='" + txtbookID.Text.Trim() + "' and wordID='" + txtwordID + "'";  //查询form表中的单词ID
                    dsc = dbs.GetDataFormDB(Sqlstr_2);
                    if (dsc.Tables[0].Rows[0].ItemArray[1].ToString() == txtwordID.Text.Trim())  //确认词书中有该单词
                    {
                        string Sqlstr_3;
                        Sqlstr_3 = "insert into Learning(userID,bookID,speed) values('" + txtuserID.Text.Trim() + "','" + txtbookID.Text.Trim() + "','1')";  //向（用户-词书）学习表加入一条记录
                        DataBase dba = new DataBase();
                        bool bb;
                        bb = dba.UpdateDB(Sqlstr_3);
                        if (bb == true)
                        {
                            if (MessageBox.Show("词书学习进度已成功记录！", "记录成功", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                txtuserID.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("出现错误，用户对词书学习记录录入失败");
                        }
                    }
                    else
                    {
                        MessageBox.Show("向词书 学习表 插入记录遇到问题：选择的词书中没有该单词");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("输入错误！" + ex.Message, "错误");
                }



                //
                //对（用户—词书—单词）表更新
                //
                DataSet dso = new DataSet();
                DataBase dbo = new DataBase();
                string Sqlstr_7;
                Sqlstr_7 = "select bookID,wordID from form where bookID='" + txtbookID.Text.Trim() + "' and wordID='" + txtwordID + "'";  //查询form表中的单词ID
                dso = dbo.GetDataFormDB(Sqlstr_7);
                if (dso.Tables[0].Rows[0].ItemArray[1].ToString() == txtwordID.Text.Trim())  //确认词书中有该单词
                {
                    string sqlStr;
                    sqlStr = "insert into wlearning(userID,bookID,wordID,uwblsp) values('" + txtuserID.Text.Trim() + "','" + txtbookID.Text.Trim() + "','" + txtwordID.Text.Trim() + "','1')";   //向（用户-词书-单词）学习表加入一条记录
                    //sqlStr = "update wlearning set uwblsp=1 where userID='" + txtuserID.Text.Trim()+ "'  and  bookID='"+ txtbookID.Text.Trim()+ "'  and  wordID='" + txtwordID.Text.Trim() +  "'";
                    DataBase db = new DataBase();
                    bool b;
                    b = db.UpdateDB(sqlStr);
                    if (b == true)
                    {
                        if (MessageBox.Show("词书单词学习进度已成功记录！", "记录成功", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {

                            txtuserID.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("出现错误，用户对词书单词学习记录录入失败");

                    }
                }
                else
                {
                    MessageBox.Show("向 词书单词学习表 插入记录遇到问题：选择的词书中没有该单词");
                }
            }
            else
            {
                MessageBox.Show("用户ID、单词ID、词书ID不能为空");
                txtuserID.Focus();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            learnedwordlistcs ob_ledwordlist_2=new learnedwordlistcs(txtuserID.Text);
            ob_ledwordlist_2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet dsgg = new DataSet();
            DataBase dbgg = new DataBase();
            string Sqlstr_gg;
            Sqlstr_gg = "select bookID,wordID from form where bookID='" + txtbookID.Text.Trim() + "' and wordID='" + txtwordID + "'";  //查询word表中的单词名
            dsgg = dbgg.GetDataFormDB(Sqlstr_gg);
            textBox1.Text = dsgg.Tables[0].Rows[0].ItemArray[1].ToString();
        }

    }
}
