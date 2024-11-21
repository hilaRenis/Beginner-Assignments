
namespace Assignment3_2_week11
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
            this.chekingAcc_lbl = new System.Windows.Forms.Label();
            this.savingAcc_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chekingAcc_rb = new System.Windows.Forms.RadioButton();
            this.savingAcc_rb = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.amount_tb = new System.Windows.Forms.TextBox();
            this.deposit_btn = new System.Windows.Forms.Button();
            this.withdraw_btn = new System.Windows.Forms.Button();
            this.info_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.accNo_lbl = new System.Windows.Forms.Label();
            this.clientName_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cheking Account Balance: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saving Account Balance: ";
            // 
            // chekingAcc_lbl
            // 
            this.chekingAcc_lbl.AutoSize = true;
            this.chekingAcc_lbl.Location = new System.Drawing.Point(347, 93);
            this.chekingAcc_lbl.Name = "chekingAcc_lbl";
            this.chekingAcc_lbl.Size = new System.Drawing.Size(44, 17);
            this.chekingAcc_lbl.TabIndex = 2;
            this.chekingAcc_lbl.Text = "00.00";
            // 
            // savingAcc_lbl
            // 
            this.savingAcc_lbl.AutoSize = true;
            this.savingAcc_lbl.Location = new System.Drawing.Point(347, 148);
            this.savingAcc_lbl.Name = "savingAcc_lbl";
            this.savingAcc_lbl.Size = new System.Drawing.Size(44, 17);
            this.savingAcc_lbl.TabIndex = 3;
            this.savingAcc_lbl.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select the Bank Account:";
            // 
            // chekingAcc_rb
            // 
            this.chekingAcc_rb.AutoSize = true;
            this.chekingAcc_rb.Location = new System.Drawing.Point(221, 214);
            this.chekingAcc_rb.Name = "chekingAcc_rb";
            this.chekingAcc_rb.Size = new System.Drawing.Size(135, 21);
            this.chekingAcc_rb.TabIndex = 5;
            this.chekingAcc_rb.TabStop = true;
            this.chekingAcc_rb.Text = "Cheking Account";
            this.chekingAcc_rb.UseVisualStyleBackColor = true;
            // 
            // savingAcc_rb
            // 
            this.savingAcc_rb.AutoSize = true;
            this.savingAcc_rb.Location = new System.Drawing.Point(221, 241);
            this.savingAcc_rb.Name = "savingAcc_rb";
            this.savingAcc_rb.Size = new System.Drawing.Size(127, 21);
            this.savingAcc_rb.TabIndex = 6;
            this.savingAcc_rb.TabStop = true;
            this.savingAcc_rb.Text = "Saving Account";
            this.savingAcc_rb.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount in Euro:";
            // 
            // amount_tb
            // 
            this.amount_tb.Location = new System.Drawing.Point(197, 316);
            this.amount_tb.Name = "amount_tb";
            this.amount_tb.Size = new System.Drawing.Size(163, 22);
            this.amount_tb.TabIndex = 8;
            // 
            // deposit_btn
            // 
            this.deposit_btn.Location = new System.Drawing.Point(95, 356);
            this.deposit_btn.Name = "deposit_btn";
            this.deposit_btn.Size = new System.Drawing.Size(104, 54);
            this.deposit_btn.TabIndex = 9;
            this.deposit_btn.Text = "Deposit";
            this.deposit_btn.UseVisualStyleBackColor = true;
            this.deposit_btn.Click += new System.EventHandler(this.deposit_btn_Click);
            // 
            // withdraw_btn
            // 
            this.withdraw_btn.Location = new System.Drawing.Point(366, 356);
            this.withdraw_btn.Name = "withdraw_btn";
            this.withdraw_btn.Size = new System.Drawing.Size(104, 54);
            this.withdraw_btn.TabIndex = 10;
            this.withdraw_btn.Text = "Withdraw";
            this.withdraw_btn.UseVisualStyleBackColor = true;
            this.withdraw_btn.Click += new System.EventHandler(this.withdraw_btn_Click);
            // 
            // info_btn
            // 
            this.info_btn.Location = new System.Drawing.Point(223, 356);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(104, 54);
            this.info_btn.TabIndex = 11;
            this.info_btn.Text = "Show Information";
            this.info_btn.UseVisualStyleBackColor = true;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Number of Account:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Client Name:";
            // 
            // accNo_lbl
            // 
            this.accNo_lbl.AutoSize = true;
            this.accNo_lbl.Location = new System.Drawing.Point(347, 25);
            this.accNo_lbl.Name = "accNo_lbl";
            this.accNo_lbl.Size = new System.Drawing.Size(76, 17);
            this.accNo_lbl.TabIndex = 14;
            this.accNo_lbl.Text = "accountNo";
            // 
            // clientName_lbl
            // 
            this.clientName_lbl.AutoSize = true;
            this.clientName_lbl.Location = new System.Drawing.Point(347, 53);
            this.clientName_lbl.Name = "clientName_lbl";
            this.clientName_lbl.Size = new System.Drawing.Size(78, 17);
            this.clientName_lbl.TabIndex = 15;
            this.clientName_lbl.Text = "clientName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 540);
            this.Controls.Add(this.clientName_lbl);
            this.Controls.Add(this.accNo_lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.info_btn);
            this.Controls.Add(this.withdraw_btn);
            this.Controls.Add(this.deposit_btn);
            this.Controls.Add(this.amount_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.savingAcc_rb);
            this.Controls.Add(this.chekingAcc_rb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.savingAcc_lbl);
            this.Controls.Add(this.chekingAcc_lbl);
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
        private System.Windows.Forms.Label chekingAcc_lbl;
        private System.Windows.Forms.Label savingAcc_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton chekingAcc_rb;
        private System.Windows.Forms.RadioButton savingAcc_rb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amount_tb;
        private System.Windows.Forms.Button deposit_btn;
        private System.Windows.Forms.Button withdraw_btn;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label accNo_lbl;
        private System.Windows.Forms.Label clientName_lbl;
    }
}

