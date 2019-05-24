using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.GUI
{
    public class PatternViewModel
    {
        public string Member { get; set; }
        public string MemberName { get; set; }

        public PatternViewModel(string member, string memberName)
        {
            Member = member;
            MemberName = memberName;
        }

        public PatternViewModel()
        {

        }
    }
}
