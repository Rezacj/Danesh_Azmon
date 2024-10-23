using System.ComponentModel.DataAnnotations;

namespace Danesh_Azmon.Models
{
    public class tbl_exam
    {
        [Key]
        public int ExamId { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // ارتباط با Questions و ExamClasses
        public ICollection<tbl_question> Questions { get; set; }
        public ICollection<tbl_examClass> ExamClasses { get; set; }
    }
}
