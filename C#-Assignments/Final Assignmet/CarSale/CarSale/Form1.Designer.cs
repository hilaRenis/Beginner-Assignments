
namespace CarSale
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
            this.tabPageAddNewCar = new System.Windows.Forms.TabPage();
            this.nYear = new System.Windows.Forms.NumericUpDown();
            this.nPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAddNewCar = new System.Windows.Forms.Button();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.nSearchPrice = new System.Windows.Forms.NumericUpDown();
            this.btnDisplayInventory = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchModel = new System.Windows.Forms.TextBox();
            this.tbSearchBrand = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLoadDataInventory = new System.Windows.Forms.Button();
            this.lbCarInventory = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPageCarSold = new System.Windows.Forms.TabPage();
            this.lbSoldCars = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.tabPageAddCustomer = new System.Windows.Forms.TabPage();
            this.tbCustomerCity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.tbCustomerPhoneNo = new System.Windows.Forms.TextBox();
            this.tbCustomerZip = new System.Windows.Forms.TextBox();
            this.tbCustomerAddress = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageSellCar = new System.Windows.Forms.TabPage();
            this.btnSellCarToCustomer = new System.Windows.Forms.Button();
            this.lbCarsToSell = new System.Windows.Forms.ListBox();
            this.lbToCustomer = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.loadData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbCustomer = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPageAddNewCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSearchPrice)).BeginInit();
            this.tabPageCarSold.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.tabPageAddCustomer.SuspendLayout();
            this.tabPageSellCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageAddNewCar
            // 
            this.tabPageAddNewCar.Controls.Add(this.nYear);
            this.tabPageAddNewCar.Controls.Add(this.nPrice);
            this.tabPageAddNewCar.Controls.Add(this.btnAddNewCar);
            this.tabPageAddNewCar.Controls.Add(this.tbModel);
            this.tabPageAddNewCar.Controls.Add(this.tbBrand);
            this.tabPageAddNewCar.Controls.Add(this.label4);
            this.tabPageAddNewCar.Controls.Add(this.label3);
            this.tabPageAddNewCar.Controls.Add(this.label2);
            this.tabPageAddNewCar.Controls.Add(this.label1);
            this.tabPageAddNewCar.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddNewCar.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAddNewCar.Name = "tabPageAddNewCar";
            this.tabPageAddNewCar.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageAddNewCar.Size = new System.Drawing.Size(636, 284);
            this.tabPageAddNewCar.TabIndex = 0;
            this.tabPageAddNewCar.Text = "Add New Car";
            this.tabPageAddNewCar.UseVisualStyleBackColor = true;
            // 
            // nYear
            // 
            this.nYear.Location = new System.Drawing.Point(340, 148);
            this.nYear.Margin = new System.Windows.Forms.Padding(2);
            this.nYear.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nYear.Name = "nYear";
            this.nYear.Size = new System.Drawing.Size(154, 20);
            this.nYear.TabIndex = 4;
            // 
            // nPrice
            // 
            this.nPrice.Location = new System.Drawing.Point(340, 114);
            this.nPrice.Margin = new System.Windows.Forms.Padding(2);
            this.nPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nPrice.Name = "nPrice";
            this.nPrice.Size = new System.Drawing.Size(154, 20);
            this.nPrice.TabIndex = 3;
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.Location = new System.Drawing.Point(242, 188);
            this.btnAddNewCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(94, 33);
            this.btnAddNewCar.TabIndex = 8;
            this.btnAddNewCar.Text = "Add New Car";
            this.btnAddNewCar.UseVisualStyleBackColor = true;
            this.btnAddNewCar.Click += new System.EventHandler(this.btnAddNewCar_Click);
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(340, 76);
            this.tbModel.Margin = new System.Windows.Forms.Padding(2);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(154, 20);
            this.tbModel.TabIndex = 2;
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(340, 43);
            this.tbBrand.Margin = new System.Windows.Forms.Padding(2);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(154, 20);
            this.tbBrand.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year Produce:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageInventory);
            this.tabControl1.Controls.Add(this.tabPageCarSold);
            this.tabControl1.Controls.Add(this.tabCustomers);
            this.tabControl1.Controls.Add(this.tabPageAddNewCar);
            this.tabControl1.Controls.Add(this.tabPageAddCustomer);
            this.tabControl1.Controls.Add(this.tabPageSellCar);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 310);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageInventory
            // 
            this.tabPageInventory.Controls.Add(this.nSearchPrice);
            this.tabPageInventory.Controls.Add(this.btnDisplayInventory);
            this.tabPageInventory.Controls.Add(this.btnSearch);
            this.tabPageInventory.Controls.Add(this.tbSearchModel);
            this.tabPageInventory.Controls.Add(this.tbSearchBrand);
            this.tabPageInventory.Controls.Add(this.label16);
            this.tabPageInventory.Controls.Add(this.label15);
            this.tabPageInventory.Controls.Add(this.label14);
            this.tabPageInventory.Controls.Add(this.label13);
            this.tabPageInventory.Controls.Add(this.btnLoadDataInventory);
            this.tabPageInventory.Controls.Add(this.lbCarInventory);
            this.tabPageInventory.Controls.Add(this.label12);
            this.tabPageInventory.Location = new System.Drawing.Point(4, 22);
            this.tabPageInventory.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageInventory.Name = "tabPageInventory";
            this.tabPageInventory.Size = new System.Drawing.Size(636, 284);
            this.tabPageInventory.TabIndex = 3;
            this.tabPageInventory.Text = "Cars in Inventory";
            this.tabPageInventory.UseVisualStyleBackColor = true;
            // 
            // nSearchPrice
            // 
            this.nSearchPrice.Location = new System.Drawing.Point(436, 104);
            this.nSearchPrice.Margin = new System.Windows.Forms.Padding(2);
            this.nSearchPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nSearchPrice.Name = "nSearchPrice";
            this.nSearchPrice.Size = new System.Drawing.Size(154, 20);
            this.nSearchPrice.TabIndex = 20;
            // 
            // btnDisplayInventory
            // 
            this.btnDisplayInventory.Location = new System.Drawing.Point(377, 169);
            this.btnDisplayInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisplayInventory.Name = "btnDisplayInventory";
            this.btnDisplayInventory.Size = new System.Drawing.Size(212, 28);
            this.btnDisplayInventory.TabIndex = 16;
            this.btnDisplayInventory.Text = "Display all Inventory";
            this.btnDisplayInventory.UseVisualStyleBackColor = true;
            this.btnDisplayInventory.Click += new System.EventHandler(this.btnDisplayInventory_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(378, 138);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(212, 27);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearchModel
            // 
            this.tbSearchModel.Location = new System.Drawing.Point(436, 65);
            this.tbSearchModel.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchModel.Name = "tbSearchModel";
            this.tbSearchModel.Size = new System.Drawing.Size(154, 20);
            this.tbSearchModel.TabIndex = 13;
            // 
            // tbSearchBrand
            // 
            this.tbSearchBrand.Location = new System.Drawing.Point(436, 24);
            this.tbSearchBrand.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchBrand.Name = "tbSearchBrand";
            this.tbSearchBrand.Size = new System.Drawing.Size(154, 20);
            this.tbSearchBrand.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(374, 104);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Price:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(374, 67);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Model:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(374, 26);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Brand:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(485, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Search Car";
            // 
            // btnLoadDataInventory
            // 
            this.btnLoadDataInventory.Location = new System.Drawing.Point(240, 240);
            this.btnLoadDataInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadDataInventory.Name = "btnLoadDataInventory";
            this.btnLoadDataInventory.Size = new System.Drawing.Size(86, 28);
            this.btnLoadDataInventory.TabIndex = 7;
            this.btnLoadDataInventory.Text = "Load car list";
            this.btnLoadDataInventory.UseVisualStyleBackColor = true;
            this.btnLoadDataInventory.Click += new System.EventHandler(this.btnLoadDataInventory_Click);
            // 
            // lbCarInventory
            // 
            this.lbCarInventory.FormattingEnabled = true;
            this.lbCarInventory.Location = new System.Drawing.Point(9, 24);
            this.lbCarInventory.Margin = new System.Windows.Forms.Padding(2);
            this.lbCarInventory.Name = "lbCarInventory";
            this.lbCarInventory.Size = new System.Drawing.Size(318, 212);
            this.lbCarInventory.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(103, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Cars that are in Inventory";
            // 
            // tabPageCarSold
            // 
            this.tabPageCarSold.Controls.Add(this.lbSoldCars);
            this.tabPageCarSold.Controls.Add(this.label11);
            this.tabPageCarSold.Location = new System.Drawing.Point(4, 22);
            this.tabPageCarSold.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageCarSold.Name = "tabPageCarSold";
            this.tabPageCarSold.Size = new System.Drawing.Size(636, 284);
            this.tabPageCarSold.TabIndex = 2;
            this.tabPageCarSold.Text = "Cars that are Sold";
            this.tabPageCarSold.UseVisualStyleBackColor = true;
            // 
            // lbSoldCars
            // 
            this.lbSoldCars.FormattingEnabled = true;
            this.lbSoldCars.Location = new System.Drawing.Point(21, 26);
            this.lbSoldCars.Margin = new System.Windows.Forms.Padding(2);
            this.lbSoldCars.Name = "lbSoldCars";
            this.lbSoldCars.Size = new System.Drawing.Size(599, 225);
            this.lbSoldCars.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(270, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cars that are Sold";
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.lbCustomer);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Size = new System.Drawing.Size(636, 284);
            this.tabCustomers.TabIndex = 5;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // tabPageAddCustomer
            // 
            this.tabPageAddCustomer.Controls.Add(this.tbCustomerCity);
            this.tabPageAddCustomer.Controls.Add(this.label10);
            this.tabPageAddCustomer.Controls.Add(this.btnAddCustomer);
            this.tabPageAddCustomer.Controls.Add(this.tbCustomerPhoneNo);
            this.tabPageAddCustomer.Controls.Add(this.tbCustomerZip);
            this.tabPageAddCustomer.Controls.Add(this.tbCustomerAddress);
            this.tabPageAddCustomer.Controls.Add(this.tbCustomerName);
            this.tabPageAddCustomer.Controls.Add(this.label8);
            this.tabPageAddCustomer.Controls.Add(this.label7);
            this.tabPageAddCustomer.Controls.Add(this.label6);
            this.tabPageAddCustomer.Controls.Add(this.label5);
            this.tabPageAddCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAddCustomer.Name = "tabPageAddCustomer";
            this.tabPageAddCustomer.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageAddCustomer.Size = new System.Drawing.Size(636, 284);
            this.tabPageAddCustomer.TabIndex = 1;
            this.tabPageAddCustomer.Text = "Add Customer";
            this.tabPageAddCustomer.UseVisualStyleBackColor = true;
            // 
            // tbCustomerCity
            // 
            this.tbCustomerCity.Location = new System.Drawing.Point(330, 104);
            this.tbCustomerCity.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerCity.Name = "tbCustomerCity";
            this.tbCustomerCity.Size = new System.Drawing.Size(134, 20);
            this.tbCustomerCity.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 107);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "City";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(174, 220);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(290, 29);
            this.btnAddCustomer.TabIndex = 12;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // tbCustomerPhoneNo
            // 
            this.tbCustomerPhoneNo.Location = new System.Drawing.Point(330, 128);
            this.tbCustomerPhoneNo.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerPhoneNo.Name = "tbCustomerPhoneNo";
            this.tbCustomerPhoneNo.Size = new System.Drawing.Size(134, 20);
            this.tbCustomerPhoneNo.TabIndex = 8;
            // 
            // tbCustomerZip
            // 
            this.tbCustomerZip.Location = new System.Drawing.Point(330, 80);
            this.tbCustomerZip.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerZip.Name = "tbCustomerZip";
            this.tbCustomerZip.Size = new System.Drawing.Size(134, 20);
            this.tbCustomerZip.TabIndex = 6;
            // 
            // tbCustomerAddress
            // 
            this.tbCustomerAddress.Location = new System.Drawing.Point(330, 56);
            this.tbCustomerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerAddress.Name = "tbCustomerAddress";
            this.tbCustomerAddress.Size = new System.Drawing.Size(134, 20);
            this.tbCustomerAddress.TabIndex = 5;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(330, 32);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(134, 20);
            this.tbCustomerName.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 131);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Phone Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "ZipCode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Customer Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Customer Name:";
            // 
            // tabPageSellCar
            // 
            this.tabPageSellCar.Controls.Add(this.btnSellCarToCustomer);
            this.tabPageSellCar.Controls.Add(this.lbCarsToSell);
            this.tabPageSellCar.Controls.Add(this.lbToCustomer);
            this.tabPageSellCar.Location = new System.Drawing.Point(4, 22);
            this.tabPageSellCar.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageSellCar.Name = "tabPageSellCar";
            this.tabPageSellCar.Size = new System.Drawing.Size(636, 284);
            this.tabPageSellCar.TabIndex = 4;
            this.tabPageSellCar.Text = "Sell Car";
            this.tabPageSellCar.UseVisualStyleBackColor = true;
            // 
            // btnSellCarToCustomer
            // 
            this.btnSellCarToCustomer.Location = new System.Drawing.Point(244, 107);
            this.btnSellCarToCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSellCarToCustomer.Name = "btnSellCarToCustomer";
            this.btnSellCarToCustomer.Size = new System.Drawing.Size(142, 28);
            this.btnSellCarToCustomer.TabIndex = 2;
            this.btnSellCarToCustomer.Text = "Sell car to customer";
            this.btnSellCarToCustomer.UseVisualStyleBackColor = true;
            this.btnSellCarToCustomer.Click += new System.EventHandler(this.btnSellCarToCustomer_Click);
            // 
            // lbCarsToSell
            // 
            this.lbCarsToSell.FormattingEnabled = true;
            this.lbCarsToSell.Location = new System.Drawing.Point(391, 19);
            this.lbCarsToSell.Margin = new System.Windows.Forms.Padding(2);
            this.lbCarsToSell.Name = "lbCarsToSell";
            this.lbCarsToSell.Size = new System.Drawing.Size(220, 212);
            this.lbCarsToSell.TabIndex = 1;
            // 
            // lbToCustomer
            // 
            this.lbToCustomer.FormattingEnabled = true;
            this.lbToCustomer.Location = new System.Drawing.Point(21, 19);
            this.lbToCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.lbToCustomer.Name = "lbToCustomer";
            this.lbToCustomer.Size = new System.Drawing.Size(220, 212);
            this.lbToCustomer.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.Location = new System.Drawing.Point(406, 332);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Export sales(as MD file)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loadData
            // 
            this.loadData.BackColor = System.Drawing.Color.MintCream;
            this.loadData.Location = new System.Drawing.Point(11, 332);
            this.loadData.Margin = new System.Windows.Forms.Padding(2);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(129, 28);
            this.loadData.TabIndex = 8;
            this.loadData.Text = "Load the data from file";
            this.loadData.UseVisualStyleBackColor = false;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Location = new System.Drawing.Point(144, 332);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbCustomer
            // 
            this.lbCustomer.FormattingEnabled = true;
            this.lbCustomer.Location = new System.Drawing.Point(18, 18);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(603, 264);
            this.lbCustomer.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(572, 332);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 28);
            this.button3.TabIndex = 11;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 371);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabPageAddNewCar.ResumeLayout(false);
            this.tabPageAddNewCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageInventory.ResumeLayout(false);
            this.tabPageInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSearchPrice)).EndInit();
            this.tabPageCarSold.ResumeLayout(false);
            this.tabPageCarSold.PerformLayout();
            this.tabCustomers.ResumeLayout(false);
            this.tabPageAddCustomer.ResumeLayout(false);
            this.tabPageAddCustomer.PerformLayout();
            this.tabPageSellCar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageAddNewCar;
        private System.Windows.Forms.Button btnAddNewCar;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAddCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox tbCustomerPhoneNo;
        private System.Windows.Forms.TextBox tbCustomerZip;
        private System.Windows.Forms.TextBox tbCustomerAddress;
        private System.Windows.Forms.TabPage tabPageCarSold;
        private System.Windows.Forms.ListBox lbSoldCars;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPageInventory;
        private System.Windows.Forms.Button btnLoadDataInventory;
        private System.Windows.Forms.ListBox lbCarInventory;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbSearchModel;
        private System.Windows.Forms.TextBox tbSearchBrand;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDisplayInventory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabPage tabPageSellCar;
        private System.Windows.Forms.Button btnSellCarToCustomer;
        private System.Windows.Forms.ListBox lbCarsToSell;
        private System.Windows.Forms.ListBox lbToCustomer;
        private System.Windows.Forms.NumericUpDown nSearchPrice;
        private System.Windows.Forms.NumericUpDown nYear;
        private System.Windows.Forms.NumericUpDown nPrice;
        private System.Windows.Forms.Button loadData;
        private System.Windows.Forms.TextBox tbCustomerCity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.ListBox lbCustomer;
        private System.Windows.Forms.Button button3;
    }
}

