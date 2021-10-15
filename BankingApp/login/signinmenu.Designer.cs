
namespace BankingApp
{
    partial class signinmenu
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
            this.uname = new System.Windows.Forms.TextBox();
            this.pword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uname
            // 
            this.uname.BackColor = System.Drawing.Color.Gainsboro;
            this.uname.Location = new System.Drawing.Point(400, 120);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(320, 20);
            this.uname.TabIndex = 0;
            // 
            // pword
            // 
            this.pword.BackColor = System.Drawing.Color.Gainsboro;
            this.pword.Location = new System.Drawing.Point(400, 180);
            this.pword.Name = "pword";
            this.pword.Size = new System.Drawing.Size(320, 20);
            this.pword.TabIndex = 1;
            this.pword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(220, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label2.Location = new System.Drawing.Point(228, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // sin
            // 
            this.sin.BackColor = System.Drawing.Color.Maroon;
            this.sin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sin.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.sin.Location = new System.Drawing.Point(360, 264);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(251, 77);
            this.sin.TabIndex = 7;
            this.sin.Text = "Sign in";
            this.sin.UseVisualStyleBackColor = false;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // signinmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(960, 408);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pword);
            this.Controls.Add(this.uname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signinmenu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox pword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sin;
    }
}