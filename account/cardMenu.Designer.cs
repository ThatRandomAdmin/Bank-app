
namespace BankingApp
{
    partial class cardMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.addCard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 40F);
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 65);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cards";
            // 
            // addCard
            // 
            this.addCard.FlatAppearance.BorderSize = 0;
            this.addCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCard.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.addCard.Location = new System.Drawing.Point(12, 493);
            this.addCard.Name = "addCard";
            this.addCard.Size = new System.Drawing.Size(737, 53);
            this.addCard.TabIndex = 19;
            this.addCard.Text = "Add a Card";
            this.addCard.UseVisualStyleBackColor = true;
            this.addCard.Click += new System.EventHandler(this.addCard_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 380);
            this.panel1.TabIndex = 20;
            // 
            // cardMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(761, 587);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addCard);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cardMenu";
            this.Text = "cardMenu";
            this.Load += new System.EventHandler(this.cardMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button addCard;
    }
}