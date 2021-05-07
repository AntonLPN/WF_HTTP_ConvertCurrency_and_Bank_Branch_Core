
namespace WF_HTTP_ConvertCurrency
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
            this.textBoxValues = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSumSale = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSaleUSD = new System.Windows.Forms.TextBox();
            this.textBoxUSD1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEURSale = new System.Windows.Forms.TextBox();
            this.textBoxEUR1 = new System.Windows.Forms.TextBox();
            this.textBoxRURSale = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRUR1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSaleUAH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxValues
            // 
            this.textBoxValues.Location = new System.Drawing.Point(13, 43);
            this.textBoxValues.Multiline = true;
            this.textBoxValues.Name = "textBoxValues";
            this.textBoxValues.Size = new System.Drawing.Size(666, 74);
            this.textBoxValues.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Значения  для отладки приложения";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(13, 137);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(207, 54);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Загрузить данные с сайта в текст бокс";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(561, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Конвертер валют гривна в инастранную валюту.(делаю задание максимально \r\nпростым " +
    "для того что бы проработать запросы а не логику)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Конверт валют";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сумма";
            // 
            // textBoxSumSale
            // 
            this.textBoxSumSale.Location = new System.Drawing.Point(77, 281);
            this.textBoxSumSale.Name = "textBoxSumSale";
            this.textBoxSumSale.Size = new System.Drawing.Size(100, 23);
            this.textBoxSumSale.TabIndex = 6;
            this.textBoxSumSale.Text = "1000";
            this.textBoxSumSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSumSale_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Результат";
            // 
            // textBoxSaleUSD
            // 
            this.textBoxSaleUSD.Location = new System.Drawing.Point(78, 337);
            this.textBoxSaleUSD.Name = "textBoxSaleUSD";
            this.textBoxSaleUSD.Size = new System.Drawing.Size(100, 23);
            this.textBoxSaleUSD.TabIndex = 9;
            // 
            // textBoxUSD1
            // 
            this.textBoxUSD1.Location = new System.Drawing.Point(226, 337);
            this.textBoxUSD1.Name = "textBoxUSD1";
            this.textBoxUSD1.Size = new System.Drawing.Size(100, 23);
            this.textBoxUSD1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Текущий курс продажи";
            // 
            // textBoxEURSale
            // 
            this.textBoxEURSale.Location = new System.Drawing.Point(77, 366);
            this.textBoxEURSale.Name = "textBoxEURSale";
            this.textBoxEURSale.Size = new System.Drawing.Size(100, 23);
            this.textBoxEURSale.TabIndex = 12;
            // 
            // textBoxEUR1
            // 
            this.textBoxEUR1.Location = new System.Drawing.Point(225, 366);
            this.textBoxEUR1.Name = "textBoxEUR1";
            this.textBoxEUR1.Size = new System.Drawing.Size(100, 23);
            this.textBoxEUR1.TabIndex = 13;
            // 
            // textBoxRURSale
            // 
            this.textBoxRURSale.Location = new System.Drawing.Point(77, 395);
            this.textBoxRURSale.Name = "textBoxRURSale";
            this.textBoxRURSale.Size = new System.Drawing.Size(100, 23);
            this.textBoxRURSale.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "UAH";
            // 
            // textBoxRUR1
            // 
            this.textBoxRUR1.Location = new System.Drawing.Point(225, 395);
            this.textBoxRUR1.Name = "textBoxRUR1";
            this.textBoxRUR1.Size = new System.Drawing.Size(100, 23);
            this.textBoxRUR1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "USD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(191, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "EUR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "RUR";
            // 
            // buttonSaleUAH
            // 
            this.buttonSaleUAH.Location = new System.Drawing.Point(122, 434);
            this.buttonSaleUAH.Name = "buttonSaleUAH";
            this.buttonSaleUAH.Size = new System.Drawing.Size(163, 33);
            this.buttonSaleUAH.TabIndex = 20;
            this.buttonSaleUAH.Text = "Обменять";
            this.buttonSaleUAH.UseVisualStyleBackColor = true;
            this.buttonSaleUAH.Click += new System.EventHandler(this.buttonSaleUAH_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 501);
            this.Controls.Add(this.buttonSaleUAH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxRUR1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxRURSale);
            this.Controls.Add(this.textBoxEUR1);
            this.Controls.Add(this.textBoxEURSale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxUSD1);
            this.Controls.Add(this.textBoxSaleUSD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSumSale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxValues);
            this.MaximumSize = new System.Drawing.Size(707, 540);
            this.MinimumSize = new System.Drawing.Size(707, 540);
            this.Name = "Form1";
            this.Text = "Конверт валют";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSumSale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSaleUSD;
        private System.Windows.Forms.TextBox textBoxUSD1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEURSale;
        private System.Windows.Forms.TextBox textBoxEUR1;
        private System.Windows.Forms.TextBox textBoxRURSale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRUR1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSaleUAH;
    }
}

