using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404.Models
{

    public class MidGradeVM
    {
        public List<MidGradeBundles> MidGradeItems { get; set; }

        public MidGradeVM()
        {
            MidGradeItems = new List<MidGradeBundles>();
        }
    }

}
