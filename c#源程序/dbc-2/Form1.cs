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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)   //‘登陆’事件处理程序定义
        {
            try
            {
                DataSet ds = new DataSet();
                DataBase db = new DataBase();
                string sqlStr = "select userID,userpassword from users where userID='" + txtUserName.Text.Trim() + "'";
                ds = db.GetDataFormDB(sqlStr);
                if (ds.Tables[0].Rows[0].ItemArray[1].ToString() == txtUserPassword.Text.Trim())  //将输入的密码与数据库表中数据对比
                {
                    main ob_main = new main(txtUserName.Text);
                    ClassShared.userInfo[0] = txtUserName.Text.Trim();
                    //输入的用户ID->  ClassShared.userInfo[0]
                    ClassShared.userInfo[1] = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                    //数据库表中找到的对应的用户密码->  ClassShared.userInfo[1]
                    MessageBox.Show("登录成功！" + txtUserName.Text.Trim() + txtUserPassword.Text.Trim(), "登录成功");
                    ob_main.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重新输入！");
                    txtUserName.Text = "";         //重置输入文本框为空以待再次输入
                    txtUserPassword.Text = "";
                    txtUserName.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("用户名或密码输入错误！" + ex.Message, "错误");
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)  //‘注册’事件处理程序定义
        {
            if (txtUserName.Text.Trim() != "" && txtUserPassword.Text.Trim() != "")
            {
                string sqlStr;
                sqlStr = "insert into users(userID,userPassword) values('" + txtUserName.Text.Trim() + "','" + txtUserPassword.Text.Trim() + "')";
                DataBase db = new DataBase();
                bool b;
                b = db.UpdateDB(sqlStr);
                if (b == true)
                {
                    if (MessageBox.Show("注册成功！请重新登录", "注册成功", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        txtUserName.Text = ""; txtUserPassword.Text = "";
                        txtUserName.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("用户名和密码不能为空");
                txtUserName.Focus();

            }
        }
    }
}
