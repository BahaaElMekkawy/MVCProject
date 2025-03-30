﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Models
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public string? Description { get; set; }
    }
}
