namespace StudentAPIDemo.Models
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);


        IEnumerable<Student> GetTeamAStudents();

        IEnumerable<Student> GetTeamBStudents();

        IEnumerable<Student> GetTeamCStudents();

        IEnumerable<Student> GetTeamDStudents();

        IEnumerable<Student> GetMaleStudents();

        IEnumerable<Student> GetFemaleStudents();

        IEnumerable<Student> GetSNameStudents();
        Student InsertStudent(Student student);
        Student UpdateStudent(Student student);
        Student DeleteStudent(int studentId);


    }
}
