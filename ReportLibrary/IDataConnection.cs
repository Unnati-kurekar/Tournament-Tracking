﻿using ReportLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportLibrary
{
    public interface IDataConnection
    {
        void createStudent(StudentModel student);
    }
}
