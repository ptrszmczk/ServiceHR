using ServiceHR.DataAccessLayer.Models;
using ServiceHR.DataAccessLayer.Models.Dictionaries;
using ServiceHR.UserInterface.Classes;
using ServiceHR.UserInterface.Extentions;
using ServiceHR.UserInterface.Forms.Base;
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
    public partial class EmployeeAddForm : BaseAddEditForm
    {

        #region Fields
        public EventHandler ReloadEmployees;
        #endregion

        #region Constructor
        public EmployeeAddForm()
        {
            InitializeComponent();
            InitializeData();
            ValidateControls();
        }
        #endregion

        #region Private Methods
        private void ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                epLastName.SetError(txtLastName, "Last Name field cannot be empty!");
            }
            else
            {
                epLastName.Clear();
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                epFirstName.SetError(txtFirstName, "First Name field cannot be empty!");
            }
            else
            {
                epFirstName.Clear();
            }
        }

        private void InitializeData()
        {
            IList<GenderModel> genders = new List<GenderModel>()
            {
                new GenderModel("Female"),
                new GenderModel("Male"),
                new GenderModel(String.Empty)
            };

            bsGender.DataSource = genders;
            cbGender.Text = String.Empty;
        }

        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string lastNameErrorMessage = epLastName.GetError(txtLastName);
            string firstNameErrorMessage = epFirstName.GetError(txtFirstName);
            string peselWarningMessage = epPesel.GetError(txtPesel);

            if (!string.IsNullOrWhiteSpace(lastNameErrorMessage))
            {
                sbErrorMessage.AppendLine(lastNameErrorMessage);
            }

            if (!string.IsNullOrWhiteSpace(firstNameErrorMessage))
            {
                sbErrorMessage.AppendLine(firstNameErrorMessage);
            }

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show(sbErrorMessage.ToString(), "Employee Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(peselWarningMessage))
            {
                DialogResult answer = MessageBox.Show(peselWarningMessage + Environment.NewLine + "Do you want to add emplopyee without this field?", "Employee Add", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }
        #endregion

        #region Events
        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dtp.DateTimePickerValueChanged();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPesel_Validated(object sender, EventArgs e)
        {
            string pesel = txtPesel.Text;

            if (!string.IsNullOrWhiteSpace(pesel) && !ValidatorHelper.IsValidPesel(pesel))
            {
                epPesel.SetError(txtPesel, "Control digit is wrong.");
            }
            else
            {
                epPesel.Clear();
            }
        }
        #endregion

        #region Override
        protected override void Save()
        {
            if (ValidateForm())
            {
                EmployeeModel employee = new EmployeeModel()
                {
                    LastName = txtLastName.Text,
                    FirstName = txtFirstName.Text,
                    Gender = new GenderModel(cbGender.Text),
                    DateBirth = dtpDateBirth.Value,
                    PESEL = txtPesel.Text,
                    PhoneNumer = txtPhoneNumebr.Text,
                    EmailAddress = txtEmailAddress.Text,
                    IdentityCardNumber = txtIdentityCardNumber.Text,
                    IssueDateIdentityCard = dtpIssueDateIdentityCard.Value,
                    ExpirationDateIdentityCard = dtpExpirationDateIdentityCard.Value,
                    PasswordNumber = txtPassportNumber.Text,
                    IssueDatePassport = dtpIssueDatePassport.Value,
                    ExpirationDatePassport = dtpExpirationDatePassport.Value,
                    Status = new StatusModel("Introduced")
                };

                //employee = CreateEmployee(employee);
                employee.Id = 4;
                employee.Code = 4;

                ReloadEmployees?.Invoke(btnSave, new EmployeeEventArgs(employee));

                Close();
            }
        }

        protected override void Cancel()
        {
            MessageBox.Show("Canceled");
            Close();
        }
        #endregion

    }
}
