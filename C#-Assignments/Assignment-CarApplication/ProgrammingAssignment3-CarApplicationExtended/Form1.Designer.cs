
namespace ProgrammingAssignment3_CarApplicationExtended
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
            this.displayInformation_lbl = new System.Windows.Forms.Label();
            this.accelerate_btn = new System.Windows.Forms.Button();
            this.breaks_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Ferrari_rb = new System.Windows.Forms.RadioButton();
            this.Porsche_rb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // displayInformation_lbl
            // 
            this.displayInformation_lbl.AutoSize = true;
            this.displayInformation_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayInformation_lbl.Location = new System.Drawing.Point(266, 93);
            this.displayInformation_lbl.Name = "displayInformation_lbl";
            this.displayInformation_lbl.Size = new System.Drawing.Size(191, 17);
            this.displayInformation_lbl.TabIndex = 1;
            this.displayInformation_lbl.Text = "Information about the car";
            // 
            // accelerate_btn
            // 
            this.accelerate_btn.Location = new System.Drawing.Point(160, 141);
            this.accelerate_btn.Name = "accelerate_btn";
            this.accelerate_btn.Size = new System.Drawing.Size(120, 60);
            this.accelerate_btn.TabIndex = 2;
            this.accelerate_btn.Text = "Accelerate";
            this.accelerate_btn.UseVisualStyleBackColor = true;
            this.accelerate_btn.Click += new System.EventHandler(this.accelerate_btn_Click);
            // 
            // breaks_btn
            // 
            this.breaks_btn.Location = new System.Drawing.Point(454, 141);
            this.breaks_btn.Name = "breaks_btn";
            this.breaks_btn.Size = new System.Drawing.Size(120, 60);
            this.breaks_btn.TabIndex = 3;
            this.breaks_btn.Text = "Use the Breaks";
            this.breaks_btn.UseVisualStyleBackColor = true;
            this.breaks_btn.Click += new System.EventHandler(this.breaks_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Information about the car";
            // 
            // Ferrari_rb
            // 
            this.Ferrari_rb.AutoSize = true;
            this.Ferrari_rb.Location = new System.Drawing.Point(284, 277);
            this.Ferrari_rb.Name = "Ferrari_rb";
            this.Ferrari_rb.Size = new System.Drawing.Size(132, 21);
            this.Ferrari_rb.TabIndex = 5;
            this.Ferrari_rb.TabStop = true;
            this.Ferrari_rb.Text = "Ferrari 812 GTS";
            this.Ferrari_rb.UseVisualStyleBackColor = true;
            // 
            // Porsche_rb
            // 
            this.Porsche_rb.AutoSize = true;
            this.Porsche_rb.Location = new System.Drawing.Point(284, 304);
            this.Porsche_rb.Name = "Porsche_rb";
            this.Porsche_rb.Size = new System.Drawing.Size(151, 21);
            this.Porsche_rb.TabIndex = 6;
            this.Porsche_rb.TabStop = true;
            this.Porsche_rb.Text = "Porsche 911 Turbo";
            this.Porsche_rb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Porsche_rb);
            this.Controls.Add(this.Ferrari_rb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.breaks_btn);
            this.Controls.Add(this.accelerate_btn);
            this.Controls.Add(this.displayInformation_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayInformation_lbl;
        private System.Windows.Forms.Button accelerate_btn;
        private System.Windows.Forms.Button breaks_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Ferrari_rb;
        private System.Windows.Forms.RadioButton Porsche_rb;
    }
}

