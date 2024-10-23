using System.ComponentModel.DataAnnotations;

namespace Danesh_Azmon.Models
{
    public class tbl_class
    {
        [Key]
        public int ClassId { get; set; }
        public string Name { get; set; }

        // ارتباط با StudentClasses و ExamClasses
        public ICollection<tbl_studentClass> StudentClasses { get; set; }
        public ICollection<tbl_examClass> ExamClasses { get; set; }
    }
}
