using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAPIDemo.Models;

namespace StudentAPIDemo.Controllers
{
    [ApiController]
    [Route("Student")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper mapper;
        public StudentController(IStudentRepository studentRepository, IMapper mapper)
        {
            this._studentRepository = studentRepository;
            this.mapper = mapper;
        }

       

        [HttpGet]
        [Route("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            try
            {
                var students= _studentRepository.GetAllStudents();
                var miniStudents = mapper.Map<StudentMini[]>(students);
                return Ok(miniStudents);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");

            }
           
        }
        [HttpGet("{id}", Name = "GetStudentByID")]

        public IActionResult GetStudentByID(int id)
        {
           
            try
            {
                var student = this._studentRepository.GetAllStudents().FirstOrDefault(s => s.StudentID == id);
                if (student == null)
                { return NotFound("student not found for this id"); }
                    return Ok(student);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
                }

            }
           
           
        [HttpGet]
        [Route("GetTeamAStudents")]
        public IActionResult GetTeamAStudents()
        {
        try
        {
           var students= _studentRepository.GetTeamAStudents();
            return Ok(students);
        }
        catch (Exception)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");

        }
        }
        [HttpGet]
        [Route("GetTeamBStudents")]
        public IActionResult GetTeamBStudents()
        {
            try
            {
                var students = _studentRepository.GetTeamBStudents();
                return Ok(students);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
            
        }
        [HttpGet]
        [Route("GetTeamCStudents")]
        public IActionResult GetTeamACtudents()
        {
            try
            {
                var student=_studentRepository.GetTeamCStudents();
                return Ok(student);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");

            }
        }
        [HttpGet]
        [Route("GetTeamDStudents")]
        public IActionResult GetTeamDStudents()
        {
            try
            {
                var student=_studentRepository.GetTeamDStudents();
                return Ok(student);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        [HttpGet]
        [Route("GetMaleStudents")]
        public IActionResult GetMaleStudents()
        {
            try
            {
                var student=_studentRepository.GetMaleStudents();
                return Ok(student);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");

            }
        }
        [HttpGet]
        [Route("GetFemaleStudents")]
        public IActionResult GetFemaleStudents()
        {
            try
            {
                var student=_studentRepository.GetFemaleStudents();
                return Ok(student);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        [HttpGet]
        [Route("GetSNameStudents")]
        public IActionResult GetSNameStudents()
        {
            try
            {
                var student=_studentRepository.GetSNameStudents();
                return Ok(student);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

        [HttpPost]
        [Route("InsertStudents")]
        public IActionResult InsertStudents(Student student)
        {
            try
            {
                var insertedStudent = this._studentRepository.InsertStudent(student);
                return CreatedAtRoute("GetStudentByID", new { id = insertedStudent.StudentID }, insertedStudent);

            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");

            }
        }
        [HttpPut]
        [Route("UpdateStudents")]
        public IActionResult UpdateStudents(Student student)
        {
            try
            {
                var updateStudent = this._studentRepository.UpdateStudent(student);
                return Ok(updateStudent);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");

            }
        }
        [HttpDelete]
        [Route("DeleteStudents")]
        public IActionResult DeleteStudents(int studentId)
        {
            try
            {
                var updateStudent = this._studentRepository.DeleteStudent(studentId);
                return Ok(updateStudent);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");

            }
        }



    }
}
