
namespace BankingApp
{
    partial class menu1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.signin = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 408);
            this.panel1.TabIndex = 0;
            // 
            // signin
            // 
            this.signin.BackColor = System.Drawing.Color.Maroon;
            this.signin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signin.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.Location = new System.Drawing.Point(12, 482);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(316, 117);
            this.signin.TabIndex = 1;
            this.signin.Text = "Sign In";
            this.signin.UseVisualStyleBackColor = false;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.Maroon;
            this.signup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signup.Font = new System.Drawing.Font("Century Gothic", 36F);
            this.signup.Location = new System.Drawing.Point(334, 482);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(316, 117);
            this.signup.TabIndex = 2;
            this.signup.Text = "Sign Up";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Maroon;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 36F);
            this.exit.Location = new System.Drawing.Point(656, 482);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(316, 117);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(-9, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 51);
            this.panel2.TabIndex = 4;
            // 
            // menu1
            // 
            this.AccessibleName = "Banking";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "menu1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banking App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel2;
    }
}

