using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    interface IEmployee
    {
        public IEnumerable<Employee> GetAllEmployees();
        public Employee GetEmployee(int employeeId);
        public void InsertEmployee(Employee employee);
        public void UpdateEmployee(Employee employee);
        public void DeleteEmployee(Employee employee);

    }
}
