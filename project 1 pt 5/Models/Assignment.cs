using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace project_1_pt_5.Models
{
    public class Assignment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string OwnerName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Description { get; set; }

        public bool Completed { get; set; } = false;

        public int EmployeeId { get; set; }
        public Employee AssignedEmployee { get; set; }
    }
}