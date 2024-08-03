﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Crud_operation.Models
{
    public class Student
    {
        [Key]
        public int? Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public int? Age { get; set; }
    }
}