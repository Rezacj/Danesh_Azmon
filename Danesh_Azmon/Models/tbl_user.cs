using System.ComponentModel.DataAnnotations;

namespace Danesh_Azmon.Models
{
    public class tbl_user
    {
        [Key]
        public int UserId { get; set; }
        public required string NationalCode { get; set; }
        public required string Password { get; set; }
        public required string Role { get; set; } // "Student" یا "Teacher"

        // ارتباط با StudentClasses
        public ICollection<tbl_studentClass> StudentClasses { get; set; }
    }
}
