using databasee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal interface IDataAccess
    {
        public List<Student> GetStudentList();
        public void MakeStudentBooking(int studentID, string description, int importance, string status);
    }
}
