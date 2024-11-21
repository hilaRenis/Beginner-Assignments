using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignmet6_ExtendingStudentGroup_week14
{
    public partial class Form1 : Form
    {
        private ProjectGroup project;
        public Form1()
        {
            InitializeComponent();
            project = new ProjectGroup("The Best Group");
            UpdateProject();
        }

        private void UpdateProject()
        {
            lblDisplay.Text = project.GetInfo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string memberName = tbName.Text;
            int studentNumber = Convert.ToInt32(tbNumber.Text);

            Member member = new Member(memberName, studentNumber);
            project.AddMember(member);
            UpdateProject();
        }
    }
}
