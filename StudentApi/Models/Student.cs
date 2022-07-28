using System.ComponentModel.DataAnnotations;

namespace StudentAPIDemo.Models
{
    public class Student
    {
       
        public int StudentID { get; set; }
        [Required(ErrorMessage = "Please provide first name")]
        [StringLength(10, ErrorMessage = "Length of first name should be less than 10")]

        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please provide first name")]
        [StringLength(10, ErrorMessage = "Length of first name should be less than 10")]
        public string LastName { get; set; }
        [Range(18, 36)]
        [RegularExpression(@"[0-9]*$", ErrorMessage = "Float Values Not Accepted")]

        public int Age { get; set; }
        public string Gender { get; set; }
        public string TeamName { get; set; }

    }
}
