using ServiceHR.DataAccessLayer.Models;
using ServiceHR.DataAccessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHR.UserInterface.Helpers
{
    public class MappingHelper
    {
        public static IList<EmployeeViewModel> MapEmployeeModelToEmployeeViewModel(IList<EmployeeModel> employeeModel)
        {
            IList<EmployeeViewModel> employeesViewModel = new List<EmployeeViewModel>();

            foreach (EmployeeModel item in employeeModel)
            {
                EmployeeViewModel employeeViewModel = new EmployeeViewModel();
                employeeViewModel.Id = item.Id;
                employeeViewModel.LastName = item.LastName;
                employeeViewModel.FirstName = item.FirstName;
                employeeViewModel.Code = item.Code.ToString();
                employeeViewModel.Position = String.Empty;
                employeeViewModel.Status = item.Status.ToString();

                employeesViewModel.Add(employeeViewModel);
            }

            return employeesViewModel;
        }

        public static EmployeeViewModel MapEmployeeModelToEmployeeViewModel(EmployeeModel employeeModel)
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.Id = employeeModel.Id;
            employeeViewModel.LastName = employeeModel.LastName;
            employeeViewModel.FirstName = employeeModel.FirstName;
            employeeViewModel.Code = employeeModel.Code.ToString();
            employeeViewModel.Position = String.Empty;
            employeeViewModel.Status = employeeModel.Status.ToString();

            return employeeViewModel;
        }
    }
}
