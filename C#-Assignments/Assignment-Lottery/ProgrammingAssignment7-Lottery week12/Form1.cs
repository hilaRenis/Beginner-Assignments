using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingAssignment7_Lottery_week12
{
    public partial class Form1 : Form
    {
        public Lottery lotteryobject;

        public Form1()
        {
            InitializeComponent();
        }

        private void createLotteryObject_btn_Click(object sender, EventArgs e)
        {
            lotteryNo_lb.Items.Clear();
            if ((maxValue_tb.Text != "0" && wantedNo_tb.Text != "0") && Int32.Parse(maxValue_tb.Text)> Int32.Parse(wantedNo_tb.Text))
            {
                lotteryobject = new Lottery(Int32.Parse(maxValue_tb.Text), Int32.Parse(wantedNo_tb.Text));
                drawALLNo_btn.Enabled = true;
                drawNextNo_btn.Enabled = true;
            }
        }

        private void drawALLNo_btn_Click(object sender, EventArgs e)
        {
            lotteryNo_lb.Items.Clear();

            int[] drawnnumbers_all = lotteryobject.DrawAllNumbers();
            
                       
            for (int i = 0; i < drawnnumbers_all.Length; i++)
            {
                lotteryNo_lb.Items.Add(drawnnumbers_all[i].ToString());
            }

            drawALLNo_btn.Enabled = false;
            drawNextNo_btn.Enabled = false;
        }

        private void drawNextNo_btn_Click(object sender, EventArgs e)
        {
            if (lotteryobject.IsLotteryFinished() == false)
            {
                int drawnnumber_next = lotteryobject.DrawNextNumber();
                lotteryNo_lb.Items.Add(drawnnumber_next.ToString());
            }
            else if (lotteryobject.IsLotteryFinished() == true)
            {
                drawNextNo_btn.Enabled = false;
            }
            
            
        }
    }
}
