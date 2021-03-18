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
    public partial class addwords : Form
    {
        public addwords()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (txtwordID.Text.Trim() != "" && txtwordname.Text.Trim() != "")
            {
                if (txtwordID.Text.Trim() != "" && txtwordname.Text.Trim() != "")
                {
                    string sqlStr;
                    sqlStr = "insert into word(wordID,wordname,Bphonetic,Uphonetic,explanation,Similarword,root1,Eexample,Cexample) values('" + txtwordID.Text.Trim() + "','" + txtwordname.Text.Trim() + "','" + Bp.Text.Trim() + "','" + Up.Text.Trim() + "','" + txtexplanation.Text.Trim() + "','" + Si.Text.Trim() + "','" + txtroot1.Text.Trim() + "','" + Eexam.Text.Trim() + "','" + Cexam.Text.Trim() + "')";
                    DataBase db = new DataBase();
                    bool b;
                    b = db.UpdateDB(sqlStr);
                    if (b == true)
                    {
                        if (MessageBox.Show("添加成功", "添加成功", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            txtwordID.Text = ""; txtwordname.Text = ""; Bp.Text = ""; Up.Text = ""; txtexplanation.Text = ""; Si.Text = ""; root1.Text = ""; Eexam.Text = ""; Cexam.Text = "";
                            txtwordID.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("单词ID及单词名不能为空");
                    txtwordID.Focus();

                }
            }
        }

        



        private void button1_Click(object sender, EventArgs e)
        {
            wordlist ob_wordlist_2 = new wordlist();
            ob_wordlist_2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet dsgg = new DataSet();
            DataBase dbgg = new DataBase();
            string Sqlstr_gg;
            Sqlstr_gg = "select wordname from word where wordname='" + txtwordname.Text.Trim() + "'";  //查询word表中的单词名
            dsgg = dbgg.GetDataFormDB(Sqlstr_gg);
            textBox1.Text = dsgg.Tables[0].Rows[0].ItemArray[0].ToString();
        }
    }
}
