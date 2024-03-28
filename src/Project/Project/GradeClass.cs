using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class GradeClass
    {
        [Key]
        public int ID {  get; set; }
        public int FirstTerm {  get; set; }
        public int MidTerm { get; set; }
        public int Final { get; set; }
    }
}
