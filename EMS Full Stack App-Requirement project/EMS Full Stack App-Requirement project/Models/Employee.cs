using System;
using System.Collections.Generic;

namespace EMS_Full_Stack_App_Requirement_project.Models
{
    public partial class Employee
    {
        public int EmpCode { get; set; }
        public string EmpName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public int? DepartmentCode { get; set; }
    }
}
