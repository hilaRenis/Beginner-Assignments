
namespace Programming_Assignment_3__BMI_calculator_week_2
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
            this.lbl_Pesha = new System.Windows.Forms.Label();
            this.lbl_Gjatesia = new System.Windows.Forms.Label();
            this.tb_Pesha = new System.Windows.Forms.TextBox();
            this.tb_Gjatesia = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.lbl_PergjigjiaBMI = new System.Windows.Forms.Label();
            this.lbl_PergjigjiaPerPeshen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Pesha
            // 
            this.lbl_Pesha.AutoSize = true;
            this.lbl_Pesha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pesha.Location = new System.Drawing.Point(80, 63);
            this.lbl_Pesha.Name = "lbl_Pesha";
            this.lbl_Pesha.Size = new System.Drawing.Size(106, 20);
            this.lbl_Pesha.TabIndex = 0;
            this.lbl_Pesha.Text = "Weight in kg: ";
            // 
            // lbl_Gjatesia
            // 
            this.lbl_Gjatesia.AutoSize = true;
            this.lbl_Gjatesia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Gjatesia.Location = new System.Drawing.Point(80, 119);
            this.lbl_Gjatesia.Name = "lbl_Gjatesia";
            this.lbl_Gjatesia.Size = new System.Drawing.Size(130, 20);
            this.lbl_Gjatesia.TabIndex = 1;
            this.lbl_Gjatesia.Text = "Height in meters:";
            // 
            // tb_Pesha
            // 
            this.tb_Pesha.Location = new System.Drawing.Point(272, 60);
            this.tb_Pesha.Name = "tb_Pesha";
            this.tb_Pesha.Size = new System.Drawing.Size(125, 27);
            this.tb_Pesha.TabIndex = 2;
            // 
            // tb_Gjatesia
            // 
            this.tb_Gjatesia.Location = new System.Drawing.Point(272, 116);
            this.tb_Gjatesia.Name = "tb_Gjatesia";
            this.tb_Gjatesia.Size = new System.Drawing.Size(125, 27);
            this.tb_Gjatesia.TabIndex = 3;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Calculate.Location = new System.Drawing.Point(272, 189);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(125, 70);
            this.btn_Calculate.TabIndex = 4;
            this.btn_Calculate.Text = "Calculate body mass index";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // lbl_PergjigjiaBMI
            // 
            this.lbl_PergjigjiaBMI.AutoSize = true;
            this.lbl_PergjigjiaBMI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PergjigjiaBMI.Location = new System.Drawing.Point(272, 294);
            this.lbl_PergjigjiaBMI.Name = "lbl_PergjigjiaBMI";
            this.lbl_PergjigjiaBMI.Size = new System.Drawing.Size(95, 20);
            this.lbl_PergjigjiaBMI.TabIndex = 5;
            this.lbl_PergjigjiaBMI.Text = "Your bmi is: ";
            // 
            // lbl_PergjigjiaPerPeshen
            // 
            this.lbl_PergjigjiaPerPeshen.AutoSize = true;
            this.lbl_PergjigjiaPerPeshen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PergjigjiaPerPeshen.Location = new System.Drawing.Point(12, 328);
            this.lbl_PergjigjiaPerPeshen.Name = "lbl_PergjigjiaPerPeshen";
            this.lbl_PergjigjiaPerPeshen.Size = new System.Drawing.Size(0, 20);
            this.lbl_PergjigjiaPerPeshen.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_PergjigjiaPerPeshen);
            this.Controls.Add(this.lbl_PergjigjiaBMI);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.tb_Gjatesia);
            this.Controls.Add(this.tb_Pesha);
            this.Controls.Add(this.lbl_Gjatesia);
            this.Controls.Add(this.lbl_Pesha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Pesha;
        private System.Windows.Forms.Label lbl_Gjatesia;
        private System.Windows.Forms.TextBox tb_Pesha;
        private System.Windows.Forms.TextBox tb_Gjatesia;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label lbl_PergjigjiaBMI;
        private System.Windows.Forms.Label lbl_PergjigjiaPerPeshen;
    }
}

