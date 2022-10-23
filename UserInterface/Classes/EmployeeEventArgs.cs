using ServiceHR.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHR.UserInterface.Classes
{
    public class EmployeeEventArgs : EventArgs
    {
        public EmployeeModel Employee { get; private set; }

        public EmployeeEventArgs(EmployeeModel employee)
        {
            this.Employee = employee;
        }
    }
}
