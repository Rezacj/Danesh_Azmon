using System.ComponentModel.DataAnnotations;

namespace Danesh_Azmon.Models
{
    public class tbl_question
    {
        [Key]
        public int QuestionId { get; set; }
        public string Text { get; set; }

        // ارتباط با Exam
        public int ExamId { get; set; }
        public tbl_exam Exam { get; set; }
    }
}
