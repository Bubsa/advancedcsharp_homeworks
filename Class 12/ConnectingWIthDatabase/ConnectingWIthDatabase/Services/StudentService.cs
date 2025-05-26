using AdoNet.Models;
using Microsoft.Data.SqlClient;

namespace AdoNet.Services

{
    public class StudentService // Ovaa klasa ja pravime za da ne pishuvame vo Program.cs
    {
        private readonly string _connectionString;

        public StudentService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();

            // 1. Vospostavuvanje konekcija so Databazata
            //SqlConnection connection = new SqlConnection(_connectionString);

            //connection.Open(); // Ova e po nedobriot nachin na otvaranje konekcija so databaza. Po specificno so .Open ili .Close

            //connection.Close();

            // Ova e podobriot nachin odnosno koristenje USING

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                // 2. Pishi go query-to
                string query = @"
                    SELECT *
                    FROM dbo.Student";

                // 3. Kreiranje na SQL komanda
                using SqlCommand command = new SqlCommand(query, sqlConnection);

                // 4. Izvrshuvanje na SQL komandata
                using SqlDataReader reader = command.ExecuteReader();

                // 5. Chitanje na informacii od izvrsheniot query
                while (reader.Read())
                {

                    // 6. Rachno mapiranje od vratenite koloni na Student objektot
                    var student = new Student()
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        DateOfBirth = reader.GetDateTime(3),
                        EnrolledDate = reader.GetDateTime(4),
                        Gender = reader.GetString(5)[0],
                        NationalIdNumber = reader.GetInt64(6),
                        StudentCardNumber = reader.GetString(7)
                    };

                    students.Add(student);
                }

            }


            return students;
        }

        public void InsertStudent(Student student) 
        {
            // 1. Konekcija kon databazata
            using (SqlConnection sqlConnection = new(_connectionString))
            {
                sqlConnection.Open();

                // 2. Pishuvanje na SQL query
                string query = $@"INSERT INTO dbo.Student (FirstName, LastName, DateOfBirth, EnrolledDate, Gender, NationalIdNumber, StudentCardNumber)
VALUES('{student.FirstName}', '{student.LastName}', '{student.DateOfBirth:yyyy-MM-dd}', '{student.EnrolledDate:yyyy-MM-dd}', '{student.Gender}', {student.NationalIdNumber}, '{student.StudentCardNumber}')";
                
                // 3. Kreiranje na SQL komanda
                using SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // 4. Ova go izvrshuva query-to
                sqlCommand.ExecuteNonQuery();
            }


        }

    }
        
}
