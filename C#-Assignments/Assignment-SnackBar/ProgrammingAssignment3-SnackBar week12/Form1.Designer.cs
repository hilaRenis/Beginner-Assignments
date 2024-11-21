
namespace ProgrammingAssignment3_SnackBar_week12
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tost_lbl = new System.Windows.Forms.Label();
            this.croissant_lbl = new System.Windows.Forms.Label();
            this.cheesecake_lbl = new System.Windows.Forms.Label();
            this.tost_tb = new System.Windows.Forms.TextBox();
            this.croissant_tb = new System.Windows.Forms.TextBox();
            this.cheesecake_tb = new System.Windows.Forms.TextBox();
            this.processOrder_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalRevenue_tb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.processOrder_btn);
            this.panel1.Controls.Add(this.cheesecake_tb);
            this.panel1.Controls.Add(this.croissant_tb);
            this.panel1.Controls.Add(this.tost_tb);
            this.panel1.Controls.Add(this.cheesecake_lbl);
            this.panel1.Controls.Add(this.croissant_lbl);
            this.panel1.Controls.Add(this.tost_lbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 425);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Form";
            // 
            // tost_lbl
            // 
            this.tost_lbl.AutoSize = true;
            this.tost_lbl.Location = new System.Drawing.Point(84, 69);
            this.tost_lbl.Name = "tost_lbl";
            this.tost_lbl.Size = new System.Drawing.Size(53, 17);
            this.tost_lbl.TabIndex = 1;
            this.tost_lbl.Text = "tost_lbl";
            // 
            // croissant_lbl
            // 
            this.croissant_lbl.AutoSize = true;
            this.croissant_lbl.Location = new System.Drawing.Point(84, 132);
            this.croissant_lbl.Name = "croissant_lbl";
            this.croissant_lbl.Size = new System.Drawing.Size(87, 17);
            this.croissant_lbl.TabIndex = 2;
            this.croissant_lbl.Text = "croissant_lbl";
            // 
            // cheesecake_lbl
            // 
            this.cheesecake_lbl.AutoSize = true;
            this.cheesecake_lbl.Location = new System.Drawing.Point(84, 197);
            this.cheesecake_lbl.Name = "cheesecake_lbl";
            this.cheesecake_lbl.Size = new System.Drawing.Size(106, 17);
            this.cheesecake_lbl.TabIndex = 3;
            this.cheesecake_lbl.Text = "cheesecake_lbl";
            // 
            // tost_tb
            // 
            this.tost_tb.Location = new System.Drawing.Point(231, 69);
            this.tost_tb.Name = "tost_tb";
            this.tost_tb.Size = new System.Drawing.Size(138, 22);
            this.tost_tb.TabIndex = 4;
            // 
            // croissant_tb
            // 
            this.croissant_tb.Location = new System.Drawing.Point(231, 132);
            this.croissant_tb.Name = "croissant_tb";
            this.croissant_tb.Size = new System.Drawing.Size(138, 22);
            this.croissant_tb.TabIndex = 5;
            // 
            // cheesecake_tb
            // 
            this.cheesecake_tb.Location = new System.Drawing.Point(231, 197);
            this.cheesecake_tb.Name = "cheesecake_tb";
            this.cheesecake_tb.Size = new System.Drawing.Size(138, 22);
            this.cheesecake_tb.TabIndex = 5;
            // 
            // processOrder_btn
            // 
            this.processOrder_btn.Location = new System.Drawing.Point(87, 278);
            this.processOrder_btn.Name = "processOrder_btn";
            this.processOrder_btn.Size = new System.Drawing.Size(282, 55);
            this.processOrder_btn.TabIndex = 6;
            this.processOrder_btn.Text = "Process Order";
            this.processOrder_btn.UseVisualStyleBackColor = true;
            this.processOrder_btn.Click += new System.EventHandler(this.processOrder_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Revenue: ";
            // 
            // totalRevenue_tb
            // 
            this.totalRevenue_tb.Location = new System.Drawing.Point(625, 82);
            this.totalRevenue_tb.Name = "totalRevenue_tb";
            this.totalRevenue_tb.Size = new System.Drawing.Size(138, 22);
            this.totalRevenue_tb.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalRevenue_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button processOrder_btn;
        private System.Windows.Forms.TextBox cheesecake_tb;
        private System.Windows.Forms.TextBox croissant_tb;
        private System.Windows.Forms.TextBox tost_tb;
        private System.Windows.Forms.Label cheesecake_lbl;
        private System.Windows.Forms.Label croissant_lbl;
        private System.Windows.Forms.Label tost_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalRevenue_tb;
    }
}

