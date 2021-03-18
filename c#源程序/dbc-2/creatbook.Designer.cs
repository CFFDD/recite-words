namespace Student2008
{
    partial class createbook
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
            this.btncrebook = new System.Windows.Forms.Button();
            this.bID = new System.Windows.Forms.Label();
            this.bname = new System.Windows.Forms.Label();
            this.txtbookID = new System.Windows.Forms.TextBox();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.addword = new System.Windows.Forms.Button();
            this.selbook = new System.Windows.Forms.Button();
            this.goback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncrebook
            // 
            this.btncrebook.Location = new System.Drawing.Point(98, 157);
            this.btncrebook.Name = "btncrebook";
            this.btncrebook.Size = new System.Drawing.Size(75, 23);
            this.btncrebook.TabIndex = 1;
            this.btncrebook.Text = "创建新词书";
            this.btncrebook.UseVisualStyleBackColor = true;
            this.btncrebook.Click += new System.EventHandler(this.btncrebook_Click);
            // 
            // bID
            // 
            this.bID.AutoSize = true;
            this.bID.Location = new System.Drawing.Point(38, 65);
            this.bID.Name = "bID";
            this.bID.Size = new System.Drawing.Size(41, 12);
            this.bID.TabIndex = 2;
            this.bID.Text = "词书ID";
            // 
            // bname
            // 
            this.bname.AutoSize = true;
            this.bname.Location = new System.Drawing.Point(38, 102);
            this.bname.Name = "bname";
            this.bname.Size = new System.Drawing.Size(41, 12);
            this.bname.TabIndex = 3;
            this.bname.Text = "词书名";
            // 
            // txtbookID
            // 
            this.txtbookID.Location = new System.Drawing.Point(108, 65);
            this.txtbookID.Name = "txtbookID";
            this.txtbookID.Size = new System.Drawing.Size(100, 21);
            this.txtbookID.TabIndex = 4;
            // 
            // txtbookname
            // 
            this.txtbookname.Location = new System.Drawing.Point(108, 102);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(100, 21);
            this.txtbookname.TabIndex = 5;
            // 
            // addword
            // 
            this.addword.Location = new System.Drawing.Point(40, 221);
            this.addword.Name = "addword";
            this.addword.Size = new System.Drawing.Size(93, 23);
            this.addword.TabIndex = 7;
            this.addword.Text = "开始添加单词";
            this.addword.UseVisualStyleBackColor = true;
            this.addword.Click += new System.EventHandler(this.addword_Click);
            // 
            // selbook
            // 
            this.selbook.Location = new System.Drawing.Point(181, 3);
            this.selbook.Name = "selbook";
            this.selbook.Size = new System.Drawing.Size(96, 23);
            this.selbook.TabIndex = 0;
            this.selbook.Text = "查看已有词书";
            this.selbook.UseVisualStyleBackColor = true;
            this.selbook.Click += new System.EventHandler(this.selbook_Click);
            // 
            // goback
            // 
            this.goback.Location = new System.Drawing.Point(172, 221);
            this.goback.Name = "goback";
            this.goback.Size = new System.Drawing.Size(75, 23);
            this.goback.TabIndex = 6;
            this.goback.Text = "返回上级";
            this.goback.UseVisualStyleBackColor = true;
            this.goback.Click += new System.EventHandler(this.goback_Click_1);
            // 
            // createbook
            // 
            this.ClientSize = new System.Drawing.Size(280, 256);
            this.Controls.Add(this.selbook);
            this.Controls.Add(this.addword);
            this.Controls.Add(this.goback);
            this.Controls.Add(this.txtbookname);
            this.Controls.Add(this.txtbookID);
            this.Controls.Add(this.bname);
            this.Controls.Add(this.bID);
            this.Controls.Add(this.btncrebook);
            this.Name = "createbook";
            this.Text = "创建词书";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btncrebook;
        private System.Windows.Forms.Label bID;
        private System.Windows.Forms.Label bname;
        private System.Windows.Forms.TextBox txtbookID;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.Button addword;
        private System.Windows.Forms.Button selbook;
        private System.Windows.Forms.Button goback;
    }


}