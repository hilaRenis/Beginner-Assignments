using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingAssignment3_CarApplicationExtended
{
    public partial class Form1 : Form
    {
        private Cars1 myCar = new Cars1();
        private Cars1 myCar2 = new Cars1();
        public Form1()
        {
            InitializeComponent();
            myCar.SetBrand("Ferrari  812 GTS");
            myCar.SetMaxSpeed(340);
            myCar.SetCurrentSpeed(0);

            myCar2.SetBrand("Porsche 911 Turbo");
            myCar2.SetMaxSpeed(320);
            myCar2.SetCurrentSpeed(0);

        }

        private void accelerate_btn_Click(object sender, EventArgs e)
        {
            if (Ferrari_rb.Checked)
            {
                myCar.SpeedUp();
                displayInformation_lbl.Text = myCar.GetInfo();
            }
            else
            {
                myCar2.SpeedUp();
                displayInformation_lbl.Text = myCar2.GetInfo();
            } 
        }

        private void breaks_btn_Click(object sender, EventArgs e)
        {
            if (Ferrari_rb.Checked)
            {
                myCar.SlowDown();
                displayInformation_lbl.Text = myCar.GetInfo();
            }
            else
            {
                myCar2.SlowDown();
                displayInformation_lbl.Text = myCar2.GetInfo();
            }
        }
    }
}
