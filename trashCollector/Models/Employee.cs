﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace trashCollector.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeNumber { get; set; }
        public string Name { get; set; }
        public int EmployeeZipCode { get; set; }

        [ForeignKey("IdentityEmployee")]
        public string IdentityEmployeeId { get; set; }
        public IdentityUser IdentityEmployee { get; set; }
    } 
}
