using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace databasee.Models
{
    public class Student : Person
    {
        public DateTime DOB {  get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public string EmergencyContactName { get; set; }
        public string EmergencyContactNumber { get; set; }

        public override string ToString()
        {
            return "student: " + FirstName + " " + LastName;
        }

    }
}
