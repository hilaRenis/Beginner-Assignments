
namespace ProgrammingAssignment7_Lottery_week12
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.lotteryNo_lb = new System.Windows.Forms.ListBox();
            this.maxValue_tb = new System.Windows.Forms.TextBox();
            this.wantedNo_tb = new System.Windows.Forms.TextBox();
            this.createLotteryObject_btn = new System.Windows.Forms.Button();
            this.drawNextNo_btn = new System.Windows.Forms.Button();
            this.drawALLNo_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of wanted numbers:";
            // 
            // lotteryNo_lb
            // 
            this.lotteryNo_lb.FormattingEnabled = true;
            this.lotteryNo_lb.ItemHeight = 16;
            this.lotteryNo_lb.Location = new System.Drawing.Point(535, 67);
            this.lotteryNo_lb.Name = "lotteryNo_lb";
            this.lotteryNo_lb.Size = new System.Drawing.Size(253, 356);
            this.lotteryNo_lb.TabIndex = 2;
            // 
            // maxValue_tb
            // 
            this.maxValue_tb.Location = new System.Drawing.Point(333, 64);
            this.maxValue_tb.Name = "maxValue_tb";
            this.maxValue_tb.Size = new System.Drawing.Size(167, 22);
            this.maxValue_tb.TabIndex = 3;
            this.maxValue_tb.Text = "0";
            // 
            // wantedNo_tb
            // 
            this.wantedNo_tb.Location = new System.Drawing.Point(333, 103);
            this.wantedNo_tb.Name = "wantedNo_tb";
            this.wantedNo_tb.Size = new System.Drawing.Size(167, 22);
            this.wantedNo_tb.TabIndex = 4;
            this.wantedNo_tb.Text = "0";
            // 
            // createLotteryObject_btn
            // 
            this.createLotteryObject_btn.Location = new System.Drawing.Point(124, 179);
            this.createLotteryObject_btn.Name = "createLotteryObject_btn";
            this.createLotteryObject_btn.Size = new System.Drawing.Size(376, 40);
            this.createLotteryObject_btn.TabIndex = 5;
            this.createLotteryObject_btn.Text = "Create lottery object";
            this.createLotteryObject_btn.UseVisualStyleBackColor = true;
            this.createLotteryObject_btn.Click += new System.EventHandler(this.createLotteryObject_btn_Click);
            // 
            // drawNextNo_btn
            // 
            this.drawNextNo_btn.Enabled = false;
            this.drawNextNo_btn.Location = new System.Drawing.Point(124, 248);
            this.drawNextNo_btn.Name = "drawNextNo_btn";
            this.drawNextNo_btn.Size = new System.Drawing.Size(376, 40);
            this.drawNextNo_btn.TabIndex = 6;
            this.drawNextNo_btn.Text = "Draw Next Number";
            this.drawNextNo_btn.UseVisualStyleBackColor = true;
            this.drawNextNo_btn.Click += new System.EventHandler(this.drawNextNo_btn_Click);
            // 
            // drawALLNo_btn
            // 
            this.drawALLNo_btn.Enabled = false;
            this.drawALLNo_btn.Location = new System.Drawing.Point(124, 310);
            this.drawALLNo_btn.Name = "drawALLNo_btn";
            this.drawALLNo_btn.Size = new System.Drawing.Size(376, 40);
            this.drawALLNo_btn.TabIndex = 7;
            this.drawALLNo_btn.Text = "Draw All Numbers At Once";
            this.drawALLNo_btn.UseVisualStyleBackColor = true;
            this.drawALLNo_btn.Click += new System.EventHandler(this.drawALLNo_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawALLNo_btn);
            this.Controls.Add(this.drawNextNo_btn);
            this.Controls.Add(this.createLotteryObject_btn);
            this.Controls.Add(this.wantedNo_tb);
            this.Controls.Add(this.maxValue_tb);
            this.Controls.Add(this.lotteryNo_lb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lotteryNo_lb;
        private System.Windows.Forms.TextBox maxValue_tb;
        private System.Windows.Forms.TextBox wantedNo_tb;
        private System.Windows.Forms.Button createLotteryObject_btn;
        private System.Windows.Forms.Button drawNextNo_btn;
        private System.Windows.Forms.Button drawALLNo_btn;
    }
}

