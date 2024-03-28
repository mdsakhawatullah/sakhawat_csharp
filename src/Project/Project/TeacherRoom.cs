using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class TeacherRoom
    {
        [Key]
        public int Id { get; set; }
        public string? StudentName { get; set; }
        public float Grade { get; set; }
        public string? ClassName { get; set; }
        public string? SubjectName { get; set; }

    }
}
