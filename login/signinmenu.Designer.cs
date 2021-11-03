
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Gainsboro;
            this.username.Location = new System.Drawing.Point(400, 120);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(320, 20);
            this.username.TabIndex = 0;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Gainsboro;
            this.password.Location = new System.Drawing.Point(400, 180);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(320, 20);
            this.password.TabIndex = 1;
            this.password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(220, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(228, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // sin
            // 
            this.sin.BackColor = System.Drawing.Color.Maroon;
            this.sin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
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
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signinmenu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sin;
    }
}