using databasee.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class DataAccessSQL : IDataAccess
    {
        private readonly string serverDetails = "server=77.37.35.4;uid=u381396247_lhatherly;pwd=7G~4e+t5I;database=u381396247_lhatherly";
        private MySqlConnection con;
        
        public DataAccessSQL() {
            con = new MySqlConnection(serverDetails);
        }
        public List<Student> GetStudentList()
        {            
            MySqlCommand cmd = new MySqlCommand();
            //Simple count query - returns 1 result
            String SQL = "SELECT * FROM Student";
            cmd.CommandText = SQL;
            cmd.Connection = con;
            con.Open(); // open connection
            MySqlDataReader results = cmd.ExecuteReader(); // results are going to be multiple
            List<Student> students = new List<Student>();
            while (results.Read())
            {
                Student dataEntryStudent = new Student();
                //for (int i = 0; i < results.FieldCount; i++)
                //{
                //    MessageBox.Show(results[i].ToString());
                //}
                dataEntryStudent.ID = Convert.ToInt32(results[0]);
                dataEntryStudent.FirstName = results[1].ToString();
                dataEntryStudent.LastName = results[2].ToString();
                dataEntryStudent.DOB = DateTime.Parse(results[3].ToString());
                dataEntryStudent.EmailAddress = results[4].ToString();
                dataEntryStudent.PhoneNumber = results[5].ToString();
                dataEntryStudent.Address = results[6].ToString();
                dataEntryStudent.EmergencyContactName = results[7].ToString();
                dataEntryStudent.EmergencyContactNumber = results[8].ToString();
                dataEntryStudent.Username = results[9].ToString();
                students.Add(dataEntryStudent);
                //MessageBox.Show(dataEntryStudent.ToString());
            }
            con.Close(); // close connection
            return students;
        }
        public static void MakeStudentBooking(string description, int importance, string status)
        {
            MySqlCommand cmd = new MySqlCommand();
            //Simple count query - returns 1 result
            String SQL = $"INSERT INTO Appointment(Description, Importance, Status) VALUES({description}, {importance}, {status}); ";
            cmd.CommandText = SQL;
            cmd.Connection = con;
            con.Open(); // open connection
            cmd.ExecuteReader(); // results are going to be multiple
            con.Close(); // close connection
        }
    }
}
