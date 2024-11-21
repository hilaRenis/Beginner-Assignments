using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmet6_ExtendingStudentGroup_week14
{
   public class ProjectGroup
    {
        private string name;
        private List<Member> member;

        public ProjectGroup (string name)
        {
            this.name = name;
            this.member = new List<Member>();
        }

        public void AddMember(string name)
        {
            Member newMember = new Member(name);
            this.member.Add(newMember);
        }

        public void AddMember(Member newMember)
        {
            this.member.Add(newMember);
        }

        public string GetInfo()
        {
            string info;
            if (this.member.Count() == 0)
            {
                info = this.name + ": " + "no members";
            }
            else
            {
                info = this.name + ": ";

                foreach (Member member in member)
                {
                    info += member.GetInfo() + ";";
                }

            }
            return info;
        }
    }
}
