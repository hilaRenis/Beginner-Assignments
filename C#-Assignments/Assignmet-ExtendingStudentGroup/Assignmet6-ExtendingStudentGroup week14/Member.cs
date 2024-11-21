using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmet6_ExtendingStudentGroup_week14
{
    public class Member
    {
        private int studentNumber;
        private string name;

        public Member(string name) 
        {
            this.name = name;
        }

        public Member(string name, int studentNumber)
        {
            this.name = name;
            this.studentNumber = studentNumber;
        }

        public string GetInfo()
        {
            string info;
            if (studentNumber > 0)
            {
                info = name +" (no. " + studentNumber + ")";
            }
            else
            {
                info = name;
            }

            return info;
        }
    }
}
