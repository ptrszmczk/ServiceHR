using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHR.DataAccessLayer.ViewModel
{
    public class EmployeeViewModel
    {
        private string _lastName;
        private string _firstName;
        private string _code;

        public int Id { get; set; }
        public string LastName {
            get { return _lastName.ToUpper(); }
            set { _lastName = value; }
        }
        public string FirstName {
            get { return _firstName.ToUpper(); }
            set { _firstName = value; }
        }
        public string Code
        {
            get { return _code.PadLeft(4, '0'); }
            set { _code = value; }
        }
        public string Position { get; set; }
        public string Status { get; set; }
    }
}
