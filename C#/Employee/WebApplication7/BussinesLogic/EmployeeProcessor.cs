using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Models;
using DataLibrary.DataAccess;

namespace DataLibrary.BussinesLogic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(int employeeId, string firstName,
            string lastName, string EmailAddress)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeId,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = EmailAddress
            };

            string sql = @"insert into dbo.Employee (Employeeid, FirstName, LastName, EmailAddress)
    values (@EmployeeId, @FirstName, @LastName, @EmailAddress);";
            return SqlAccess.SaveData(sql, data);
        }
        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = "select Id, EmployeeId, FirstName, LastName, EmailAddress from dbo.Employee;";
            return SqlAccess.LoadData<EmployeeModel>(sql);
        }
    }
}
