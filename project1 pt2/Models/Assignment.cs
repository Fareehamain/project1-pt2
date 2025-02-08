using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace project1_pt2.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public string OwnerName { get; set; }
        public string Address {  get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }

        public int EmployeeId { get; set; }
        public Employee AssignedEmployee {  get; set; }


    }

    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string first_name { get; set; }
        [Required]
        public string last_name { get; set; }

        [Required]
        public string Role { get; set; }
        public Employee AssignedEmployee { get; set; }
    }
}