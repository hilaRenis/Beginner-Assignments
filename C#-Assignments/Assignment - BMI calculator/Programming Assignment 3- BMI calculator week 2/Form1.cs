using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assignment_3__BMI_calculator_week_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double bmi;
        

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            pergjigjiaBMI();

            if(bmi < 18.5)
            {
                lbl_PergjigjiaPerPeshen.Text = "You are underweight!";
            }
            else if (bmi >= 18.5 && bmi < 25.0)
            {
                lbl_PergjigjiaPerPeshen.Text = "You are normal weight!";
            }
            else if (bmi >= 25.0 && bmi < 30.0)
            {
                lbl_PergjigjiaPerPeshen.Text = "You are overweight!";
            }
            else if (bmi >= 30.0)
            {
                lbl_PergjigjiaPerPeshen.Text = "You are obese! Your BMI is extremely high. Please contact your doctor, because your health is in danger!";
            }
    }

        private double pesha()
        {
            return  Convert.ToDouble(tb_Pesha.Text);
        }

        private double gjatesia()
        {
            return Convert.ToDouble(tb_Gjatesia.Text);
        }

        private string pergjigjiaBMI()
        {
            this.bmi = (pesha() / (gjatesia() * gjatesia()));
            return lbl_PergjigjiaBMI.Text = "Your bmi is: " + bmi.ToString("0.00");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*
        1. Si fillim kam bere 3 metoda pesha(); gjatesia(); pergjigjiaBMI(). 
        A. Tek metoda pesha(), teksti qe do shkruhet ne text box pesha do te konvertohet ne numer me presje.
        B. Tek metoda gjatesia(), kam bere qe teksti qe do te shkruhet ne text box gjatesia do te konvertohet ne 
        numer me presje.
        C. Tek metoda pergjigjiaBMI(), ne fillim fare kam bere nje variabel private string bmi qe nuk do perdor 
        vtm tek kjo metode por mund ta perdor edhe tek metodat e tjera.  
        Brenda kesaj metode kam bere, qe tek variabla
        bmi do te ruhet vlera, e numri qe ka dale nga pjestimi i numrit te shkruar ne text box pesha dhe prodhimi
        i numrit te shkruar tek text box gjatesia me veten. Me pas kam bere qe kjo vlere do shfaqet ne 
        label PergjigjiaBMI ku do jete shfaqur ne formen e tekstit. Ketu kam bere qe do shfaqet me fjaline 
        'Your bmi is:' dhe vlera qe eshte ruajtur ne variablen bmi qe do konvertohet ne string me komanden 
        ToString(). Brenda klapave te kesaj komande kam bere qe vlera ne variablen bmi te rrumbullakoset me 
        dyshifra pas presjes.
        2. Tek private void btn_Calculate_Click(object sender, EventArgs e) kam shkruar si fillim metoden
        pergjigjiaBMI() ne menyre qe sa here te shtypet butoni te behet kalkulimi i bmi-se. 
        Me pas kam bere komanden if; else if ne menyre qe te krahasoj vleren e bmi-se nese eshte me e madhe ose 
        vogel ose baraz me numrin qe une kam shkruar dhe nese kushti qe une kam percaktuar eshte i vertete atehere
        kodi perkates per secilen prej tyre do ekzekutohet.
         */
    }
}
