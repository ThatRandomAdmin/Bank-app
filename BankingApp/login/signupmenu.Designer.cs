
namespace BankingApp
{
    partial class signupmenu
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
            this.sup = new System.Windows.Forms.Button();
            this.pword = new System.Windows.Forms.TextBox();
            this.uname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sup
            // 
            this.sup.BackColor = System.Drawing.Color.Maroon;
            this.sup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sup.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.sup.Location = new System.Drawing.Point(360, 264);
            this.sup.Name = "sup";
            this.sup.Size = new System.Drawing.Size(251, 77);
            this.sup.TabIndex = 8;
            this.sup.Text = "Sign up";
            this.sup.UseVisualStyleBackColor = false;
            this.sup.Click += new System.EventHandler(this.sup_Click);
            // 
            // pword
            // 
            this.pword.BackColor = System.Drawing.Color.Gainsboro;
            this.pword.Location = new System.Drawing.Point(435, 79);
            this.pword.Name = "pword";
            this.pword.Size = new System.Drawing.Size(320, 20);
            this.pword.TabIndex = 9;
            // 
            // uname
            // 
            this.uname.BackColor = System.Drawing.Color.Gainsboro;
            this.uname.Location = new System.Drawing.Point(435, 130);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(320, 20);
            this.uname.TabIndex = 10;
            this.uname.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(228, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label2.Location = new System.Drawing.Point(114, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "Re-enter password";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(435, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label3.Location = new System.Drawing.Point(236, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // signupmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(960, 408);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.pword);
            this.Controls.Add(this.sup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signupmenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.signupmenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sup;
        private System.Windows.Forms.TextBox pword;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}