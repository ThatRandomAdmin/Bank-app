
namespace BankingApp
{
    partial class addCard
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.RadioButton();
            this.Spend = new System.Windows.Forms.RadioButton();
            this.Transfer = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.button1.Location = new System.Drawing.Point(0, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(737, 53);
            this.button1.TabIndex = 20;
            this.button1.Text = "Create Card";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Card Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(254, 70);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(231, 20);
            this.txt.TabIndex = 25;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(323, 134);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(231, 24);
            this.save.TabIndex = 26;
            this.save.TabStop = true;
            this.save.Text = "Savings";
            this.save.UseVisualStyleBackColor = true;
            // 
            // Spend
            // 
            this.Spend.Location = new System.Drawing.Point(323, 164);
            this.Spend.Name = "Spend";
            this.Spend.Size = new System.Drawing.Size(231, 24);
            this.Spend.TabIndex = 27;
            this.Spend.TabStop = true;
            this.Spend.Text = "Spending";
            this.Spend.UseVisualStyleBackColor = true;
            // 
            // Transfer
            // 
            this.Transfer.Location = new System.Drawing.Point(323, 194);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(231, 24);
            this.Transfer.TabIndex = 28;
            this.Transfer.TabStop = true;
            this.Transfer.Text = "Transfering";
            this.Transfer.UseVisualStyleBackColor = true;
            // 
            // addCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(737, 380);
            this.Controls.Add(this.Transfer);
            this.Controls.Add(this.Spend);
            this.Controls.Add(this.save);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addCard";
            this.Text = "addCard";
            this.Load += new System.EventHandler(this.addCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.RadioButton save;
        private System.Windows.Forms.RadioButton Spend;
        private System.Windows.Forms.RadioButton Transfer;
    }
}