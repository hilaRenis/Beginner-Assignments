
namespace Bakery
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowOfferedSandwiches = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbBreadFilter = new System.Windows.Forms.ComboBox();
            this.btnAddSandwich = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbxMenu = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.lblSandwichInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowOfferedSandwiches);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbBreadFilter);
            this.groupBox1.Controls.Add(this.btnAddSandwich);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lbxMenu);
            this.groupBox1.Location = new System.Drawing.Point(7, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(450, 429);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btnShowOfferedSandwiches
            // 
            this.btnShowOfferedSandwiches.Location = new System.Drawing.Point(4, 52);
            this.btnShowOfferedSandwiches.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowOfferedSandwiches.Name = "btnShowOfferedSandwiches";
            this.btnShowOfferedSandwiches.Size = new System.Drawing.Size(442, 29);
            this.btnShowOfferedSandwiches.TabIndex = 6;
            this.btnShowOfferedSandwiches.Text = "Show offered sandwiches";
            this.btnShowOfferedSandwiches.UseVisualStyleBackColor = true;
            this.btnShowOfferedSandwiches.Click += new System.EventHandler(this.btnShowOfferedSandwiches_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bread filter:";
            // 
            // cbbBreadFilter
            // 
            this.cbbBreadFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBreadFilter.FormattingEnabled = true;
            this.cbbBreadFilter.Items.AddRange(new object[] {
            "",
            "Ciabatta",
            "Focaccia",
            "Sour Dough",
            "Rye",
            "Whole Wheat"});
            this.cbbBreadFilter.Location = new System.Drawing.Point(86, 24);
            this.cbbBreadFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbbBreadFilter.Name = "cbbBreadFilter";
            this.cbbBreadFilter.Size = new System.Drawing.Size(360, 28);
            this.cbbBreadFilter.TabIndex = 4;
            // 
            // btnAddSandwich
            // 
            this.btnAddSandwich.Location = new System.Drawing.Point(5, 365);
            this.btnAddSandwich.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSandwich.Name = "btnAddSandwich";
            this.btnAddSandwich.Size = new System.Drawing.Size(441, 29);
            this.btnAddSandwich.TabIndex = 3;
            this.btnAddSandwich.Text = "Add new Sandwich";
            this.btnAddSandwich.UseVisualStyleBackColor = true;
            this.btnAddSandwich.Click += new System.EventHandler(this.btnAddSandwich_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(279, 396);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(167, 29);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(5, 396);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save data";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbxMenu
            // 
            this.lbxMenu.FormattingEnabled = true;
            this.lbxMenu.ItemHeight = 20;
            this.lbxMenu.Location = new System.Drawing.Point(4, 85);
            this.lbxMenu.Margin = new System.Windows.Forms.Padding(2);
            this.lbxMenu.Name = "lbxMenu";
            this.lbxMenu.Size = new System.Drawing.Size(442, 264);
            this.lbxMenu.TabIndex = 0;
            this.lbxMenu.SelectedValueChanged += new System.EventHandler(this.lbxMenu_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.btnRevenue);
            this.groupBox2.Controls.Add(this.btnSell);
            this.groupBox2.Controls.Add(this.lblSandwichInfo);
            this.groupBox2.Location = new System.Drawing.Point(461, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(404, 284);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cart";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(302, 250);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "with VAT";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnRevenue
            // 
            this.btnRevenue.Location = new System.Drawing.Point(4, 250);
            this.btnRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(292, 29);
            this.btnRevenue.TabIndex = 2;
            this.btnRevenue.Text = "Show total revenue";
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(4, 218);
            this.btnSell.Margin = new System.Windows.Forms.Padding(2);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(292, 29);
            this.btnSell.TabIndex = 1;
            this.btnSell.Text = "Sell selected sandwhich";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // lblSandwichInfo
            // 
            this.lblSandwichInfo.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSandwichInfo.Location = new System.Drawing.Point(4, 24);
            this.lblSandwichInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSandwichInfo.Name = "lblSandwichInfo";
            this.lblSandwichInfo.Size = new System.Drawing.Size(292, 192);
            this.lblSandwichInfo.TabIndex = 0;
            this.lblSandwichInfo.Text = "[Sandwich Data]";
            this.lblSandwichInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price of Sandwich Sold (with VAT):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(716, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "0.00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 441);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lbxMenu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lblSandwichInfo;
        private System.Windows.Forms.Button btnAddSandwich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbBreadFilter;
        private System.Windows.Forms.Button btnShowOfferedSandwiches;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}