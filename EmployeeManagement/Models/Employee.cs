﻿using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [Range(18, 65)]
        public int Age { get; set; }
        [Required] 
        public string Position { get; set; }
    }
}
