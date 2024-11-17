using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databasee.Models
{
    public class Teacher : Person
    {
        public Roles Role { get; set; }
    }
    public enum Roles
    {
        Pastoral, SubjectTeacher, SupportStaff, HeadOfYear
    }
}
