using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseTable
{
    /// <summary>
    /// Entity class
    /// </summary>
    class Member
    {
        private string memberID;
        private string memberName;

        public string MemberID
        {
            get
            {
                return memberID;
            }

            set
            {
                memberID = value;
            }
        }

        public string MemberName
        {
            get
            {
                return memberName;
            }

            set
            {
                memberName = value;
            }
        }
    }
}
