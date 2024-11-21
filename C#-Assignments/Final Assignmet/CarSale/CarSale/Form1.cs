using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using CarSale.Models;

namespace CarSale
{
    public partial class Form1 : Form
    {
        Dealership dealership = new Dealership();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadDataInventory_Click(object sender, EventArgs e)
        {
            OpenFileDialog fl = new OpenFileDialog();
            fl.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            fl.ShowDialog();
            if (fl.FileName == "")
            {
                return;
            }
            using (var reader = new StreamReader(fl.FileName))
            {
                List<Car> listOfCars = new List<Car>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listOfCars.Add(new Car(values[0], values[1], Int32.Parse(values[2]), Int32.Parse(values[3])));
                }
                string carLog = "";
                dealership.GetCarInventory().loadCars(listOfCars, out carLog);
                MessageBox.Show(carLog);
                populateAllList();

            }
        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            Car car = new Car(tbBrand.Text, tbModel.Text, Int32.Parse(nPrice.Value.ToString()), Int32.Parse(nYear.Value.ToString()));

            string log = "";
            dealership.GetCarInventory().AddCarInventory(car,out log);
            populateAllList();
            clearCarData();
            MessageBox.Show(log == "OK" ? "The car was successfully added" : log);



        }
        private void clearCarData()
        {
            tbBrand.Text = "";
            tbModel.Text = "";
            nPrice.Value = 0;
            nYear.Value = 0;
        }


        private void populateAllList()
        {
            populateSales();
            populateListViewCarToSale();
            populateCustomerListView();
            populateListViewInventory();
            populateListViewCustomer();
        }
        private void populateListViewInventory()
        {
            lbCarInventory.Items.Clear();

            if (dealership.GetCarInventory() != null)
            {
                foreach (Car car in dealership.GetCarInventory().GetList())
                {
                    lbCarInventory.Items.Add(car.GetBrand() + " " + car.GetModel() + " " + car.GetProduceYear() + " " + car.GetPrice());
                }
            }
        }
        private void populateSales()
        {

            lbSoldCars.Items.Clear();
            foreach (Sale sale in dealership.getSales())
            {
                Car car = sale.GetCar();
                Customer customer = sale.GetCustomer();

                lbSoldCars.Items.Add(sale.GetDate().ToString("dd MMMM yyyy") + " " + car.GetBrand() + " " + car.GetModel() + " " + car.GetProduceYear() + " " + car.GetPrice() + " sale to => " + customer.GetCustomerName() + " " + customer.GetCustomerAddress() + " " + customer.GetCustomerPhoneNo() + " " + customer.GetCustomerZipCode() + " " + customer.GetCustomerCity());
            }

        }
        private void populateListViewCarToSale()
        {
            lbCarsToSell.Items.Clear();
            foreach (Car car in dealership.GetCarInventory().GetList())
            {
                lbCarsToSell.Items.Add(car.GetBrand() + " " + car.GetModel() + " " + car.GetProduceYear() + " " + car.GetPrice());
            }

        }
        private void populateCustomerListView()
        {
            lbToCustomer.Items.Clear();
            foreach (Customer customer in dealership.getCustomers())
            {
                lbToCustomer.Items.Add(customer.GetCustomerName() + " " + customer.GetCustomerAddress() + " " + customer.GetCustomerPhoneNo() + " " + customer.GetCustomerZipCode() + " " + customer.GetCustomerCity());
            }

        }
        private void populateListViewCustomer()
        {
            lbCustomer.Items.Clear();
            foreach (Customer customer in dealership.getCustomers())
            {
                lbCustomer.Items.Add(customer.GetCustomerName() + " " + customer.GetCustomerAddress() + " " + customer.GetCustomerPhoneNo() + " " + customer.GetCustomerZipCode() + " " + customer.GetCustomerCity());
            }

        }
        private void loadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog fl = new OpenFileDialog();
            fl.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            fl.ShowDialog();
            if (fl.FileName == "")
            {
                return;
            }
            using (var reader = new StreamReader(fl.FileName))
            {
                List<Car> listOfCars = new List<Car>();
                List<Customer> listOfCustomer = new List<Customer>();
                List<Sale> listOfSales = new List<Sale>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    if (values[0] == "Car")
                    {
                        listOfCars.Add(new Car(values[1], values[2], Int32.Parse(values[3]), Int32.Parse(values[4])));
                    }
                    if (values[0] == "Customer")
                    {
                        listOfCustomer.Add(new Customer(values[1], values[2], values[3], values[4], values[5]));
                    }

                    if (values[0] == "Sale")
                    {

                        listOfSales.Add(new Sale(new Customer(values[1], values[2], values[3], values[4], values[5]),
                            new Car(values[6], values[7], Int32.Parse(values[8]), Int32.Parse(values[9])),
                            DateTime.ParseExact(values[10], "dd MMMM yyyy", null)));
                    }
                }
                string sCarlog = "";
                CarInventory catalog = new CarInventory();
                catalog.loadCars(listOfCars, out sCarlog);
                dealership.loadCatalog(catalog);
                dealership.loadCustomer(listOfCustomer);
                dealership.loadSales(listOfSales);
                populateAllList();
                MessageBox.Show(String.Format("Data imported: Cars {0}, Customers {1}, Sales {2}", listOfCars.Count, listOfCustomer.Count, listOfSales.Count));
            }

        }

        private void btnSellCarToCustomer_Click(object sender, EventArgs e)
        {
            if (lbToCustomer.SelectedIndex != -1 && lbCarsToSell.SelectedIndex != -1 && dealership.GetCarInventory() != null)
            {
                dealership.saleCarToCustomer(dealership.getCustomers()[lbToCustomer.SelectedIndex], dealership.GetCarInventory().GetList()[lbCarsToSell.SelectedIndex]);
                populateAllList();
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customers = new Customer(tbCustomerName.Text, tbCustomerAddress.Text, tbCustomerPhoneNo.Text, tbCustomerZip.Text, tbCustomerCity.Text);
            dealership.addCustomer(customers);
            populateAllList();
            clearCustomerData();
            MessageBox.Show("The customer was successfully added");
        }
        private void clearCustomerData()
        {
            tbCustomerName.Text = "";
            tbCustomerAddress.Text = "";
            tbCustomerZip.Text = "";
            tbCustomerCity.Text = "";
            tbCustomerPhoneNo.Text = "";
        }

        private void btnDisplayInventory_Click(object sender, EventArgs e)
        {
            populateListViewInventory();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Car> lstToSearch = dealership.GetCarInventory().GetList();
            if (tbSearchBrand.Text != "")
            {
                lstToSearch = lstToSearch.FindAll(x => x.GetBrand().StartsWith(tbSearchBrand.Text));
            }
            if (tbSearchModel.Text != "")
            {
                lstToSearch = lstToSearch.FindAll(x => x.GetModel().StartsWith(tbSearchModel.Text));
            }
            if (nSearchPrice.Value != 0)
            {
                lstToSearch = lstToSearch.FindAll(x => x.GetPrice() == nSearchPrice.Value);
            }
            lbCarInventory.Items.Clear();
            foreach (Car car in lstToSearch)
            {
                lbCarInventory.Items.Add(car.GetBrand() + " " + car.GetModel() + " " + car.GetProduceYear() + " " + car.GetPrice());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SaveFileDialog dialogFileSave = new SaveFileDialog();
            dialogFileSave.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            dialogFileSave.Title = "Save database as csv file";
            dialogFileSave.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (dialogFileSave.FileName != "")
            {
                string csv = string.Empty;
                foreach (Car car in dealership.GetCarInventory().GetList())
                {
                    csv += "Car;" + car.GetBrand() + ";" + car.GetModel() + ";" + car.GetPrice() + ";" + car.GetProduceYear() + "\r\n";
                }
                foreach (Customer customer in dealership.getCustomers())
                {
                    csv += "Customer;" + customer.GetCustomerName() + ";" + customer.GetCustomerAddress() + ";" + customer.GetCustomerPhoneNo() + ";" + customer.GetCustomerZipCode() + ";" + customer.GetCustomerCity() + "\r\n";
                }
                foreach (Sale sale in dealership.getSales())
                {
                    Car car = sale.GetCar();
                    Customer customer = sale.GetCustomer();

                    csv += "Sale;" + customer.GetCustomerName() + ";" + customer.GetCustomerAddress() + ";" + customer.GetCustomerPhoneNo() + ";" + customer.GetCustomerZipCode() + ";" + customer.GetCustomerCity()
                        + ";" + car.GetBrand() + ";" + car.GetModel() + ";" + car.GetPrice() + ";" + car.GetProduceYear() + ";" + sale.GetDate().ToString("dd MMMM yyyy") + "\r\n";
                }
                File.WriteAllText(dialogFileSave.FileName, csv);
                MessageBox.Show("The database was successfully saved");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogFileSave = new SaveFileDialog();
            dialogFileSave.Filter = "Markdown files (*.md)|*.md|All files (*.*)|*.*";
            dialogFileSave.Title = "Save sales log as markdown file";
            dialogFileSave.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (dialogFileSave.FileName != "")
            {
                string md = string.Empty;
                foreach (Sale sale in dealership.getSales())
                {
                    Car car = sale.GetCar();
                    Customer customer = sale.GetCustomer();
                    md += "# " + sale.GetDate().ToString("dd MMMM yyyy") + " | " + car.GetBrand() + " " + car.GetModel() + "("  + car.GetProduceYear() + ")" + "\r\n";
                    md += "- *Price*: " + car.GetPrice() + "\r\n";
                    md += "- *Customer*: " + customer.GetCustomerName() + "\r\n";
                    md += "- *Phone no.*: " + customer.GetCustomerPhoneNo() + "\r\n";
                    md += "- *Address*: " + customer.GetCustomerAddress() + "\r\n";
                    md += "- *Zip code & city*: " + customer.GetCustomerZipCode() + customer.GetCustomerCity() + "\r\n";
                    md += "---" + "\r\n";
                }
                File.WriteAllText(dialogFileSave.FileName, md);
                MessageBox.Show("The sales log was successfully saved");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
