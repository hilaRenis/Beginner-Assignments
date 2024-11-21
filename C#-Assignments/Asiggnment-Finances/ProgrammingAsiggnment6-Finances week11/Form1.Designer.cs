
namespace ProgrammingAsiggnment6_Finances_week11
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
            this.name_tb = new System.Windows.Forms.TextBox();
            this.ammount_upDown_tb = new System.Windows.Forms.NumericUpDown();
            this.showAllExpenses_lb = new System.Windows.Forms.ListBox();
            this.addExpense_btn = new System.Windows.Forms.Button();
            this.showExpense_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ammount_upDown2_tb = new System.Windows.Forms.NumericUpDown();
            this.showExpensesSame_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ammount_upDown_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammount_upDown2_tb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount:";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(163, 73);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(153, 22);
            this.name_tb.TabIndex = 2;
            // 
            // ammount_upDown_tb
            // 
            this.ammount_upDown_tb.DecimalPlaces = 2;
            this.ammount_upDown_tb.Location = new System.Drawing.Point(163, 101);
            this.ammount_upDown_tb.Name = "ammount_upDown_tb";
            this.ammount_upDown_tb.Size = new System.Drawing.Size(153, 22);
            this.ammount_upDown_tb.TabIndex = 3;
            // 
            // showAllExpenses_lb
            // 
            this.showAllExpenses_lb.FormattingEnabled = true;
            this.showAllExpenses_lb.ItemHeight = 16;
            this.showAllExpenses_lb.Location = new System.Drawing.Point(374, 73);
            this.showAllExpenses_lb.Name = "showAllExpenses_lb";
            this.showAllExpenses_lb.Size = new System.Drawing.Size(304, 356);
            this.showAllExpenses_lb.TabIndex = 4;
            // 
            // addExpense_btn
            // 
            this.addExpense_btn.Location = new System.Drawing.Point(163, 142);
            this.addExpense_btn.Name = "addExpense_btn";
            this.addExpense_btn.Size = new System.Drawing.Size(153, 66);
            this.addExpense_btn.TabIndex = 5;
            this.addExpense_btn.Text = "Add expense transaction log";
            this.addExpense_btn.UseVisualStyleBackColor = true;
            this.addExpense_btn.Click += new System.EventHandler(this.addExpense_btn_Click);
            // 
            // showExpense_btn
            // 
            this.showExpense_btn.Location = new System.Drawing.Point(83, 231);
            this.showExpense_btn.Name = "showExpense_btn";
            this.showExpense_btn.Size = new System.Drawing.Size(233, 33);
            this.showExpense_btn.TabIndex = 6;
            this.showExpense_btn.Text = "Show all the expenses";
            this.showExpense_btn.UseVisualStyleBackColor = true;
            this.showExpense_btn.Click += new System.EventHandler(this.showExpense_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount:";
            // 
            // ammount_upDown2_tb
            // 
            this.ammount_upDown2_tb.DecimalPlaces = 2;
            this.ammount_upDown2_tb.Location = new System.Drawing.Point(163, 296);
            this.ammount_upDown2_tb.Name = "ammount_upDown2_tb";
            this.ammount_upDown2_tb.Size = new System.Drawing.Size(153, 22);
            this.ammount_upDown2_tb.TabIndex = 8;
            // 
            // showExpensesSame_btn
            // 
            this.showExpensesSame_btn.Location = new System.Drawing.Point(83, 356);
            this.showExpensesSame_btn.Name = "showExpensesSame_btn";
            this.showExpensesSame_btn.Size = new System.Drawing.Size(233, 48);
            this.showExpensesSame_btn.TabIndex = 9;
            this.showExpensesSame_btn.Text = "Show expenses with the same amount";
            this.showExpensesSame_btn.UseVisualStyleBackColor = true;
            this.showExpensesSame_btn.Click += new System.EventHandler(this.showExpensesSame_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.showExpensesSame_btn);
            this.Controls.Add(this.ammount_upDown2_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showExpense_btn);
            this.Controls.Add(this.addExpense_btn);
            this.Controls.Add(this.showAllExpenses_lb);
            this.Controls.Add(this.ammount_upDown_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ammount_upDown_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammount_upDown2_tb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.NumericUpDown ammount_upDown_tb;
        private System.Windows.Forms.ListBox showAllExpenses_lb;
        private System.Windows.Forms.Button addExpense_btn;
        private System.Windows.Forms.Button showExpense_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ammount_upDown2_tb;
        private System.Windows.Forms.Button showExpensesSame_btn;
    }
}

