
namespace BickingTrip
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
            this.lbxMyTrips = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDistance = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxActions = new System.Windows.Forms.GroupBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowAverageRatings = new System.Windows.Forms.Button();
            this.btnSearchRating = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownRatingMax = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownRatinMin = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTransType = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbxActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRatingMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRatinMin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxMyTrips
            // 
            this.lbxMyTrips.FormattingEnabled = true;
            this.lbxMyTrips.ItemHeight = 20;
            this.lbxMyTrips.Location = new System.Drawing.Point(13, 26);
            this.lbxMyTrips.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxMyTrips.Name = "lbxMyTrips";
            this.lbxMyTrips.Size = new System.Drawing.Size(592, 184);
            this.lbxMyTrips.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbTransType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudRating);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudDistance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxTo);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(305, 247);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add trip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 48;
            this.label5.Text = "Rating:";
            // 
            // nudRating
            // 
            this.nudRating.DecimalPlaces = 1;
            this.nudRating.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudRating.Location = new System.Drawing.Point(110, 104);
            this.nudRating.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(169, 27);
            this.nudRating.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(247, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 22);
            this.label4.TabIndex = 46;
            this.label4.Text = "KM";
            // 
            // nudDistance
            // 
            this.nudDistance.DecimalPlaces = 3;
            this.nudDistance.Location = new System.Drawing.Point(110, 72);
            this.nudDistance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudDistance.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDistance.Name = "nudDistance";
            this.nudDistance.Size = new System.Drawing.Size(132, 27);
            this.nudDistance.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Distance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "To:";
            // 
            // tbxTo
            // 
            this.tbxTo.Location = new System.Drawing.Point(110, 36);
            this.tbxTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTo.Name = "tbxTo";
            this.tbxTo.Size = new System.Drawing.Size(171, 27);
            this.tbxTo.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 182);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(265, 28);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowAverageRatings);
            this.groupBox2.Controls.Add(this.btnSearchRating);
            this.groupBox2.Controls.Add(this.btnShowAll);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDownRatingMax);
            this.groupBox2.Controls.Add(this.tbxSearch);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.numericUpDownRatinMin);
            this.groupBox2.Controls.Add(this.lbxMyTrips);
            this.groupBox2.Location = new System.Drawing.Point(334, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(611, 414);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "My trips";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(13, 219);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(592, 28);
            this.btnShowAll.TabIndex = 23;
            this.btnShowAll.Text = "Show all";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "To:";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(50, 258);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(254, 27);
            this.tbxSearch.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(310, 256);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(295, 28);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search by Destination";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbxActions
            // 
            this.gbxActions.Controls.Add(this.btnInfo);
            this.gbxActions.Controls.Add(this.btnDelete);
            this.gbxActions.Location = new System.Drawing.Point(14, 308);
            this.gbxActions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxActions.Name = "gbxActions";
            this.gbxActions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxActions.Size = new System.Drawing.Size(305, 119);
            this.gbxActions.TabIndex = 43;
            this.gbxActions.TabStop = false;
            this.gbxActions.Text = "Selected trip";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(14, 31);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(265, 28);
            this.btnInfo.TabIndex = 45;
            this.btnInfo.Text = "Show info of selected trip";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(14, 68);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(265, 28);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete selected trip";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowAverageRatings
            // 
            this.btnShowAverageRatings.Location = new System.Drawing.Point(13, 357);
            this.btnShowAverageRatings.Name = "btnShowAverageRatings";
            this.btnShowAverageRatings.Size = new System.Drawing.Size(592, 29);
            this.btnShowAverageRatings.TabIndex = 49;
            this.btnShowAverageRatings.Text = "Show Destination Average Ratings";
            this.btnShowAverageRatings.UseVisualStyleBackColor = true;
            this.btnShowAverageRatings.Click += new System.EventHandler(this.btnShowAverageRatings_Click);
            // 
            // btnSearchRating
            // 
            this.btnSearchRating.Location = new System.Drawing.Point(432, 300);
            this.btnSearchRating.Name = "btnSearchRating";
            this.btnSearchRating.Size = new System.Drawing.Size(173, 29);
            this.btnSearchRating.TabIndex = 48;
            this.btnSearchRating.Text = "Search by Rating";
            this.btnSearchRating.UseVisualStyleBackColor = true;
            this.btnSearchRating.Click += new System.EventHandler(this.btnSearchRating_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Rating Max:";
            // 
            // numericUpDownRatingMax
            // 
            this.numericUpDownRatingMax.DecimalPlaces = 1;
            this.numericUpDownRatingMax.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownRatingMax.Location = new System.Drawing.Point(310, 304);
            this.numericUpDownRatingMax.Name = "numericUpDownRatingMax";
            this.numericUpDownRatingMax.Size = new System.Drawing.Size(99, 27);
            this.numericUpDownRatingMax.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Rating Min:";
            // 
            // numericUpDownRatinMin
            // 
            this.numericUpDownRatinMin.DecimalPlaces = 1;
            this.numericUpDownRatinMin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownRatinMin.Location = new System.Drawing.Point(103, 304);
            this.numericUpDownRatinMin.Name = "numericUpDownRatinMin";
            this.numericUpDownRatinMin.Size = new System.Drawing.Size(99, 27);
            this.numericUpDownRatinMin.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Trans. Type:";
            // 
            // cbTransType
            // 
            this.cbTransType.FormattingEnabled = true;
            this.cbTransType.Location = new System.Drawing.Point(110, 136);
            this.cbTransType.Name = "cbTransType";
            this.cbTransType.Size = new System.Drawing.Size(169, 28);
            this.cbTransType.TabIndex = 51;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(969, 438);
            this.Controls.Add(this.gbxActions);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "The bike app";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRatingMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRatinMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbxMyTrips;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbxActions;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDistance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTransType;
        private System.Windows.Forms.Button btnShowAverageRatings;
        private System.Windows.Forms.Button btnSearchRating;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownRatingMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownRatinMin;
    }
}

