﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }

        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Title { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}