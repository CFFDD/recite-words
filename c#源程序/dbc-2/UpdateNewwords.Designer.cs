namespace dbc_2
{
    partial class UpdateNewwords
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
            this.labwordID = new System.Windows.Forms.Label();
            this.txtuserID = new System.Windows.Forms.TextBox();
            this.labuserID = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.selectnew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtwordID
            // 
            this.txtwordID.Location = new System.Drawing.Point(122, 140);
            this.txtwordID.Name = "txtwordID";
            this.txtwordID.Size = new System.Drawing.Size(100, 21);
            this.txtwordID.TabIndex = 29;
            // 
            // labwordID
            // 
            this.labwordID.AutoSize = true;
            this.labwordID.Location = new System.Drawing.Point(63, 149);
            this.labwordID.Name = "labwordID";
            this.labwordID.Size = new System.Drawing.Size(41, 12);
            this.labwordID.TabIndex = 28;
            this.labwordID.Text = "单词ID";
            // 
            // txtuserID
            // 
            this.txtuserID.Enabled = false;
            this.txtuserID.Location = new System.Drawing.Point(122, 100);
            this.txtuserID.Name = "txtuserID";
            this.txtuserID.Size = new System.Drawing.Size(100, 21);
            this.txtuserID.TabIndex = 27;
            // 
            // labuserID
            // 
            this.labuserID.AutoSize = true;
            this.labuserID.Location = new System.Drawing.Point(63, 103);
            this.labuserID.Name = "labuserID";
            this.labuserID.Size = new System.Drawing.Size(41, 12);
            this.labuserID.TabIndex = 26;
            this.labuserID.Text = "用户ID";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(65, 194);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 30;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(146, 194);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 31;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // selectnew
            // 
            this.selectnew.Location = new System.Drawing.Point(206, 1);
            this.selectnew.Name = "selectnew";
            this.selectnew.Size = new System.Drawing.Size(75, 23);
            this.selectnew.TabIndex = 32;
            this.selectnew.Text = "查看生词表";
            this.selectnew.UseVisualStyleBackColor = true;
            this.selectnew.Click += new System.EventHandler(this.selectnew_Click);
            // 
            // UpdateNewwords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.selectnew);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.txtwordID);
            this.Controls.Add(this.labwordID);
            this.Controls.Add(this.txtuserID);
            this.Controls.Add(this.labuserID);
            this.Name = "UpdateNewwords";
            this.Text = "更新生词表";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtwordID;
        private System.Windows.Forms.Label labwordID;
        private System.Windows.Forms.TextBox txtuserID;
        private System.Windows.Forms.Label labuserID;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button selectnew;
    }
}