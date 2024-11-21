
namespace Programming_Assignment_1___Exploring_visual_controls
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
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rbtn_MakeRed = new System.Windows.Forms.RadioButton();
            this.rbtn_MakePurple = new System.Windows.Forms.RadioButton();
            this.rbtn_MakeWhite = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(101, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Information about me";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.trackBar1.Location = new System.Drawing.Point(101, 124);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(583, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(101, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "50";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(180, 221);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(504, 29);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // rbtn_MakeRed
            // 
            this.rbtn_MakeRed.AutoSize = true;
            this.rbtn_MakeRed.Location = new System.Drawing.Point(537, 289);
            this.rbtn_MakeRed.Name = "rbtn_MakeRed";
            this.rbtn_MakeRed.Size = new System.Drawing.Size(96, 24);
            this.rbtn_MakeRed.TabIndex = 4;
            this.rbtn_MakeRed.TabStop = true;
            this.rbtn_MakeRed.Text = "Make Red";
            this.rbtn_MakeRed.UseVisualStyleBackColor = true;
            this.rbtn_MakeRed.CheckedChanged += new System.EventHandler(this.rbtn_MakeRed_CheckedChanged);
            // 
            // rbtn_MakePurple
            // 
            this.rbtn_MakePurple.AutoSize = true;
            this.rbtn_MakePurple.Location = new System.Drawing.Point(537, 330);
            this.rbtn_MakePurple.Name = "rbtn_MakePurple";
            this.rbtn_MakePurple.Size = new System.Drawing.Size(112, 24);
            this.rbtn_MakePurple.TabIndex = 5;
            this.rbtn_MakePurple.TabStop = true;
            this.rbtn_MakePurple.Text = "Make Purple";
            this.rbtn_MakePurple.UseVisualStyleBackColor = true;
            this.rbtn_MakePurple.CheckedChanged += new System.EventHandler(this.rbtn_MakePurple_CheckedChanged);
            // 
            // rbtn_MakeWhite
            // 
            this.rbtn_MakeWhite.AutoSize = true;
            this.rbtn_MakeWhite.Location = new System.Drawing.Point(537, 369);
            this.rbtn_MakeWhite.Name = "rbtn_MakeWhite";
            this.rbtn_MakeWhite.Size = new System.Drawing.Size(109, 24);
            this.rbtn_MakeWhite.TabIndex = 6;
            this.rbtn_MakeWhite.TabStop = true;
            this.rbtn_MakeWhite.Text = "Make White";
            this.rbtn_MakeWhite.UseVisualStyleBackColor = true;
            this.rbtn_MakeWhite.CheckedChanged += new System.EventHandler(this.rbtn_MakeWhite_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtn_MakeWhite);
            this.Controls.Add(this.rbtn_MakePurple);
            this.Controls.Add(this.rbtn_MakeRed);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "My First Program";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton rbtn_MakeRed;
        private System.Windows.Forms.RadioButton rbtn_MakePurple;
        private System.Windows.Forms.RadioButton rbtn_MakeWhite;
    }
}

