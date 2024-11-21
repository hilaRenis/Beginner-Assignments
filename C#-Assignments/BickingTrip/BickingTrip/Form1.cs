using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BickingTrip
{
    public partial class Form1 : Form
    {
        private BickingService bservice;
        private bool searchactive = false;
        private string searchquery = "";
        private double sratingmin = 0;
        private double sratingmax = 10;

        public Form1()
        {
            InitializeComponent();
            this.bservice = new BickingService("myBickingService");
            this.cbTransType.DataSource = Enum.GetValues(typeof(TransportationType));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string destination = tbxTo.Text;
            double distance = Convert.ToDouble(nudDistance.Value);
            double rating = Convert.ToDouble(nudRating.Value);
            TransportationType _transportationType = (TransportationType)cbTransType.SelectedItem;

            if (!String.IsNullOrEmpty(destination) && distance > 0)
            {
                this.bservice.AddTrip(destination, distance, rating, _transportationType);
                lbxMyTrips.Items.Clear();

                foreach (Trip t in this.bservice.GetTrips())
                {
                    lbxMyTrips.Items.Add($"{t.GetInfo()}");
                }

                tbxTo.Clear();
                nudDistance.Value = 0m;
                nudRating.Value = 0m;
            }
            else
            {
                MessageBox.Show("Please supply a valid destination and/or distance");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbxMyTrips.SelectedIndex > -1)
            {
                int index = lbxMyTrips.SelectedIndex;
                if (index > -1)
                {
                    this.bservice.RemoveTripAt(index);

                    lbxMyTrips.Items.Clear();

                    foreach (Trip t in this.bservice.GetTrips())
                    {
                        lbxMyTrips.Items.Add($"{t.GetInfo()}");
                    }

                    lbxMyTrips.SelectedIndex = -1;
                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (lbxMyTrips.SelectedIndex > -1)
            {
                int index = lbxMyTrips.SelectedIndex;
                if (index > -1)
                {
                    if (this.searchactive)
                    {
                        if (searchquery == "")
                        {
                            string msg = this.bservice.GetTripsByRating(sratingmin, sratingmax)[index].GetInfo();
                            MessageBox.Show(msg);
                        }
                        else if (sratingmin == 0 && sratingmax == 10)
                        {
                            string msg = this.bservice.GetTrips(this.searchquery)[index].GetInfo();
                            MessageBox.Show(msg);
                        }
                    }
                    else
                    {
                        string msg = this.bservice.GetTrips()[index].GetInfo();
                        MessageBox.Show(msg);
                    }
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            lbxMyTrips.Items.Clear();
            foreach (Trip t in this.bservice.GetTrips())
            {
                lbxMyTrips.Items.Add($"{t.GetInfo()}");
            }

            lbxMyTrips.SelectedIndex = -1;
            this.searchactive = false;
            this.searchquery = "";
            this.sratingmin = 0;
            this.sratingmax = 10;
            this.tbxSearch.Text = "";
            this.numericUpDownRatinMin.Value = 0;
            this.numericUpDownRatingMax.Value = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbxMyTrips.Items.Clear();
            string query = tbxSearch.Text;

            foreach (Trip t in this.bservice.GetTrips())
            {
                if (t.GetInfo().Contains(query))
                {
                    lbxMyTrips.Items.Add($"{t.GetInfo()}");
                }
            }

            lbxMyTrips.SelectedIndex = -1;
            this.searchactive = true;
            this.searchquery = query;
            this.sratingmin = 0;
            this.sratingmax = 10;
            this.numericUpDownRatinMin.Value = 0;
            this.numericUpDownRatingMax.Value = 0;
        }

        private void btnSearchRating_Click(object sender, EventArgs e)
        {
            lbxMyTrips.Items.Clear();
            double querymin = decimal.ToDouble(this.numericUpDownRatinMin.Value);
            double querymax = decimal.ToDouble(this.numericUpDownRatingMax.Value);

            foreach (Trip t in this.bservice.GetTrips())
            {
                if (t.GetRating() >= querymin && t.GetRating() <= querymax)
                {
                    lbxMyTrips.Items.Add($"{t.GetInfo()}");
                }

            }

            lbxMyTrips.SelectedIndex = -1;
            this.searchactive = true;
            this.sratingmin = querymin;
            this.sratingmax = querymax;
            this.tbxSearch.Text = "";
        }

        private void btnShowAverageRatings_Click(object sender, EventArgs e)
        {
            Trip[] t = this.bservice.GetTrips();

            var result = t.GroupBy(d => d.GetDestination())
                .Select(
                    g => new
                    {
                        Key = g.Key,
                        Value = g.Average(s => s.GetRating())
                    });
            string msg = "Result: " + Environment.NewLine;
            foreach (var v in result)
            {
                msg = msg + v.Key + ": " + v.Value + Environment.NewLine;
            }

            MessageBox.Show(msg);
        }
    }
}
