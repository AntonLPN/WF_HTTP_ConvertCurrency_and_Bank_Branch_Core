
namespace WF_BankBranchesHTTP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxListBank = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxListBank
            // 
            this.textBoxListBank.Location = new System.Drawing.Point(12, 12);
            this.textBoxListBank.Multiline = true;
            this.textBoxListBank.Name = "textBoxListBank";
            this.textBoxListBank.ReadOnly = true;
            this.textBoxListBank.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxListBank.Size = new System.Drawing.Size(470, 346);
            this.textBoxListBank.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(516, 442);
            this.Controls.Add(this.textBoxListBank);
            this.Name = "Form1";
            this.Text = "Список отделений банка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxListBank;
    }
}

