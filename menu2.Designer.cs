
namespace BankingApp
{
    partial class menu2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.account = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.account);
            this.panel2.Controls.Add(this.logout);
            this.panel2.Controls.Add(this.Menu);
            this.panel2.Location = new System.Drawing.Point(-9, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 637);
            this.panel2.TabIndex = 5;
            // 
            // account
            // 
            this.account.BackColor = System.Drawing.Color.Firebrick;
            this.account.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.account.FlatAppearance.BorderSize = 0;
            this.account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account.Location = new System.Drawing.Point(3, 330);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(211, 62);
            this.account.TabIndex = 7;
            this.account.Text = "Account Details";
            this.account.UseMnemonic = false;
            this.account.UseVisualStyleBackColor = false;
            this.account.Click += new System.EventHandler(this.account_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Firebrick;
            this.logout.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Location = new System.Drawing.Point(3, 466);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(211, 62);
            this.logout.TabIndex = 9;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Firebrick;
            this.Menu.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.Menu.FlatAppearance.BorderSize = 0;
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu.Location = new System.Drawing.Point(3, 194);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(211, 62);
            this.Menu.TabIndex = 6;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(211, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 587);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::BankingApp.Properties.Resources.pound_coin_2140;
            this.pictureBox1.Location = new System.Drawing.Point(46, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu2";
            this.Load += new System.EventHandler(this.menu2_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button account;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}