﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }
        [Display(Name="Number of Days")]
        [Required]
        [Range(0,100, ErrorMessage = "Please select nubmer between 0 and 100")]
        public int NumberOfDays { get; set; }
        [Display(Name ="Allocation Period")]
        [Required]
        public int Period { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }
    }
}