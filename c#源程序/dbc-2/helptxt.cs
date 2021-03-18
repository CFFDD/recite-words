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
    public partial class helptxt : Form
    {
        public helptxt()
        {
            InitializeComponent();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = " 如果您想要修改本账号登陆密码，请在主菜单的新密码输入框中填入预想中的新密码，并点击“主菜单-用户-修改密码”";
        }

        private void 注销登陆ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " 如果您想要切换账号，可以点击“主菜单-用户-注销登陆”，您将会回到登陆界面";

        }

        private void 生词表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = " 通过“主菜单—查看学习信息—生词表-查询”或“主菜单—开始学习-更新生词表”您可以看到本账号的生词表信息，包含其单词ID以及加入生词表的时间";

        }

        private void 已学习词书ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " 通过“主菜单—查看学习信息—已学习词书”您可以看到本账号已学习或正在学习的词书信息，包含词书ID，词书名，以及该词书内该账号已学习的单词数统计和该账号已学习或正在学习的词书数统计";

        }

        private void 已学习单词ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " 通过“主菜单—查看学习信息—已学习单词”您可以看到本账号已学习的单词信息，包含单词所属词书ID，单词ID，单词名，以及该账号所有词书已学习的单词数统计              注：目前暂未实现已学习单词的不重复统计";

        }

        private void 添加新单词ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " 通过“主菜单—添加新词书或单词—添加新单词”您可以向系统单词表加入新单词数据，操作方法如下：  先在单词名输入框内输入您想添加的单词名，点击“检测”按纽查询，若返回结果是一个与您的输入相同的单词，则说明该单词已存在，无需重复添加，您可在通过“查找单词”按纽进入查询界面“单词名-下拉框”选中您要的单词，查看其信息，若与您的预想不符，可回到添加单词界面重复向系统单词表加入该单词的信息，注意单词ID不可重复";

        }

        private void 建立新词书ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " 通过“主菜单—添加新词书或单词—建立新词书”您可以向系统词书表加入新词书记录，注意词书ID不可重复（可通过“已有词书”查看已被占用的ID）";

        }

        private void 向词书内加入新单词ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = " 通过“主菜单—添加新词书或单词—建立新词书-加入单词到词书”您可以向词书内加入新单词记录，注意单词ID不可重复（可通过顶部菜单栏查看已有的单词（单词ID））";
        }

        private void 开始学习ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = " 通过“主菜单—开始学习”您可以查看词书内的单词ID，并通过单词ID查询单词信息进行学习，并通过“已学习”按纽保存学习记录到词书学习表(Learning)以及词书单词学习表（wlearning）。同一词书在Learning表中只记录一次，当该记录已存在时，对Learning表的更新操作会报错；wlearning表同上，只记录一次同一词书的同一单词ID。通过“检测”按纽可检测该单词是否存在该词书中，当您要添加学习记录的单词与其所在词书不符时，将会报错。";

        }

        private void 添加生词ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = " 通过“主菜单—开始学习-更新生词表”您可以将并未完全掌握的单词加入生词表，并可通过此窗口查看已有生词";
        }

        private void 输出报表StripMenuItem12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "通过“主菜单—输出报表”选项，用户可自由打印所需要的系统表";

        }

        private void 帮助StripMenuItem20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "当您需要帮助时，可尝试打开“主菜单-帮助”获得功能/操作帮助  ";

        }

        private void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "在登陆界面，可通过“注册”按纽注册新账号";

        }


    }
}
