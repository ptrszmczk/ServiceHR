using ServiceHR.DataAccessLayer.Models;
using ServiceHR.DataAccessLayer.Models.Dictionaries;
using ServiceHR.DataAccessLayer.ViewModel;
using ServiceHR.UserInterface.Classes;
using ServiceHR.UserInterface.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceHR.UserInterface.Forms.Employees
{
    public partial class EmployeesForm : Form
    {
        #region Fields
        private static EmployeesForm _instance = null;
        private static IList<EmployeeViewModel> _fakeEmployees;
        #endregion
        
        #region Properties
        public static EmployeesForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmployeesForm();
                }
                return _instance;
            }
        }

        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }
        #endregion

        #region Constructors
        private EmployeesForm()
        {
            InitializeComponent();
            _fakeEmployees = GetFakeEmployees();
            PrepareEmployeesData();
        }
        #endregion

        #region Private Methods
        private void PrepareEmployeesData()
        {
            var fakeEmployeesSorted = _fakeEmployees.OrderBy(x => x.Code).ToList();
            bsEmployees.DataSource = new BindingList<EmployeeViewModel>(fakeEmployeesSorted);
            dgvEmployees.DataSource = bsEmployees;
        }

        private IList<EmployeeViewModel> GetFakeEmployees()
        {
            IList<EmployeeModel> fakeEmployeesModel = new List<EmployeeModel>
            {
                new EmployeeModel()
                {
                    Id = 1,
                    LastName = "Andrzejewski",
                    FirstName = "Paweł",
                    Code = 3,
                    Gender = new GenderModel("mężczyzna"),
                    DateBirth = new DateTime(1994, 9, 1),
                    PESEL = "94090142830",
                    PhoneNumer = "665988254",
                    EmailAddress = "p.andrzejewski@gmail.com",
                    IdentityCardNumber = "AWR204120",
                    IssueDateIdentityCard = new DateTime(2012, 9, 15),
                    ExpirationDateIdentityCard = new DateTime(2032, 9, 15),
                    PasswordNumber = "ER9884510",
                    IssueDatePassport = new DateTime(2015, 5, 23),
                    ExpirationDatePassport = new DateTime(2025, 5, 23),
                    Status = new StatusModel("Introduced")
                },

                new EmployeeModel()
                {
                    Id = 1,
                    LastName = "Kowalczyk",
                    FirstName = "Katarzyna",
                    Code = 2,
                    Gender = new GenderModel("kobieta"),
                    DateBirth = new DateTime(1991, 2, 13),
                    PESEL = "91021342830",
                    PhoneNumer = "534288254",
                    EmailAddress = "k.kowalczyk@gmail.com",
                    IdentityCardNumber = "GBE204120",
                    IssueDateIdentityCard = new DateTime(2011, 3, 11),
                    ExpirationDateIdentityCard = new DateTime(2031, 3, 11),
                    PasswordNumber = "MM9884510",
                    IssueDatePassport = new DateTime(2015, 10, 1),
                    ExpirationDatePassport = new DateTime(2025, 10, 1),
                    Status = new StatusModel("Introduced")
                },

                new EmployeeModel()
                {
                    Id = 1,
                    LastName = "Bania",
                    FirstName = "Kornel",
                    Code = 1,
                    Gender = new GenderModel("mężczyzna"),
                    DateBirth = new DateTime(1988, 1, 31),
                    PESEL = "88013142830",
                    PhoneNumer = "738288254",
                    EmailAddress = "k.bania@gmail.com",
                    IdentityCardNumber = "QHH204120",
                    IssueDateIdentityCard = new DateTime(2008, 4, 1),
                    ExpirationDateIdentityCard = new DateTime(2028, 4, 1),
                    PasswordNumber = "ZR9884510",
                    IssueDatePassport = new DateTime(2021, 1, 2),
                    ExpirationDatePassport = new DateTime(2031, 1, 2),
                    Status = new StatusModel("Introduced")
                }
            };

            return MappingHelper.MapEmployeeModelToEmployeeViewModel(fakeEmployeesModel);
        }
        #endregion

        #region Events
        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            EmployeeAddForm frm = new EmployeeAddForm();

            frm.ReloadEmployees += (s, ea) =>
            {
                EmployeeEventArgs eventArgs = ea as EmployeeEventArgs;

                if (eventArgs != null)
                {
                    EmployeeViewModel employee = MappingHelper.MapEmployeeModelToEmployeeViewModel(eventArgs.Employee);
                    bsEmployees.Add(employee);

                    dgvEmployees.ClearSelection();
                    dgvEmployees.Rows[dgvEmployees.Rows.Count - 1].Selected = true;
                }
            };

            frm.ShowDialog();
        }
        #endregion

    }
}
