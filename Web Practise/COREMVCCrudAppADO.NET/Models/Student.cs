using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COREMVCCrudAppADO.NET.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
