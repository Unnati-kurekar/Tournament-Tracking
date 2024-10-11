using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportLibrary.Model
{
    public class ResultModel
    {
        public int Id { get; set; }
        public int TotalObtainMarks { get; set; } = 0;
        public int TotalMarks { get; private set; } = 400;
        public decimal Percentage { get; set; } = 0;
        public string? FinalResult { get; set; }
        public StudentModel? StudentId { get; set; }

    }
}
