﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class User
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }

       public UserRole Role { get; set; }
    }
}
