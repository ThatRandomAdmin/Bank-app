
namespace BankingApp
{
    partial class settings1
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
            this.newUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.changeUname = new System.Windows.Forms.Button();
            this.changePword = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newPassword2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newUsername
            // 
            this.newUsername.Location = new System.Drawing.Point(105, 61);
            this.newUsername.Name = "newUsername";
            this.newUsername.Size = new System.Drawing.Size(306, 20);
            this.newUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(-13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeUname
            // 
            this.changeUname.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeUname.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.changeUname.Location = new System.Drawing.Point(417, 52);
            this.changeUname.Name = "changeUname";
            this.changeUname.Size = new System.Drawing.Size(147, 38);
            this.changeUname.TabIndex = 2;
            this.changeUname.Text = "Change";
            this.changeUname.UseVisualStyleBackColor = true;
            this.changeUname.Click += new System.EventHandler(this.changeUname_Click);
            // 
            // changePword
            // 
            this.changePword.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePword.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.changePword.Location = new System.Drawing.Point(303, 232);
            this.changePword.Name = "changePword";
            this.changePword.Size = new System.Drawing.Size(147, 38);
            this.changePword.TabIndex = 5;
            this.changePword.Text = "Change";
            this.changePword.UseVisualStyleBackColor = true;
            this.changePword.Click += new System.EventHandler(this.changePword_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(-13, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(762, 49);
            this.label2.TabIndex = 4;
            this.label2.Text = "Change Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(222, 180);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(306, 20);
            this.newPassword.TabIndex = 3;
            this.newPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(749, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "-------------\r\n";
            // 
            // newPassword2
            // 
            this.newPassword2.Location = new System.Drawing.Point(222, 206);
            this.newPassword2.Name = "newPassword2";
            this.newPassword2.Size = new System.Drawing.Size(306, 20);
            this.newPassword2.TabIndex = 7;
            this.newPassword2.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(749, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "-------------\r\n";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label5.Location = new System.Drawing.Point(-13, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(762, 49);
            this.label5.TabIndex = 9;
            this.label5.Text = "Other settings(Yet to be added)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settings1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(737, 514);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newPassword2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.changePword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.changeUname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settings1";
            this.Text = "settings1";
            this.Load += new System.EventHandler(this.settings1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeUname;
        private System.Windows.Forms.Button changePword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPassword2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}