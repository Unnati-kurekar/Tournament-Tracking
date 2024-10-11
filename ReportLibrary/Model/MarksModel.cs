using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportLibrary.Model
{
    public class MarksModel
    {
        public int id { get; set; }
        public int Subject1 { get; set; }
        public int Subject2 { get; set; }
        public int Subject3 { get; set; }
        public int Subject4 { get; set; }
     
        public StudentModel? StudentId { get; set; }
    }
}
