
namespace Assignment5_TruckManagment
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_boxToShip = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.rbt_TypeA = new System.Windows.Forms.RadioButton();
            this.rbt_TypeB = new System.Windows.Forms.RadioButton();
            this.rbt_TypeC = new System.Windows.Forms.RadioButton();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 488);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Controls.Add(this.lbl_Result);
            this.panel2.Controls.Add(this.btn_Calculate);
            this.panel2.Controls.Add(this.rbt_TypeC);
            this.panel2.Controls.Add(this.rbt_TypeB);
            this.panel2.Controls.Add(this.rbt_TypeA);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.tb_boxToShip);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(558, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 485);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Info for Truck A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max. number of pallets  per truck:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max. number of boxes per pallet: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "30";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Info for Truck B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Max. number of pallets  per truck:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Max. number of boxes per pallet: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Info for Truck C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Max. number of pallets  per truck:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Max. number of boxes per pallet: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(310, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "24";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(310, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "30";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(310, 333);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "28";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(310, 376);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "35";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Info About the Order";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 117);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(185, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "No. of boxes to be shipped: ";
            // 
            // tb_boxToShip
            // 
            this.tb_boxToShip.Location = new System.Drawing.Point(213, 114);
            this.tb_boxToShip.Name = "tb_boxToShip";
            this.tb_boxToShip.Size = new System.Drawing.Size(176, 22);
            this.tb_boxToShip.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 204);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(194, 17);
            this.label18.TabIndex = 3;
            this.label18.Text = "Type of the truck to be used: ";
            // 
            // rbt_TypeA
            // 
            this.rbt_TypeA.AutoSize = true;
            this.rbt_TypeA.Location = new System.Drawing.Point(269, 200);
            this.rbt_TypeA.Name = "rbt_TypeA";
            this.rbt_TypeA.Size = new System.Drawing.Size(74, 21);
            this.rbt_TypeA.TabIndex = 4;
            this.rbt_TypeA.TabStop = true;
            this.rbt_TypeA.Text = "Type A";
            this.rbt_TypeA.UseVisualStyleBackColor = true;
            // 
            // rbt_TypeB
            // 
            this.rbt_TypeB.AutoSize = true;
            this.rbt_TypeB.Location = new System.Drawing.Point(269, 235);
            this.rbt_TypeB.Name = "rbt_TypeB";
            this.rbt_TypeB.Size = new System.Drawing.Size(74, 21);
            this.rbt_TypeB.TabIndex = 5;
            this.rbt_TypeB.TabStop = true;
            this.rbt_TypeB.Text = "Type B";
            this.rbt_TypeB.UseVisualStyleBackColor = true;
            // 
            // rbt_TypeC
            // 
            this.rbt_TypeC.AutoSize = true;
            this.rbt_TypeC.Location = new System.Drawing.Point(269, 274);
            this.rbt_TypeC.Name = "rbt_TypeC";
            this.rbt_TypeC.Size = new System.Drawing.Size(74, 21);
            this.rbt_TypeC.TabIndex = 6;
            this.rbt_TypeC.TabStop = true;
            this.rbt_TypeC.Text = "Tyoe C";
            this.rbt_TypeC.UseVisualStyleBackColor = true;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(22, 350);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(197, 68);
            this.btn_Calculate.TabIndex = 7;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result.Location = new System.Drawing.Point(309, 376);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(69, 17);
            this.lbl_Result.TabIndex = 8;
            this.lbl_Result.Text = "RESULT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 507);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbt_TypeC;
        private System.Windows.Forms.RadioButton rbt_TypeB;
        private System.Windows.Forms.RadioButton rbt_TypeA;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_boxToShip;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label lbl_Result;
    }
}

