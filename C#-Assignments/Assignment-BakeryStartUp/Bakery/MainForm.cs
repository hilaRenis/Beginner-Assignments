using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Bakery
{
    public partial class MainForm : Form
    {

        public Bakery bakery_store;
        
        
        public MainForm()
        {
            InitializeComponent();

            this.bakery_store = new Bakery("Bakery Fontys");

            // Init GUI
            lblSandwichInfo.Text = String.Empty;

            this.cbbBreadFilter.DataSource = Enum.GetValues(typeof(BreadType));
        }

        private void btnAddSandwich_Click(object sender, EventArgs e)
        {
            AddForm the_addform = new AddForm(this.bakery_store);
            the_addform.ShowDialog();
        }

        private void btnShowOfferedSandwiches_Click(object sender, EventArgs e)
        {
            BreadType _bread = (BreadType)cbbBreadFilter.SelectedItem;

            Sandwich[] ss = this.bakery_store.GetAvailableSandwiches(_bread);

            this.lbxMenu.Items.Clear();
            foreach (Sandwich a in ss)
            {
                this.lbxMenu.Items.Add($"{a.GetName().ToString()}, {a.GetPrice().ToString()}");
            }
        }

        
        private void lbxMenu_SelectedValueChanged(object sender, EventArgs e)
        {
            BreadType _bread = (BreadType)cbbBreadFilter.SelectedItem;
            Sandwich[] ss = this.bakery_store.GetAvailableSandwiches(_bread);

            string sdata = "[Sandwich Data]" + Environment.NewLine + Environment.NewLine;

            sdata = sdata + ss[lbxMenu.SelectedIndex].GetName() + " - " + ss[lbxMenu.SelectedIndex].GetPrice() + Environment.NewLine;

            sdata = sdata + Environment.NewLine;

            sdata = sdata + ss[lbxMenu.SelectedIndex].GetInfo();



            lblSandwichInfo.Text = sdata;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.InitialDirectory = @ "C:" ;      
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Serialize(this.bakery_store, saveFileDialog1.FileName);
            }
        }

        public void Serialize(Bakery bs, String filename)
        {
            //Create the stream to add object into it.  
            System.IO.Stream ms = File.OpenWrite(filename);
            //Format the object as Binary  

            BinaryFormatter formatter = new BinaryFormatter();
            //It serialize the bakery object  
            formatter.Serialize(ms, bs);
            ms.Flush();
            ms.Close();
            ms.Dispose();
        }

        public void Deserialize(String filename)
        {
            //Format the object as Binary  
            BinaryFormatter formatter = new BinaryFormatter();

            //Reading the file from the server  
            FileStream fs = File.Open(filename, FileMode.Open);

            object obj = formatter.Deserialize(fs);
            Bakery bs = (Bakery)obj;
            fs.Flush();
            fs.Close();
            fs.Dispose();
            this.bakery_store = bs;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                //InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Deserialize(openFileDialog1.FileName);

                Sandwich[] ss = this.bakery_store.GetAvailableSandwiches();

                this.lbxMenu.Items.Clear();
                foreach (Sandwich a in ss)
                {
                    this.lbxMenu.Items.Add($"{a.GetName().ToString()}, {a.GetPrice().ToString()}");
                }
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            BreadType _bread = (BreadType)cbbBreadFilter.SelectedItem;
            Sandwich[] ss = this.bakery_store.GetAvailableSandwiches(_bread);

            this.label3.Text = this.bakery_store.SellSandwich(ss[lbxMenu.SelectedIndex]).ToString();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                double total_revenue_withVAT = bakery_store.CalculateRevenue(true);

                MessageBox.Show($"Total Revenue with VAT: {total_revenue_withVAT}");
            }
            else
            {
                double total_revenue_withoutVAT = bakery_store.CalculateRevenue(false);

                MessageBox.Show($"Total Revenue without VAT: {total_revenue_withoutVAT}");
            }
            
            
        }
    }
}
