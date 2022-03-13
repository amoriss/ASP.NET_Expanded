using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    interface IDepartment
    {
        public IEnumerable<Department> GetAllDepartments();
        public Department GetDepartment(int id);
        public void InsertDepartment(string departmentName);
        public void UpdateDepartment(Department department);
        public void DeleteDepartment(Department department);
    }
}
