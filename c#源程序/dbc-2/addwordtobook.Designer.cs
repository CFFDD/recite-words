namespace dbc_2
{
    partial class addwordtobook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtwordID = new System.Windows.Forms.TextBox();
            this.txtbookID = new System.Windows.Forms.TextBox();
            this.bname = new System.Windows.Forms.Label();
            this.bID = new System.Windows.Forms.Label();
            this.btncrebook = new System.Windows.Forms.Button();
            this.bwID = new System.Windows.Forms.Label();
            this.txtbwID = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查看词书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询方式查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图方式查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看词书现有单词数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查看系统现有单词ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtwordID
            // 
            this.txtwordID.Location = new System.Drawing.Point(127, 87);
            this.txtwordID.Name = "txtwordID";
            this.txtwordID.Size = new System.Drawing.Size(100, 21);
            this.txtwordID.TabIndex = 9;
            // 
            // txtbookID
            // 
            this.txtbookID.Location = new System.Drawing.Point(127, 50);
            this.txtbookID.Name = "txtbookID";
            this.txtbookID.Size = new System.Drawing.Size(100, 21);
            this.txtbookID.TabIndex = 8;
            // 
            // bname
            // 
            this.bname.AutoSize = true;
            this.bname.Location = new System.Drawing.Point(57, 96);
            this.bname.Name = "bname";
            this.bname.Size = new System.Drawing.Size(41, 12);
            this.bname.TabIndex = 7;
            this.bname.Text = "单词ID";
            // 
            // bID
            // 
            this.bID.AutoSize = true;
            this.bID.Location = new System.Drawing.Point(57, 59);
            this.bID.Name = "bID";
            this.bID.Size = new System.Drawing.Size(41, 12);
            this.bID.TabIndex = 6;
            this.bID.Text = "词书ID";
            // 
            // btncrebook
            // 
            this.btncrebook.Location = new System.Drawing.Point(105, 182);
            this.btncrebook.Name = "btncrebook";
            this.btncrebook.Size = new System.Drawing.Size(75, 23);
            this.btncrebook.TabIndex = 10;
            this.btncrebook.Text = "确认添加";
            this.btncrebook.UseVisualStyleBackColor = true;
            this.btncrebook.Click += new System.EventHandler(this.btncrebook_Click);
            // 
            // bwID
            // 
            this.bwID.AutoSize = true;
            this.bwID.Location = new System.Drawing.Point(33, 131);
            this.bwID.Name = "bwID";
            this.bwID.Size = new System.Drawing.Size(65, 12);
            this.bwID.TabIndex = 22;
            this.bwID.Text = "词书单词ID";
            // 
            // txtbwID
            // 
            this.txtbwID.Location = new System.Drawing.Point(127, 122);
            this.txtbwID.Name = "txtbwID";
            this.txtbwID.Size = new System.Drawing.Size(100, 21);
            this.txtbwID.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看词书ToolStripMenuItem,
            this.查看词书现有单词数ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.查看系统现有单词ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(336, 25);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查看词书ToolStripMenuItem
            // 
            this.查看词书ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询方式查看ToolStripMenuItem,
            this.视图方式查看ToolStripMenuItem});
            this.查看词书ToolStripMenuItem.Name = "查看词书ToolStripMenuItem";
            this.查看词书ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.查看词书ToolStripMenuItem.Text = "查看词书";
            // 
            // 查询方式查看ToolStripMenuItem
            // 
            this.查询方式查看ToolStripMenuItem.Name = "查询方式查看ToolStripMenuItem";
            this.查询方式查看ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.查询方式查看ToolStripMenuItem.Text = "查询方式查看";
            this.查询方式查看ToolStripMenuItem.Click += new System.EventHandler(this.查询方式查看ToolStripMenuItem_Click);
            // 
            // 视图方式查看ToolStripMenuItem
            // 
            this.视图方式查看ToolStripMenuItem.Name = "视图方式查看ToolStripMenuItem";
            this.视图方式查看ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.视图方式查看ToolStripMenuItem.Text = "视图方式查看";
            this.视图方式查看ToolStripMenuItem.Click += new System.EventHandler(this.视图方式查看ToolStripMenuItem_Click);
            // 
            // 查看词书现有单词数ToolStripMenuItem
            // 
            this.查看词书现有单词数ToolStripMenuItem.Name = "查看词书现有单词数ToolStripMenuItem";
            this.查看词书现有单词数ToolStripMenuItem.Size = new System.Drawing.Size(128, 21);
            this.查看词书现有单词数ToolStripMenuItem.Text = "查看词书现有单词数";
            this.查看词书现有单词数ToolStripMenuItem.Click += new System.EventHandler(this.查看词书现有单词数ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 21);
            // 
            // 查看系统现有单词ToolStripMenuItem
            // 
            this.查看系统现有单词ToolStripMenuItem.Name = "查看系统现有单词ToolStripMenuItem";
            this.查看系统现有单词ToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.查看系统现有单词ToolStripMenuItem.Text = "查看系统现有单词";
            this.查看系统现有单词ToolStripMenuItem.Click += new System.EventHandler(this.查看系统现有单词ToolStripMenuItem_Click);
            // 
            // addwordtobook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 261);
            this.Controls.Add(this.txtbwID);
            this.Controls.Add(this.bwID);
            this.Controls.Add(this.btncrebook);
            this.Controls.Add(this.txtwordID);
            this.Controls.Add(this.txtbookID);
            this.Controls.Add(this.bname);
            this.Controls.Add(this.bID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "addwordtobook";
            this.Text = "加入单词到词书";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtwordID;
        private System.Windows.Forms.TextBox txtbookID;
        private System.Windows.Forms.Label bname;
        private System.Windows.Forms.Label bID;
        private System.Windows.Forms.Button btncrebook;
        private System.Windows.Forms.Label bwID;
        private System.Windows.Forms.TextBox txtbwID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看词书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询方式查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图方式查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看词书现有单词数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查看系统现有单词ToolStripMenuItem;
    }
}