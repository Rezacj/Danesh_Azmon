using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace Danesh_Azmon.Models
{
    public class tbl_examClass
    {
        [Key]
        public int ExamId { get; set; }
        public tbl_exam Exam { get; set; }

        public int ClassId { get; set; }
        public tbl_class Class { get; set; }
    }
}
