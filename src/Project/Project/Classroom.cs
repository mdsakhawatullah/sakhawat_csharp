using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Classroom
    {
        [Key]
        public int ClassId { get; set; }
        public string? ClassName { get; set; }
        public string? SujectName { get; set; }
        public string? TeacherName { get; set; }
    }
}
