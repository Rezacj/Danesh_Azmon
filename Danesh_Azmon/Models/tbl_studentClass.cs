using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace Danesh_Azmon.Models
{
    public class tbl_studentClass
    {
        [Key]
        public int StudentId { get; set; }
        public tbl_user Student { get; set; }

        public int ClassId { get; set; }
        public tbl_class Class { get; set; }
    }
}
