using EmployeeMicroservice.Infrastructure;
using EmployeeMicroservice.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeMicroservice.Repository
{
    public class EmployeeRepo : IEmployee
    {
        private static List<Employee> Employees;
        public EmployeeRepo()
        {
            Employees = new List<Employee>()
            {
                new Employee{EmployeeId=101, EmployeeName="Kapil", Password="12345"},
                new Employee{EmployeeId=102, EmployeeName="Nazeer", Password="12345"},
                new Employee{EmployeeId=103, EmployeeName="Girisha", Password="12345"},
                new Employee{EmployeeId=104, EmployeeName="Vishakha", Password="12345"},
                new Employee{EmployeeId=105, EmployeeName="Rohit", Password="12345"},
                new Employee{EmployeeId=201, EmployeeName="Ranjhana", Password="12345"},

            };
        }
        public Employee Getprofile(int employeeId)
        {
            Employee Employee = Employees.FirstOrDefault(c => c.EmployeeId == employeeId);
            return Employee;
        }
    }
}
