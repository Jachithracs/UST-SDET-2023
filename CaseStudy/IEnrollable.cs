using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal interface IEnrollable
    {
        public void CourseRegistration(int id, int stuid);
        public void CourseWithdrawal(int id);
    }
}
