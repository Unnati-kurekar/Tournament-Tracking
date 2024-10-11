using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportLibrary.Model
{
    public class StudentModel
    {
        public int id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateFormat DateOfBirth { get; set; }

        public StudentModel(string fisrtname,string lastname, DateFormat date)
        {
            FirstName = fisrtname;
            LastName = lastname;
            DateOfBirth = date;
        }
    }
}
