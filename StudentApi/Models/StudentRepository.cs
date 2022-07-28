namespace StudentAPIDemo.Models
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _appDbContext;
        public StudentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        

        public IEnumerable<Student> GetAllStudents()
        {
           return _appDbContext.Students;
           /* var students = new List<Student> {
                new Student{StudentID=1, FirstName="Amara",LastName="Sriram",Age=21, Gender="M", TeamName="A" },
                new Student{StudentID=2, FirstName="Muskan",LastName="Muskan",Age=20, Gender="F", TeamName="A" },
                new Student{StudentID=3, FirstName="Rahul",LastName="Yadav",Age=21, Gender="M", TeamName="A" },
                new Student{StudentID=4, FirstName="Shraddha",LastName="Shraddha",Age=20, Gender="F", TeamName="A" },
                new Student{StudentID=5, FirstName="Aishwarya",LastName="Verma",Age=20, Gender="F", TeamName="A" },

                new Student{StudentID=6, FirstName="Shreya",LastName="",Age=20, Gender="F", TeamName="B" },
                new Student{StudentID=7, FirstName="Nandhita",LastName="",Age=20, Gender="F", TeamName="B" },
                new Student{StudentID=8, FirstName="Shashwat",LastName="",Age=20, Gender="M", TeamName="B" },
                new Student{StudentID=9, FirstName="Siddarth",LastName="",Age=21, Gender="M", TeamName="B" },
                new Student{StudentID=10, FirstName="Shriya",LastName="",Age=20, Gender="F", TeamName="B" },

                new Student{StudentID=11, FirstName="Sriram",LastName="",Age=21, Gender="M", TeamName="C" },
                new Student{StudentID=12, FirstName="Sneha",LastName="Sinha",Age=20, Gender="F", TeamName="C" },
                new Student{StudentID=13, FirstName="Simran",LastName="Singh",Age=20, Gender="F", TeamName="C" },
                new Student{StudentID=14, FirstName="Subhash",LastName="Gurjar",Age=21, Gender="M", TeamName="C" },
                new Student{StudentID=15, FirstName="Umeed",LastName="Chandel",Age=19, Gender="F", TeamName="C" },

                new Student{StudentID=16, FirstName="Vaibhav",LastName="Bhatnagar",Age=21, Gender="M", TeamName="D" },
                new Student{StudentID=17, FirstName="Pujitha",LastName="Vavilapalli",Age=20, Gender="F", TeamName="D" },
                new Student{StudentID=18, FirstName="Palak",LastName="Soni",Age=20, Gender="F", TeamName="D" },
                new Student{StudentID=19, FirstName="Saurabh",LastName="Kumar",Age=21, Gender="M", TeamName="D" },
                new Student{StudentID=20, FirstName="Tisha",LastName="Varshney",Age=20, Gender="F", TeamName="D" },
                new Student{StudentID=21, FirstName="Aman",LastName="Asati",Age=21, Gender="M", TeamName="D" }
                };
            return students;*/

        }
        

        public IEnumerable<Student> GetFemaleStudents()
        {
            var students=this._appDbContext.Students.Where(s => s.Gender.ToUpper() == "F");
            return students;
        }

        public IEnumerable<Student> GetMaleStudents()
        {
          var students= this._appDbContext.Students.Where(s => s.Gender.ToUpper() == "M");
            return students; 
        }

        public IEnumerable<Student> GetSNameStudents()
        {
          var students=  this._appDbContext.Students.Where(s => s.FirstName.StartsWith('S'));
            return students;
        }

        public IEnumerable<Student> GetTeamAStudents()
        {
            var students= this._appDbContext.Students.Where(s => s.TeamName.ToUpper() == "A");
            return students;
        }

        public IEnumerable<Student> GetTeamBStudents()
        {
         var students=  this._appDbContext.Students.Where(s => s.TeamName.ToUpper() == "B");
            return students;
        }

        public IEnumerable<Student> GetTeamCStudents()
        {
            var students= this._appDbContext.Students.Where(s => s.TeamName.ToUpper() == "C");
            return students;
        }

        public IEnumerable<Student> GetTeamDStudents()
        {
            var students= this._appDbContext.Students.Where(s => s.TeamName.ToUpper() == "D");
            return students;
        }

        public Student InsertStudent(Student student)
        {
            var entry=this._appDbContext.Students.Add(student);
            this._appDbContext.SaveChanges();
            return entry.Entity;
        }

        public Student UpdateStudent(Student student)
        {
          var entry=  this._appDbContext.Update(student);
            this._appDbContext.SaveChanges();
            return entry.Entity;
        }
        public Student DeleteStudent(int studentId)
        {
         var student=   this._appDbContext.Students.FirstOrDefault(s => s.StudentID == studentId);
          var entry= this._appDbContext.Remove(student);
            this._appDbContext.SaveChanges();
            return entry.Entity;
        }

        public Student GetStudentById(int id)
        {
            var student=this._appDbContext.Students.FirstOrDefault(s => s.StudentID == id);
            return student;
        }
    }
}
